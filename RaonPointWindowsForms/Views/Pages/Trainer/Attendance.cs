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

        private List<string[]> attendanceRecords = new List<string[]>();

        public Attendance()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            attendanceRecords.Add(new string[] { "Ryan Paul Espinola", "01234", "8:00AM", "10:00AM", "Present" });
            attendanceRecords.Add(new string[] { "Ryan Paul Espinola", "01234", "8:00AM", "10:00AM", "Present" });
            attendanceRecords.Add(new string[] { "Ryan Paul Espinola", "01234", "8:00AM", "10:00AM", "Present" });
            attendanceRecords.Add(new string[] { "Ryan Paul Espinola", "01234", "8:00AM", "10:00AM", "Present" });

            initLists();
        }

        private void initLists()
        {
            foreach (var record in attendanceRecords)
            {
                var attendanceListItem = new AttendanceListItem();
                //attendanceListItem.SetFields(record);
                attendanceListItem.BackColor = panelTable.Controls.Count % 2 == 0 ? Color.FromArgb(30, 30, 30) : Color.FromArgb(50, 50, 50);
                attendanceListItem.Location = new Point(0, (panelTable.Controls.Count - 4) * attendanceListItem.Height);
                panelTable.Controls.Add(attendanceListItem);
            }
        }
    }
}
