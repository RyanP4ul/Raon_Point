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
using System.Windows.Forms;

namespace RaonPointWindowsForms.Views.Pages.Trainer
{
    public partial class ClassSchedule : UserControl
    {
        public ClassSchedule()
        {
            InitializeComponent();
        }

        private async void ClassSchedule_Load(object sender, EventArgs e)
        {
            await InitLists();
        }

        private async Task InitLists()
        {
            panelTable.Controls.Clear();

            int index = 0;
            int itemsPerRow = 3;
            int spacing = 30;

            await Database.Instance.ExecuteWithConnection(async (connection) =>
            {
                var classes = await connection.QueryAsync<dynamic>("SELECT s.id, s.start_time, s.end_time, s.location, s.max_capacity, s.name, s.category, (SELECT name FROM users WHERE id = s.trainer_id) AS trainer_name, (SELECT COUNT(*) FROM bookings WHERE schedule_id = s.id) as book_count FROM class_schedules as s");

                if (classes.Count() < 1) return;

                foreach (var schedule in classes)
                {
                    var item = new ClassScheduleListItem(schedule);
                    int column = index % itemsPerRow;
                    int row = index / itemsPerRow;
                    int x = column * (item.Width + spacing);
                    int y = row * (item.Height + spacing);

                    item.Location = new Point(x, y);
                    panelTable.Controls.Add(item);

                    index++;
                }
            });
        }

        public async void CreateSchedule(string name, string category, int maxCapacity, string trainer, string start_time, string end_time, string location)
        {
            await Database.Instance.ExecuteWithTransactionAsync(async (connection, transaction) => {

                await connection.ExecuteAsync(
                    "INSERT INTO class_schedules (name, category, max_capacity, trainer_id, start_time, end_time, location) VALUES (@Name, @Category, @MaxCapacity, @TrainerId, @StartTime, @EndTime, @Location)",
                    new
                    {
                        Name = name,
                        Category = category,
                        MaxCapacity = maxCapacity,
                        TrainerId = int.Parse(trainer.Split(' ')[0]),
                        StartTime = DateTime.ParseExact(start_time, "hh:mm tt", null),
                        EndTime = DateTime.ParseExact(end_time, "hh:mm tt", null),
                        Location = location
                    },
                    transaction: transaction
                );

                await HistoryRepository.CreateHistory(connection, transaction, "Create Class Schedule", $"Created class schedule: {name}");

            });

            await InitLists();

            MessageBox.Show("Class schedule created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public async void ViewBookingsDetails(int scheduleId)
        {
            var main = (Main)Parent.Parent;
            
            main.ShowModal(new ViewBookingDetails(scheduleId));
        }

        public async void DeleteSchedule(int scheduleId)
        {

            var main = (Main)Parent.Parent;

            main.ShowModal(new ConfirmModal(async () =>
            {
                await Database.Instance.ExecuteWithTransactionAsync(async (connection, transaction) =>
                {
                    await connection.ExecuteAsync(
                        "DELETE FROM class_schedules WHERE id = @Id",
                        new { Id = scheduleId },
                        transaction: transaction
                    );

                    await HistoryRepository.CreateHistory(connection, transaction, "Delete Class Schedule", $"Deleted class schedule ID: {scheduleId}");
                });

                await InitLists();

                MessageBox.Show("Schedule deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }));
        }

        private void roundedBorderedButton1_Click(object sender, EventArgs e)
        {
            var main = (Main) Parent.Parent;
            main.ShowModal(new CreateSchedule());

            //main.ShowModal(new ConfirmModal(async () =>
            //{
            //    await Database.Instance.ExecuteWithTransactionAsync(async (connection, transaction) =>
            //    {
            //        await connection.ExecuteAsync(
            //            "DELETE FROM members WHERE id = @Id",
            //            new { Id = memberId },
            //            transaction: transaction
            //        );
            //    });

            //    await RefreshLists();

            //    MessageBox.Show("Member deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}));
        }
    }
}
