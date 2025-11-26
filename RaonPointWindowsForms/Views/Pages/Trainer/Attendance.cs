using Dapper;
using RaonPointWindowsForms.Data;
using RaonPointWindowsForms.Entities.Model;
using RaonPointWindowsForms.Forms.Admin;
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
using System.Windows.Forms;

namespace RaonPointWindowsForms.Views.Pages.Trainer
{
    [ToolboxItem(false)]
    public partial class Attendance : UserControl
    {

        public static AttendanceListItem CurrentItem { get; set; }

        public Attendance()
        {
            InitializeComponent();
        }

        private async void Attendance_Load(object sender, EventArgs e)
        {
            await InitAttendance();
        }

        private async Task InitAttendance()
        {
            foreach (var item in panelTable.Controls.OfType<AttendanceListItem>().ToList())
            {
                panelTable.Controls.Remove(item);
                item.Dispose();
            }

            await Database.Instance.ExecuteWithConnection(async connection => {

                var members = connection.Query<dynamic>("SELECT u.first_name, u.last_name, m.id, m.check_out_date, m.check_in_date, ms.expiration_date FROM users AS u LEFT JOIN members AS m ON u.id = m.user_id LEFT JOIN member_ships AS ms ON m.id = ms.member_id WHERE m.is_verified = 1 AND CAST(m.check_in_date AS DATE) = @today", new { today = DateTime.Today });

                foreach (var member in members)
                {
                    if (member.check_in_date == null || DateTime.UtcNow > member.expiration_date) continue;

                    var attendanceListItem = new AttendanceListItem();
                    int rowIndex = panelTable.Controls.OfType<AttendanceListItem>().Count();
                    
                    attendanceListItem.BackColor = panelTable.Controls.Count % 2 == 0 ? Color.FromArgb(30, 30, 30) : Color.FromArgb(50, 50, 50);
                    attendanceListItem.Size = new Size(panelTable.Width, attendanceListItem.Height);
                    attendanceListItem.Location = new Point(0, (rowIndex + 1) * attendanceListItem.Height);
                    attendanceListItem.SetData(member);

                    panelTable.Controls.Add(attendanceListItem);
                }
            });
        }

        private async Task<int> ValidateAndGetMemberId(IDbConnection connection)
        {
            if (string.IsNullOrWhiteSpace(tbMemId.Text))
            {
                MessageBox.Show("Member ID is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            if (!tbMemId.Text.Contains("-"))
            {
                MessageBox.Show("Invalid must contains '-'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            if (!int.TryParse(tbMemId.Text.Split('-')[1], out int member_id))
            {
                MessageBox.Show("Invalid User ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            var isExist = await connection.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM members WHERE id = @id AND is_verified = 1", new { id = member_id });

            if (isExist == 0)
            {
                MessageBox.Show("Member does not exist or is not verified.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            var expirationDate = await connection.ExecuteScalarAsync<DateTime?>("SELECT expiration_date FROM member_ships WHERE member_id = @id", new { id = member_id });

            if (!expirationDate.HasValue)
            {
                MessageBox.Show("No membership record found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            if (expirationDate.Value <= DateTime.UtcNow)
            {
                MessageBox.Show("Membership has expired.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            return member_id;
        }

        private async void btnCheckOut_Click(object sender, EventArgs e)
        {
            await Database.Instance.ExecuteWithTransactionAsync(async (connection, transaction) =>
            {
                var member_id = await ValidateAndGetMemberId(connection);

                if (member_id == -1) return;

                var isCheckIn = await connection.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM members WHERE id = @id AND CAST(check_in_date AS DATE) = @today", new
                {
                    id = member_id,
                    today = DateTime.Today
                }, transaction);

                if (isCheckIn == 0)
                {
                    MessageBox.Show("Member has not checked in today or already checked out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var now = DateTime.UtcNow;

                await connection.ExecuteAsync("UPDATE members SET check_out_date = @checkOutDate, check_in_date = null WHERE id = @id", new
                {
                    checkOutDate = now,
                    id = member_id
                }, transaction);

                await HistoryRepository.CreateHistory(connection, transaction, "Check-Out", $"Member ID {member_id} checked out at {now}.");

                MessageBox.Show("Check-out successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            });

            await InitAttendance();
        }

        private async void btnCheckIn_Click(object sender, EventArgs e)
        {
            await Database.Instance.ExecuteWithTransactionAsync(async (connection, transaction) =>
            {
                var member_id = await ValidateAndGetMemberId(connection);

                if (member_id == -1) return;

                var now = DateTime.UtcNow;

                await connection.ExecuteAsync("UPDATE members SET check_in_date = @checkInDate, check_out_date = null, check_in_count = (check_in_count + 1) WHERE id = @id", new
                {
                    checkInDate = now,
                    id = member_id
                }, transaction);

                await HistoryRepository.CreateHistory(connection, transaction, "Check-In", $"Member ID {member_id} checked in at {now}.");

                MessageBox.Show("Check-in successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            });

            await InitAttendance();
        }
    }
}
