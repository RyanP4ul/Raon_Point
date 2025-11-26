using Dapper;
using RaonPointWindowsForms.Data;
using RaonPointWindowsForms.Entities.Model;
using RaonPointWindowsForms.Forms.Admin;
using RaonPointWindowsForms.Forms.Components;
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
    public partial class MemberListItem : UserControl
    {

        private Color backColor;
        private dynamic member;
        private bool isAllMembers = true;

        public MemberListItem()
        {
            InitializeComponent();
        }

        public dynamic GetMember() => member;

        // Sets the data for the member list item
        public void SetData(dynamic member, bool isAllMembers = true)
        {
            this.member = member;
            this.isAllMembers = isAllMembers;

            lblMemberId.Text = $"M-{member.id.ToString()}";
            lblName.Text = $"{member.first_name} {member.last_name}";
            lblPlan.Text = member.plan;

            if (isAllMembers)
            {
                var joiningDate = DateTime.Parse(member.joining_date?.ToString());
                var expirationDate = DateTime.Parse(member.expiration_date?.ToString());

                lblEdit.Text = "Edit";
                lblDelete.Text = "Delete";
                lblJoiningDate.Text = joiningDate.ToString("MM/dd/yyyy");
                lblExpiredDate.Text = expirationDate.ToString("MM/dd/yyyy");

                Console.WriteLine($"{member.first_name} {member.expiration_date}");

                if (DateTime.Parse(expirationDate.ToString()) >= DateTime.Now)
                {
                    lblStatus.Text = "Active";
                    lblStatus.ForeColor = Color.Green;
                }
                else
                {
                    lblStatus.Text = "Expired";
                    lblStatus.ForeColor = Color.Red;
                }
            }
            else
            {
                lblEdit.Text = "Verify";
                lblDelete.Text = "Reject";
                lblJoiningDate.Text = member.created_at?.ToString("MM/dd/yyyy HH:mm:ss tt");

                lblStatus.Visible = false;
                lblExpiredDate.Visible = false;
            }
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

        private async void lblEdit_Click(object sender, EventArgs e)
        {
            var memberPage = (Members)Main.CurrentControl;

            if (isAllMembers)
            {
                memberPage.EditMember(member);
            }
            else
            {
                // APPROVE MEMBER
                int memberId = Convert.ToInt32(member.id);
                await memberPage.SelectPlan(memberId);
            }
        }

        private async void lblDelete_Click(object sender, EventArgs e)
        {
            var memberPage = (Members) Main.CurrentControl;
            int memberId = Convert.ToInt32(member.id);
            await memberPage.DeleteMember(memberId);
        }

        private void lblEdit_MouseHover(object sender, EventArgs e)
        {
            lblEdit.Cursor = Cursors.Hand;
        }

        private void lblEdit_MouseLeave(object sender, EventArgs e)
        {
            lblEdit.Cursor = Cursors.Default;
        }

        private void lblDelete_MouseEnter(object sender, EventArgs e)
        {
            lblDelete.Cursor = Cursors.Hand;
        }

        private void lblDelete_MouseLeave(object sender, EventArgs e)
        {
            lblDelete.Cursor = Cursors.Default;
        }
    }

}