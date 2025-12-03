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

namespace RaonPointWindowsForms.Views.Components
{
    public partial class UserListItem : UserControl
    {
        private User user;

        public UserListItem()
        {
            InitializeComponent();
        }

        public void SetData(User user)
        {
            this.user = user;
            lblFullName.Text = $"{user.first_name} {user.last_name}";
            lblEmail.Text = user.email;
            lblRole.Text = user.role;
        }

        public User GetUser()
        {
            return user;
        }

        private async void lblEdit_Click(object sender, EventArgs e)
        {
            var users = (Users) Main.CurrentControl;
            await users.EditUser(user);
        }

        private async void lblDelete_Click(object sender, EventArgs e)
        {
            var users = (Users)Main.CurrentControl;
            await users.DeleteUser(user.id);
        }
    }
}
