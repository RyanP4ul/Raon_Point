using Dapper;
using RaonPointWindowsForms.Data;
using RaonPointWindowsForms.Entities.Model;
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
    public partial class CreateSchedule : Form
    {
        public CreateSchedule()
        {
            InitializeComponent();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void CreateSchedule_Load(object sender, EventArgs e)
        {
            await Database.Instance.ExecuteWithConnection(async (connection) =>
            {
                var trainers = await connection.QueryAsync<User>("SELECT id, first_name, last_name FROM users WHERE role = 'Trainer'");

                foreach (var t in trainers)
                {
                    cbTrainer.Items.Add($"{t.id} {t.first_name} {t.last_name}");
                }
            });
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbClassName.Texts) || string.IsNullOrEmpty(tbCategory.Texts) || string.IsNullOrEmpty(tbStartTime.Texts) || string.IsNullOrEmpty(tbEndTime.Texts) || string.IsNullOrEmpty(tbLocation.Texts) || cbTrainer.SelectedItem == null)
            {
                MessageBox.Show("Invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(tbMaxCapacity.Texts, out var max_capacity))
            {
                MessageBox.Show("Max Capacity must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (max_capacity > 0)
            {
                MessageBox.Show("Invalid Max Capacity. Make sure it greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var classSchedule = (Views.Pages.Trainer.ClassSchedule) Main.CurrentControl;
            classSchedule.CreateSchedule(tbClassName.Texts, tbCategory.Texts, max_capacity, cbTrainer.SelectedItem.ToString(), tbStartTime.Texts, tbEndTime.Texts, tbLocation.Texts);
            Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
