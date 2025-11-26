using Dapper;
using RaonPointWindowsForms.Data;
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

namespace RaonPointWindowsForms.Forms.Components
{
    public partial class ViewBookingDetails : Form
    {

        private int scheduleId;

        public ViewBookingDetails(int scheduleId)
        {
            InitializeComponent();
            this.scheduleId = scheduleId;
        }

        private async void ViewBookingDetails_Load(object sender, EventArgs e)
        {
            await Database.Instance.ExecuteWithConnection(async connection =>
            {
                var schedules = await connection.QueryAsync<dynamic>("SELECt u.first_name, u.last_name, (SELECt name FROM class_schedules WHERE id = b.schedule_id) as title FROM bookings as b LEFT JOIN members AS m ON b.member_id = m.id LEFT JOIN users AS u ON m.user_id = u.id WHERE b.id = @Id", new { 
                    Id = scheduleId
                });

                if (schedules == null) return;

                foreach (var schedule in schedules)
                {
                    var full_name = schedule.first_name + " " + schedule.last_name;
                    var item = new BookingListItem(full_name);
                    item.Location = new Point(0, panelTable.Controls.Count * item.Height);
                    panelTable.Controls.Add(item);
                }
            });
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
