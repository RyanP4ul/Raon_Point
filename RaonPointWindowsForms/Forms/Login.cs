using Dapper;
using RaonPointWindowsForms.Auth;
using RaonPointWindowsForms.Data;
using RaonPointWindowsForms.Entities.Model;
using RaonPointWindowsForms.Forms;
using RaonPointWindowsForms.Forms.Admin;
using RaonPointWindowsForms.Utils;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaonPointWindowsForms
{
    public partial class Login : Form
    {

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        private bool onAction = false;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Database.Instance.Open();
        }

        private void LoginStatus(bool status)
        {
            if (status)
            { 
                onAction = true;
                btnLogin.Text = "Signing...";
                btnLogin.Enabled = false;
                tbEmail.Enabled = false;
                tbPassword.Enabled = false;
            }
            else
            {
                onAction = false;
                btnLogin.Text = "Sign In";
                btnLogin.Enabled = true;
                tbEmail.Enabled = true;
                tbPassword.Enabled = true;
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (onAction) return;

            LoginStatus(true);

            if (string.IsNullOrEmpty(tbEmail.Texts) || string.IsNullOrEmpty(tbPassword.Texts))
            {
                MessageBox.Show($"Please enter both email and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoginStatus(false);
                return;
            }

            await Database.Instance.ExecuteWithConnection(async (connection) => {
                var user = await connection.QueryFirstOrDefaultAsync<User>("SELECT * FROM users WHERE email = @Email", new {
                    Email = tbEmail.Texts
                });

                if (user == null || !PasswordHasher.VerifyPassword(tbPassword.Texts, user.password))
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoginStatus(false);
                    return;
                }

                Session.CurrentUser = user;

                await Task.Run(() =>
                {
                    Thread.Sleep(1000);
                    Invoke(new Action(() =>
                    {
                        Hide();
                        new Main().Show();
                    }));
                });
            });
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignUp().Show();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
