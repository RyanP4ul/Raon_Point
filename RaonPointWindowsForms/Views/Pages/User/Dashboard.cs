using Dapper;
using RaonPointWindowsForms.Auth;
using RaonPointWindowsForms.Data;
using RaonPointWindowsForms.Entities.Model;
using RaonPointWindowsForms.Views.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaonPointWindowsForms.Views.Pages.User
{
    public partial class Dashboard : UserControl
    {

        public Dashboard()
        {
            InitializeComponent();
        }

        private async void Dashboard_Load(object sender, EventArgs e)
        {
            lblFullName.Text = Session.CurrentUser.first_name + " " + Session.CurrentUser.last_name;

            await Database.Instance.ExecuteWithConnection(async connection =>
            {
                var member = await connection.QueryFirstOrDefaultAsync<dynamic>("SELECT m.id, m.check_in_count, s.plan, s.expiration_date FROM members AS m LEFT JOIN member_ships AS s ON m.id = s.member_id WHERE m.user_id = @UserID AND m.is_verified = 1", new {
                    UserID = Session.CurrentUser.id
                });

                if (member == null) return;

                var memberId = Convert.ToInt32(member.id);
                var check_in_count = Convert.ToInt32(member.check_in_count);
                var plan = Convert.ToString(member.plan);
                var expirationDate = Convert.ToDateTime(member.expiration_date);

                lblMem.Text = "M-" + memberId.ToString();
                lblPlan.Text = plan;
                lblCheckIn.Text = check_in_count.ToString();
                lblStatus.Text = expirationDate > DateTime.Now ? "Active" : "Expired";
                lblExpiration.Text = expirationDate.ToString("MMM dd, yyyy");
                lblDaysLeft.Text = ((expirationDate - DateTime.Now).Days > 0 ? (expirationDate - DateTime.Now).Days : 0).ToString() + " Days";

                await InitTodayScheduleLists();
            });
        }

        private async Task InitTodayScheduleLists()
        {
            panelTodaySchedules.Controls.Clear();

            await Database.Instance.ExecuteWithConnection(async connection =>
            {
                var schedules = await connection.QueryAsync<dynamic>("SELECT b.status, s.name, s.category, s.start_time, s.end_time, s.location, s.max_capacity, u.first_name, u.last_name FROM bookings AS b LEFT JOIN class_schedules AS s ON b.schedule_id = s.id LEFT JOIN users AS u ON s.trainer_id = u.id WHERE b.member_id = @MemberID", new
                {
                    MemberID = Session.member_id
                });

                foreach (var schedule in schedules)
                {
                    var scheduleItem = new TodayScheduleListItem(schedule);
                    scheduleItem.Location = new Point(0, panelTodaySchedules.Controls.Count * (scheduleItem.Height + 5));
                    panelTodaySchedules.Controls.Add(scheduleItem);
                }
            });
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
