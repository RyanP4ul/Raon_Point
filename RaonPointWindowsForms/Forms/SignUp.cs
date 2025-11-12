using Dapper;
using RaonPointWindowsForms.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaonPointWindowsForms.Forms
{
    public partial class SignUp : Form
    {

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        public SignUp()
        {
            InitializeComponent();
        }



        private void SignUp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            var first_name = tbFirstName.Text;
            var last_name = tbLastname.Text;
            var email = tbEmail.Text;
            var password = tbPassword.Text;
            var confirm_password = tbConfirmPassword.Text;

            if (password != confirm_password)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            await Database.Instance.ExecuteWithTransactionAsync(async (connection, tranaction) =>
            {
                var existingUser = await connection.QueryFirstOrDefaultAsync("SELECT * FROM users WHERE email = @Email", new { Email = email });

                if (existingUser != null)
                {
                    MessageBox.Show("An account with this email already exists.");
                    return;
                }

                await connection.ExecuteAsync(@"INSERT INTO users (first_name, last_name, email, password) VALUES (@FirstName, @LastName, @Email, @PasswordHash)", new
                {
                    FirstName = first_name,
                    LastName = last_name,
                    Email = email,
                    PasswordHash = Utils.PasswordHasher.HashPassword(password)
                }, tranaction);

                MessageBox.Show("Account created successfully!");

                await Task.Run(() =>
                {
                    Thread.Sleep(1000);
                    Invoke(new Action(() =>
                    {
                        Hide();
                        new Login().Show();
                    }));
                });
            });
        }

        private void lblSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
