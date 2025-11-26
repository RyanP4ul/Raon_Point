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
    public partial class RecentHistoryListItem : UserControl
    {

        private dynamic data;

        public RecentHistoryListItem(dynamic data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void RecentHistoryListItem_Load(object sender, EventArgs e)
        {
            lblAction.Text = data.action;
            lblUser.Text = data.full_name;
        }
    }
}
