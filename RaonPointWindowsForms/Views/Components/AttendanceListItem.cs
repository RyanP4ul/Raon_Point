using RaonPointWindowsForms.Entities.Model;
using RaonPointWindowsForms.Views.Pages.Trainer;
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
    public partial class AttendanceListItem : UserControl
    {

        private dynamic data;

        public AttendanceListItem()
        {
            InitializeComponent();
        }

        public dynamic GetData() => data;

        public void SetData(dynamic data)
        {
            this.data = data;
            lblMemId.Text = $"M-{data.id}";
            lblName.Text = $"{data.first_name} {data.last_name}";
            lblCheckInTime.Text = data.check_in_date.ToString("HH:mm:ss tt");
        }

        private void AttendanceListItem_Load(object sender, EventArgs e)
        {

        }

        private void AttendanceListItem_Click(object sender, EventArgs e)
        {
            //Attendance.CurrentItem = this;
        }
    }
}
