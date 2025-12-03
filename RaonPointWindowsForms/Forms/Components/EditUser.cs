using RaonPointWindowsForms.Entities.Model;
using RaonPointWindowsForms.Forms.Admin;
using RaonPointWindowsForms.Views.Pages.Admin;
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

        private User user;

        public EditUser()
        {
            InitializeComponent();
        }

        public void SetUser(User user)
        {
            this.user = user;
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            cbRole.Items.Add("User");
            cbRole.Items.Add("Trainer");
            cbRole.Items.Add("Admin");

            tbFirstName.Texts = user.first_name;
            tbLastName.Texts = user.last_name;
            tbEmail.Texts = user.email;
            cbRole.SelectedItem = user.role;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var users = (Users) Main.CurrentControl;

            await users.SaveUser(user.id, tbFirstName.Texts, tbLastName.Texts, tbEmail.Texts, cbRole.SelectedItem.ToString());

            this.Close();
        }
    }
}
