using RaonPointWindowsForms.Forms.Admin;
using RaonPointWindowsForms.Views.Pages.Trainer;
using RaonPointWindowsForms.Views.Pages.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaonPointWindowsForms.Views.Components
{
    public partial class ClassScheduleListItem : UserControl
    {

        private dynamic data;
        private bool isTrainer;

        public ClassScheduleListItem(dynamic data, bool isTrainer = true)
        {
            InitializeComponent();
            this.data = data;
            this.isTrainer = isTrainer;
        }

        private void ClassScheduleListItem_Load(object sender, EventArgs e)
        {
            lblName.Text = data.name;
            lblCategory.Text = data.category;
            lblTrainer.Text = data.trainer_name;
            lblTime.Text = $"{(DateTime) data.start_time:hh:mm tt} - {(DateTime) data.end_time:hh:mm tt}";
            lblBookings.Text = $"{data.book_count}/{data.max_capacity}";
            pgBooking.Value = (int)(((double)data.book_count / (double)data.max_capacity) * 100);

            if (isTrainer)
            {
                pbDelete.Visible = true;
                btnViewBooking.Text = "View Booking Details";
            }
            else
            {
                pbDelete.Visible = false;

                if (data.book_count >= data.max_capacity)
                {
                    btnViewBooking.Enabled = false;
                    btnViewBooking.Text = "Full";
                }
                else
                {
                    btnViewBooking.Text = "Join";
                }
            }
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            var classSchedule = (Views.Pages.Trainer.ClassSchedule) Main.CurrentControl;
            classSchedule.DeleteSchedule(Convert.ToInt32(data.id));
        }

        private void pbDelete_MouseEnter(object sender, EventArgs e)
        {
            pbDelete.Cursor = Cursors.Hand;
        }

        private void pbDelete_MouseLeave(object sender, EventArgs e)
        {
            pbDelete.Cursor = Cursors.Default;
        }

        private void btnViewBooking_Click(object sender, EventArgs e)
        {
            var current = Main.CurrentControl;

            if (current is ClassSchedule cs)
            {
                cs.ViewBookingsDetails(Convert.ToInt32(data.id));
            }
            else if (current is Schedules s)
            {
                s.JoinSchedule(Convert.ToInt32(data.id));
            }
        }

    }
}
