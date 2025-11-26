using Dapper;
using RaonPointWindowsForms.Data;
using RaonPointWindowsForms.Entities.Model;
using RaonPointWindowsForms.Forms.Admin;
using RaonPointWindowsForms.Forms.Components;
using RaonPointWindowsForms.Repository;
using RaonPointWindowsForms.Views.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace RaonPointWindowsForms.Views.Pages.Trainer
{
    [ToolboxItem(false)]
    public partial class Members : UserControl
    {

        private string currentTab = "all_members";
        private List<MemberListItem> MemberLists = new List<MemberListItem>();

        public Members()
        {
            InitializeComponent();
        }

        private void ResetLists()
        {
            foreach (MemberListItem item in panelTable.Controls.OfType<MemberListItem>().ToList())
            {
                panelTable.Controls.Remove(item);
            }
        }

        private async void Members_Load(object sender, EventArgs e)
        {
            MemberLists.Clear();

            await InitMembers();
        }

        public async Task RefreshLists()
        {
            if (currentTab == "all_members")
            {
                await InitMembers();
            }
            else if (currentTab == "pending_approval")
            {
                await InitPendingApproval();
            }
        }

        // Load members from database and add to panel
        private async Task InitMembers()
        {
            ResetLists();

            lblStatus.Visible = true;
            lblExpiredDate.Visible = true;
            lblJoinDate.Text = "Join Date";

            await Database.Instance.ExecuteWithConnection(async connection => {
                var members = connection.Query<dynamic>("SELECT m.id, u.id AS user_id, u.first_name, u.last_name, ms.plan, ms.joining_date, ms.expiration_date FROM members AS m LEFT JOIN users AS u ON m.user_id = u.id LEFT JOIN member_ships AS ms ON m.id = ms.member_id WHERE u.role = 'User' AND m.is_verified = 1");

                foreach (var member in members)
                {
                    var item = new MemberListItem();
                    item.BackColor = panelTable.Controls.Count % 2 == 0 ? Color.FromArgb(30, 30, 30) : Color.FromArgb(50, 50, 50);
                    item.Location = new Point(0, (panelTable.Controls.Count) * item.Height);
                    item.SetData(member);
                    MemberLists.Add(item);
                    panelTable.Controls.Add(item);
                }

            });
        }

        private async Task InitPendingApproval()
        {
            ResetLists();

            lblStatus.Visible = false;
            lblExpiredDate.Visible = false;
            lblJoinDate.Text = "Created Date";

            await Database.Instance.ExecuteWithConnection(async connection => {
                var members = connection.Query<dynamic>("SELECT m.id, m.created_at, u.first_name, u.last_name, ms.plan FROM members AS m LEFT JOIN users AS u ON m.user_id = u.id LEFT JOIN member_ships AS ms ON m.membership_id = ms.id WHERE u.role = 'User' AND m.is_verified = 0");

                foreach (var member in members)
                {
                    var item = new MemberListItem();
                    item.BackColor = panelTable.Controls.Count % 2 == 0 ? Color.FromArgb(30, 30, 30) : Color.FromArgb(50, 50, 50);
                    item.Location = new Point(0, (panelTable.Controls.Count) * item.Height);
                    item.SetData(member, false);
                    MemberLists.Add(item);
                    panelTable.Controls.Add(item);
                }

            });
        }

        private void btnAddNewMember_Click(object sender, EventArgs e)
        {
            var main = (Main) Parent.Parent;
            main.LoadUserControl(new Registration());
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (MemberListItem item in panelTable.Controls.OfType<MemberListItem>().ToList())
            {
                panelTable.Controls.Remove(item);
            }

            var searchText = tbSearch.Text.ToLower();
            var count = 0;

            foreach (MemberListItem item in MemberLists)
            {
                var fullName = item.GetMember().first_name + " " + item.GetMember().last_name;
                var memberName = fullName.ToLower();

                if (!memberName.Contains(searchText)) continue;

                item.Location = new Point(0, (count + 1) * item.Height);
                panelTable.Controls.Add(item);
                count++;
            }
        }

        private async void btnAllMembers_Click(object sender, EventArgs e)
        {
            if (currentTab == "all_members") return;

            currentTab = "all_members";

            await InitMembers();
        }

        private async void btnPendingApproval_Click(object sender, EventArgs e)
        {
            if (currentTab == "pending_approval") return;

            currentTab = "pending_approval";

            await InitPendingApproval();
        }

        public async Task EditMember(dynamic member)
        {
            var main = (Main) Parent.Parent;
            main.ShowModal(new EditUser(member));
        }

        public async Task UpdateMember(int memberId, int userId, string first_name, string last_name, string plan)
        {
            var main = (Main) Parent.Parent;

            await Database.Instance.ExecuteWithTransactionAsync(async (connection, transaction) =>
            {
                await connection.ExecuteAsync(
                    "UPDATE users SET first_name = @FirstName, last_name = @LastName WHERE id = @UserId",
                    new { FirstName = first_name, LastName = last_name, UserId = userId },
                    transaction: transaction
                );

                await connection.ExecuteAsync(
                    "UPDATE member_ships SET plan = @Plan WHERE member_id = @MemberId",
                    new { Plan = plan, MemberId = memberId },
                    transaction: transaction
                );

                await HistoryRepository.CreateHistory(connection, transaction, "Update Member", $"Updated member ID {memberId} details.");
            });

            await RefreshLists();

            MessageBox.Show("Member details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public async Task SelectPlan(int memberId)
        {
            var main = (Main) Parent.Parent;

            main.ShowModal(new Approved(async (string plan, DateTime expirationDate) =>
            {
                await Database.Instance.ExecuteWithTransactionAsync(async (connection, transaction) =>
                {
                    var memberShip = await connection.QueryFirstOrDefaultAsync<Membership>(
                        "SELECT plan, expiration_date FROM member_ships WHERE member_id = @MemberId",
                        new { MemberId = memberId },
                        transaction: transaction
                    );

                    if (memberShip == null)
                    {
                        // IF NO MEMBERSHIP EXISTS, CREATE A NEW ONE
                        // USUALLY FOR FIRST TIME APPROVAL

                        await connection.ExecuteAsync(
                            "UPDATE members SET is_verified = 1 WHERE id = @Id",
                            new { Id = memberId },
                            transaction: transaction
                        );

                        await connection.ExecuteAsync("INSERT INTO member_ships (member_id, plan, expiration_date) VALUES (@MemberId, @Plan, @ExpirationDate)", new
                        {
                            MemberId = memberId,
                            Plan = plan,
                            ExpirationDate = expirationDate
                        }, transaction);

                        await HistoryRepository.CreateHistory(connection, transaction, "Approve Member", $"Approved member ID {memberId} with plan {plan}.");

                        MessageBox.Show("Member approved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // USED FOR RENEWAL OF MEMBERSHIP

                        var currentExpirationDate = memberShip.expiration_date;

                        // IF THERE IS STILL REMAINING TIME, ADD THE NEW PLAN DURATION TO THE CURRENT EXPIRATION DATE
                        if (currentExpirationDate > DateTime.Now)
                        {
                            expirationDate = currentExpirationDate.AddMonths((expirationDate - DateTime.UtcNow).Days / 30);
                        }

                        await connection.ExecuteAsync("UPDATE member_ships SET plan = @Plan, expiration_date = @ExpirationDate WHERE member_id = @MemberId",
                            new
                            {
                                Plan = plan,
                                ExpirationDate = expirationDate,
                                MemberId = memberId
                            },
                            transaction: transaction
                        );

                        await HistoryRepository.CreateHistory(connection, transaction, "Renew Membership", $"Renewed membership for member ID {memberId} with plan {plan}.");

                        MessageBox.Show("Membership renewed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    
                });

                await RefreshLists();
            }));

            //main.ShowModal(new ConfirmModal(async () =>
            //{
            //    await Database.Instance.ExecuteWithTransactionAsync(async (connection, transaction) =>
            //    {
            //        await connection.ExecuteAsync(
            //            "UPDATE members SET is_verified = 1 WHERE id = @Id",
            //            new { Id = memberId },
            //            transaction: transaction
            //        );
            //    });
            //    await Refresh();

            //    MessageBox.Show("Member approved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}));
        }

        public async Task DeleteMember(int memberId)
        {
            var main = (Main) Parent.Parent;

            main.ShowModal(new ConfirmModal(async () =>
            {
                await Database.Instance.ExecuteWithTransactionAsync(async (connection, transaction) =>
                {
                    await connection.ExecuteAsync(
                        "DELETE FROM members WHERE id = @Id",
                        new { Id = memberId },
                        transaction: transaction
                    );

                    await HistoryRepository.CreateHistory(connection, transaction, "Delete Member", $"Deleted member ID {memberId}.");
                });

                await RefreshLists();

                MessageBox.Show("Member deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }));
        }

}
}
