using Dapper;
using RaonPointWindowsForms.Data;
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
    public partial class History : UserControl
    {
        public History()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private async void History_Load(object sender, EventArgs e)
        {
            await Database.Instance.ExecuteWithConnection(async connection =>
            {
                var histories = await connection.QueryAsync<dynamic>("SELECT h.action, h.details, h.created_at, u.first_name, u.last_name FROM history AS h LEFT JOIN users as u ON h.user_id = u.id");

                foreach (var history in histories)
                {
                    var item = new HistoryListItem();
                    item.SetData(history);
                    item.BackColor = panelTable.Controls.Count % 2 == 0 ? Color.FromArgb(30, 30, 30) : Color.FromArgb(50, 50, 50);
                    item.Location = new Point(0, (panelTable.Controls.Count - 3) * item.Height);
                    panelTable.Controls.Add(item);
                }

            });
        }

        private void historyListItem1_Load(object sender, EventArgs e)
        {

        }
    }
}
