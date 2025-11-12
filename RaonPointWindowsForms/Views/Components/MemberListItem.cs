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
    public partial class MemberListItem : UserControl
    {

        private Color backColor;

        public MemberListItem()
        {
            InitializeComponent();
        }

        public void SetFields(string[] data)
        { 
            lblName.Text = data[0];
            lblMemberId.Text = data[1];
            lblPlans.Text = data[2];
            lblJoiningDate.Text = data[3];
            lblExpiredDate.Text = data[4];
            lblCost.Text = data[5];
            lblStatus.Text = data[6];
        }

        private void MemberListItem_Load(object sender, EventArgs e)
        {
            backColor = this.BackColor;
        }

        private void MemberListItem_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(70, 70, 70);
            Cursor = Cursors.Hand;
        }

        private void MemberListItem_MouseLeave(object sender, EventArgs e)
        {
            BackColor = backColor;
            Cursor = Cursors.Default;
        }

        
    }
}
