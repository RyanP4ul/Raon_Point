using Dapper;
using RaonPointWindowsForms.Auth;
using RaonPointWindowsForms.Data;
using RaonPointWindowsForms.Repository;
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

    public partial class Schedules : UserControl
    {
        public Schedules()
        {
            InitializeComponent();
        }

        private async void Schedules_Load(object sender, EventArgs e)
        {
            await InitLists();
        }

        private async Task InitLists()
        {
            panelTable.Controls.Clear();

            int index = 0;
            int itemsPerRow = 3;
            int spacing = 30;

            await Database.Instance.ExecuteWithConnection(async connection =>
            {
                var schedules = await connection.QueryAsync<dynamic>(
                    "SELECT s.id, s.start_time, s.end_time, s.location, s.max_capacity, s.name, s.category, (SELECT name FROM users WHERE id = s.trainer_id) AS trainer_name, (SELECT COUNT(*) FROM bookings WHERE schedule_id = s.id) as book_count FROM class_schedules as s WHERE CAST(s.start_time AS DATE) = @today",
                    new { today = DateTime.Today }
                );

                foreach (var schedule in schedules)
                {
                    var scheduleItem = new ClassScheduleListItem(schedule, false);
                    int column = index % itemsPerRow;
                    int row = index / itemsPerRow;
                    int x = column * (scheduleItem.Width + spacing);
                    int y = row * (scheduleItem.Height + spacing);

                    scheduleItem.Location = new Point(x, y);
                    panelTable.Controls.Add(scheduleItem);
                    index++;
                }
            });
        }

        public async void JoinSchedule(int scheduleId)
        {
            await Database.Instance.ExecuteWithTransactionAsync(async (connection, transaction) =>
            {
                //Console.WriteLine($"Schedule ID: {scheduleId}");
                //Console.WriteLine($"Schedule ID: {scheduleId}");

                var isJoined = await connection.ExecuteScalarAsync<int>(
                    "SELECT COUNT(*) FROM bookings WHERE schedule_id = @ScheduleId AND member_id = @MemberId",
                    new
                    {
                        ScheduleId = scheduleId,
                        MemberId = Session.member_id
                    },
                    transaction: transaction
                ) > 0;

                if (isJoined)
                {
                    MessageBox.Show("You have already joined this class schedule.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                await connection.ExecuteAsync(
                    "INSERT INTO bookings (schedule_id, member_id) VALUES (@ScheduleId, @MemberId)",
                    new
                    {
                        ScheduleId = scheduleId,
                        MemberId = Session.member_id
                    },
                    transaction: transaction
                );

                await HistoryRepository.CreateHistory(connection, transaction, "Join Class Schedule", $"Member ID {Session.CurrentUser.id} joined schedule ID {scheduleId}");

                MessageBox.Show("Successfully joined the class schedule.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            });

            await InitLists();
        }

    }

}
