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
    public partial class HistoryListItem : UserControl
    {

        private dynamic data;
        
        public HistoryListItem()
        {
            InitializeComponent();
        }

        public void SetData(dynamic data)
        {
            this.data = data;

            lblCreatedDate.Text = ((DateTime)data.created_at).ToString("yyyy-MM-dd HH:mm:ss");
            lblAction.Text = data.action;
            lblDetails.Text = data.details;
            lblUser.Text = $"{data.first_name} {data.last_name}";
        }

        private void lblAction_Click(object sender, EventArgs e)
        {

        }

        private void HistoryListItem_Load(object sender, EventArgs e)
        {
            
        }

        private void lblDetails_Click(object sender, EventArgs e)
        {

        }

        private void lblAction_Click_1(object sender, EventArgs e)
        {

        }
    }
}
