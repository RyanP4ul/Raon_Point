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

    public partial class TodayScheduleListItem : UserControl
    {

        private dynamic data;

        public TodayScheduleListItem(dynamic data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void TodayScheduleListItem_Load(object sender, EventArgs e)
        {
            lblTitle.Text = data.name;
            lblStudio.Text = $"{data.location} - {data.first_name} {data.last_name}";
            lblTime.Text = $"{Convert.ToDateTime(data.start_time).ToString("hh:mm tt")}";
        }
    }

}
