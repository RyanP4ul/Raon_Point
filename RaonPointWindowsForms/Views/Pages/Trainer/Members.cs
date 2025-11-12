using RaonPointWindowsForms.Forms.Admin;
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

namespace RaonPointWindowsForms.Views.Pages.Trainer
{
    [ToolboxItem(false)]
    public partial class Members : UserControl
    {

        private List<string[]> MemberLists = new List<string[]>();

        public Members()
        {
            InitializeComponent();
        }

        private void Members_Load(object sender, EventArgs e)
        {
            MemberLists.Clear();

            MemberLists.Add(new string[] { "Ryan Paul Espinola", "03212", "3 Months", "11/11/25", "11/11/25", "4,500", "Paid" });
            MemberLists.Add(new string[] { "Ryan Paul Espinola", "03212", "3 Months", "11/11/25", "11/11/25", "4,500", "Paid" });
            MemberLists.Add(new string[] { "Ryan Paul Espinola", "03212", "3 Months", "11/11/25", "11/11/25", "4,500", "Paid" });
            MemberLists.Add(new string[] { "Ryan Paul Espinola", "03212", "3 Months", "11/11/25", "11/11/25", "4,500", "Paid" });
            MemberLists.Add(new string[] { "Ryan Paul Espinola", "03212", "3 Months", "11/11/25", "11/11/25", "4,500", "Paid" });
            MemberLists.Add(new string[] { "Ryan Paul Espinola", "03212", "3 Months", "11/11/25", "11/11/25", "4,500", "Paid" });

            foreach (var member in MemberLists)
            {
                var memberListItem = new MemberListItem();
                memberListItem.SetFields(member);
                memberListItem.BackColor = panelTable.Controls.Count % 2 == 0 ? Color.FromArgb(30, 30, 30) : Color.FromArgb(50, 50, 50);
                memberListItem.Location = new Point(0, (panelTable.Controls.Count - 6) * memberListItem.Height);
                panelTable.Controls.Add(memberListItem);
            }
        }

        private void btnAddNewMember_Click(object sender, EventArgs e)
        {
            var main = (Main) Parent.Parent;
            main.LoadUserControl(new Registration());
        }
    }
}
