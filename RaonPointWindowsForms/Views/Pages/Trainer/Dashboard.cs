using Dapper;
using RaonPointWindowsForms.Auth;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace RaonPointWindowsForms.Views.Pages.Trainer
{
    [ToolboxItem(false)]
    public partial class Dashboard : UserControl
    {

        public Dictionary<DayOfWeek, int> weeklyCounts = new Dictionary<DayOfWeek, int>
        {
            { DayOfWeek.Monday, 0 },
            { DayOfWeek.Tuesday, 0 },
            { DayOfWeek.Wednesday, 0 },
            { DayOfWeek.Thursday, 0 },
            { DayOfWeek.Friday, 0 },
            { DayOfWeek.Saturday, 0 },
            { DayOfWeek.Sunday, 0 }
        };

        public Dashboard()
        {
            InitializeComponent();
            
        }

        private async void Dashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome back, {Session.CurrentUser.first_name}!";

            await Database.Instance.ExecuteWithConnection(async (connection) =>
            {
                var now = DateTime.UtcNow;
                var since = now.AddMonths(-1);
                var inOneMonth = now.AddMonths(1);

                var totalMembers = await connection.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM members");
                var newMembers = await connection.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM member_ships WHERE joining_date >= @since", new { since = since });
                var expiringSoon = await connection.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM member_ships WHERE expiration_date BETWEEN @now AND @inOneMonth", new { now = now, inOneMonth = inOneMonth });
                var presentMembers = await connection.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM members WHERE DATE(check_in_date) = @now", new { now = DateTime.Today });

                lblTotalMembers.Text = totalMembers.ToString();
                lblNewMembers.Text = newMembers.ToString();
                lblExpiringSoon.Text = expiringSoon.ToString();
                lblPresent.Text = presentMembers.ToString();

                DateTime today = DateTime.Today;

                int diff = (7 + (today.DayOfWeek - DayOfWeek.Monday)) % 7;
                DateTime startOfWeek = today.AddDays(-1 * diff);
                DateTime endOfWeek = startOfWeek.AddDays(7);

                string query = @"
                    SELECT CAST(created_at AS DATE) as RegDate, COUNT(*) as Total
                    FROM members
                    WHERE created_at >= @Start AND created_at < @End
                    GROUP BY CAST(created_at AS DATE)";

                var results = await connection.QueryAsync<dynamic>(query, new { Start = startOfWeek, End = endOfWeek });

                foreach (var row in results)
                {
                    DateTime regDate = Convert.ToDateTime(row.RegDate);
                    int total = Convert.ToInt32(row.Total);
                    DayOfWeek dayOfWeek = regDate.DayOfWeek;
                    weeklyCounts[dayOfWeek] = total;

                    Console.WriteLine($"{dayOfWeek.ToString()} === {total}");
                }

            });

            await InitRecentHistoryLists();

            ApplyCustomColors();
        }

        private async Task InitRecentHistoryLists()
        {
            panelTable.Controls.Clear();

            int index = 0;
            int itemsPerRow = 3;
            int spacing = 30;
            await Database.Instance.ExecuteWithConnection(async (connection) =>
            {
                var histories = await connection.QueryAsync<dynamic>("SELECT h.action, CONCAT(u.first_name, ' ', u.last_name) as full_name FROM history as h LEFT JOIN users AS u ON h.user_id = u.id ORDER BY h.created_at DESC LIMIT 4");
                if (histories.Count() < 1) return;
                foreach (var history in histories)
                {
                    var item = new RecentHistoryListItem(history);
                    var offsetY = 3;
                    item.BackColor = panelTable.Controls.Count % 2 == 0 ? Color.FromArgb(30, 30, 30) : Color.FromArgb(50, 50, 50);
                    item.Location = new Point(0, panelTable.Controls.Count * (item.Height + offsetY));
                    panelTable.Controls.Add(item);
                    index++;
                }
            });
        }

        private void ApplyCustomColors()
        {
            var series = chart1.Series["Series1"];
            series.ChartType = SeriesChartType.Line;
            series.Points.Clear();
            series.IsVisibleInLegend = false;

            series.IsValueShownAsLabel = true;

            foreach (var day in weeklyCounts)
            {
                if (day.Value == 0)
                    continue;

                string label = GetShortDayName(day.Key);

                DataPoint point = new DataPoint();
                point.SetValueXY(label, day.Value);

                if (day.Key == DateTime.Today.DayOfWeek)
                {
                    point.Color = Color.OrangeRed;
                }

                series.Points.Add(point);
            }

            chart1.BackColor = Color.FromArgb(30, 30, 30);

            var chartArea = chart1.ChartAreas[0];
            chartArea.BackColor = Color.FromArgb(40,40,40);
            chartArea.BorderColor = Color.FromArgb(50,50,50);
            chartArea.BorderWidth = 1;
            chartArea.BorderDashStyle = ChartDashStyle.Solid;

            chartArea.AxisX.LabelStyle.ForeColor = Color.LightGray; 
            chartArea.AxisX.LineColor = Color.White;                
            chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(64, 64, 64); 
            chartArea.AxisX.Title = "Weekly New Members";
            chartArea.AxisX.TitleForeColor = Color.White;

            chartArea.AxisY.LabelStyle.ForeColor = Color.LightGray;
            chartArea.AxisY.LineColor = Color.White;
            chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(64, 64, 64);
            chartArea.AxisY.Title = "Value";
            chartArea.AxisY.TitleForeColor = Color.White;

            if (chart1.Legends.Count > 0)
            {
                chart1.Legends[0].BackColor = Color.Transparent;
                chart1.Legends[0].ForeColor = Color.White;
            }

            if (chart1.Titles.Count > 0)
            {
                chart1.Titles[0].ForeColor = Color.White;
            }

            foreach (var s in chart1.Series)
            {
                s.Color = Color.FromArgb(0, 150, 255);

                s.BackGradientStyle = GradientStyle.TopBottom;
                s.Color = Color.Magenta;
                s.BackSecondaryColor = Color.Purple;

                s.LabelForeColor = Color.White;
            }
        }

        private string GetShortDayName(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Monday: return "M";
                case DayOfWeek.Tuesday: return "T";
                case DayOfWeek.Wednesday: return "W";
                case DayOfWeek.Thursday: return "TH";
                case DayOfWeek.Friday: return "F";
                case DayOfWeek.Saturday: return "SA";
                case DayOfWeek.Sunday: return "SU";
                default: return "";
            }
        }
    }
}
