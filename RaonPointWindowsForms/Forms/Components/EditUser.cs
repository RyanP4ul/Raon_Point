using RaonPointWindowsForms.Forms.Admin;
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

namespace RaonPointWindowsForms.Forms.Components
{
    public partial class EditUser : Form
    {

        private dynamic member;

        public EditUser(dynamic member)
        {
            InitializeComponent();
            this.member = member;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var memberPage = (Members) Main.CurrentControl;

            memberPage.UpdateMember(
                Convert.ToInt32(member.id),
                Convert.ToInt32(member.user_id),
                tbFirstName.Texts,
                tbLastName.Texts,
                cbPlan.SelectedItem.ToString()
            );

            Close();
        }

        private async void EditUser_Load(object sender, EventArgs e)
        {
            cbPlan.Items.Add("Starter");
            cbPlan.Items.Add("Challenger");
            cbPlan.Items.Add("Performer");
            cbPlan.Items.Add("Transformer");

            tbFirstName.Texts = Convert.ToString(member.first_name);
            tbLastName.Texts = Convert.ToString(member.last_name);
            cbPlan.SelectedItem = Convert.ToString(member.plan);
            tbExpirationDate.Texts = Convert.ToDateTime(member.expiration_date).ToString("MM/dd/yyyy HH:mm:ss tt");
            tbExpirationDate.Enabled = false;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRenewal_Click(object sender, EventArgs e)
        {
            var memberPage = (Members)Main.CurrentControl;

            memberPage.SelectPlan(Convert.ToInt32(member.id));
        }
    }
}
