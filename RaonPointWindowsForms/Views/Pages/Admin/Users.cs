using Dapper;
using RaonPointWindowsForms.Data;
using RaonPointWindowsForms.Entities.Model;
using RaonPointWindowsForms.Forms.Admin;
using RaonPointWindowsForms.Forms.Components;
using RaonPointWindowsForms.Repository;
using RaonPointWindowsForms.Views.Components;
using RaonPointWindowsForms.Views.Pages.Trainer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestUser = RaonPointWindowsForms.Entities.Model.User;

namespace RaonPointWindowsForms.Views.Pages.Admin
{
    public partial class Users : UserControl
    {

        private List<UserListItem> MemberLists = new List<UserListItem>();

        public Users()
        {
            InitializeComponent();
        }

        private async Task LoadLists()
        {
            foreach (var item in MemberLists.OfType<UserListItem>().ToList())
            {
                panelTable.Controls.Remove(item);
                item.Dispose();
            }

            await Database.Instance.ExecuteWithConnection(async connection => {
                var users = await connection.QueryAsync<TestUser>("SELECT * FROM users");

                foreach (var user in users)
                {
                    var item = new UserListItem();
                    item.BackColor = panelTable.Controls.Count % 2 == 0 ? Color.FromArgb(30, 30, 30) : Color.FromArgb(50, 50, 50);
                    item.Location = new Point(0, (panelTable.Controls.Count) * item.Height);
                    item.SetData(user);
                    MemberLists.Add(item);
                    panelTable.Controls.Add(item);
                }

            });
        }

        private async void Users_Load(object sender, System.EventArgs e)
        {
            await LoadLists();
        }

        public async Task EditUser(TestUser user)
        {
            var main = (Main)Parent.Parent;
            var editUsers = new EditUser();
            editUsers.SetUser(user);
            main.ShowModal(editUsers);
        }

        public async Task SaveUser(int userId, string first_name, string last_name, string email, string role)
        {
            await Database.Instance.ExecuteWithTransactionAsync(async (connection, transaction) =>
            {
                await connection.ExecuteAsync(
                    "UPDATE users SET first_name = @FirstName, last_name = @LastName, role = @Role, updated_at = @Now WHERE id = @UserId",
                    new { FirstName = first_name, LastName = last_name, Role = role, Now = DateTime.Now, UserId = userId },
                    transaction: transaction
                );

                await HistoryRepository.CreateHistory(connection, transaction, "Update User", $"Updated user ID {userId} details.");
            });

            await LoadLists();

            MessageBox.Show("User details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tbSearch_TextChanged(object sender, System.EventArgs e)
        {
            foreach (UserListItem item in panelTable.Controls.OfType<UserListItem>().ToList())
            {
                panelTable.Controls.Remove(item);
            }

            var searchText = tbSearch.Text.ToLower();
            var count = 0;

            foreach (UserListItem item in MemberLists)
            {
                var fullName = item.GetUser().first_name + " " + item.GetUser().last_name;
                var memberName = fullName.ToLower();

                if (!memberName.Contains(searchText)) continue;

                item.Location = new Point(0, (count + 1) * item.Height);
                panelTable.Controls.Add(item);
                count++;
            }
        }

        public async Task DeleteUser(int userId)
        {
            var main = (Main) Parent.Parent;

            main.ShowModal(new ConfirmModal(async () =>
            {
                await Database.Instance.ExecuteWithTransactionAsync(async (connection, transaction) =>
                {
                    await connection.ExecuteAsync(
                        "DELETE FROM users WHERE id = @Id",
                        new { Id = userId },
                        transaction: transaction
                    );

                    await HistoryRepository.CreateHistory(connection, transaction, "Delete User", $"Deleted user ID {userId}.");
                });

                await LoadLists();

                MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }));
        }

    }
}
