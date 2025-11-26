using RaonPointWindowsForms.Auth;
using RaonPointWindowsForms.Entities.View;
using RaonPointWindowsForms.Forms.Components;
using RaonPointWindowsForms.Views.Components;
using RaonPointWindowsForms.Views.Pages.Trainer;
using RaonPointWindowsForms.Views.Pages.User;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AdminDashboard = RaonPointWindowsForms.Views.Pages.Trainer.Dashboard;
using UserDashboard = RaonPointWindowsForms.Views.Pages.User.Dashboard;

namespace RaonPointWindowsForms.Forms.Admin
{
    public partial class Main : Form
    {

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        public List<MenuItemView> menuItems = new List<MenuItemView>();
        public static MenuListItem CurrentMenuItem { get; set; } = null;
        public static UserControl CurrentControl { get; private set; } = null;

        public Main()
        {
            InitializeComponent();

            if (Session.CurrentUser == null)
            {
                MessageBox.Show("No user is currently logged in. Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            if (Session.CurrentUser.role != "Trainer")
            {
                menuItems.Add(new MenuItemView() { Title = "  Dashboard   ", Image = Properties.Resources.dashboard, Action = () => LoadUserControl(new UserDashboard()) });
                menuItems.Add(new MenuItemView() { Title = "Schedules", Image = Properties.Resources.schedule, Action = () => LoadUserControl(new Schedules()) });
                //menuItems.Add(new MenuItemView() { Title = "Workout Plan", Image = Properties.Resources.dashboard, Action = () => LoadUserControl(new WorkoutPlan()) });
                //menuItems.Add(new MenuItemView() { Title = "Membership Plan", Image = Properties.Resources.dashboard, Action = () => LoadUserControl(new MembershipPlan()) });
            }
            else
            {
                menuItems.Add(new MenuItemView() { Title = "  Dashboard   ", Image = Properties.Resources.dashboard, Action = () => LoadUserControl(new AdminDashboard()) });
                menuItems.Add(new MenuItemView() { Title = "  Members     ", Image = Properties.Resources.lists, Action = () => LoadUserControl(new Members()) });
                menuItems.Add(new MenuItemView() { Title = "  Class Schedule", Image = Properties.Resources.registration, Action = () => LoadUserControl(new ClassSchedule()) });
                menuItems.Add(new MenuItemView() { Title = " Attendance  ", Image = Properties.Resources.attendance, Action = () => LoadUserControl(new Attendance()) });
                menuItems.Add(new MenuItemView() { Title = "History     ", Image = Properties.Resources.history, Action = () => LoadUserControl(new History()) });
            }
        }

        public void LoadUserControl(UserControl userControl)
        {
            lblPageName.Text = userControl.GetType().Name;
            userControl.Dock = DockStyle.Fill;
            userControl.Width = contentPanel.Width;
            userControl.Height = contentPanel.Height;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(userControl);
            userControl.BringToFront();
            CurrentControl = userControl;
        }

        public void ShowModal(Form modal)
        {
            var overlay = Utils.Utils.OverlayForm(this);

            overlay.Show();
            modal.ShowInTaskbar = false;
            modal.StartPosition = FormStartPosition.CenterParent;
            modal.ShowDialog(this);

            overlay.Close();
        }

        private void InitMenuListItems()
        {
            foreach (var item in menuItems)
            {
                var menuListItem = new MenuListItem();
                menuListItem.SetTitle(item.Title);
                menuListItem.SetIcon(item.Image);
                menuListItem.SetOnClickAction(item.Action);
                menuListItem.Width = panelMenu.Width;
                menuListItem.Location = new Point(0, panelMenu.Controls.Count * menuListItem.Height);
                panelMenu.Controls.Add(menuListItem);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            InitMenuListItems();
            CurrentMenuItem = panelMenu.Controls[1] as MenuListItem;
            CurrentMenuItem.toggleActiveState(true);

            if (Session.CurrentUser.role != "Trainer")
            {
                LoadUserControl(new UserDashboard());
            }
            else
            {
                LoadUserControl(new AdminDashboard());
            }


            btnLogout.SetIcon(Properties.Resources.logout);
            btnLogout.SetTitle("Logout");
            btnLogout.SetOnClickAction(() =>
            {
                var loginForm = new Login();
                loginForm.Show();
                this.Close();
            });
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
