namespace RaonPointWindowsForms
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMotivation = new System.Windows.Forms.Label();
            this.lblFit = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roundedBorderedPanel1 = new RaonPointWindowsForms.Views.Components.RoundedBorderedPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPassword = new RaonPointWindowsForms.Views.Components.CustomTextBox();
            this.tbEmail = new RaonPointWindowsForms.Views.Components.CustomTextBox();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.roundedBorderedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(1224, 12);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(28, 27);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 4;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMotivation);
            this.panel1.Controls.Add(this.lblFit);
            this.panel1.Controls.Add(this.lblPower);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 671);
            this.panel1.TabIndex = 6;
            // 
            // lblMotivation
            // 
            this.lblMotivation.AutoSize = true;
            this.lblMotivation.BackColor = System.Drawing.Color.Transparent;
            this.lblMotivation.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivation.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMotivation.Location = new System.Drawing.Point(36, 562);
            this.lblMotivation.Name = "lblMotivation";
            this.lblMotivation.Size = new System.Drawing.Size(336, 26);
            this.lblMotivation.TabIndex = 9;
            this.lblMotivation.Text = "Your journey to greatness begins here.";
            // 
            // lblFit
            // 
            this.lblFit.AutoSize = true;
            this.lblFit.BackColor = System.Drawing.Color.Transparent;
            this.lblFit.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFit.ForeColor = System.Drawing.Color.Gold;
            this.lblFit.Location = new System.Drawing.Point(138, 517);
            this.lblFit.Name = "lblFit";
            this.lblFit.Size = new System.Drawing.Size(117, 45);
            this.lblFit.TabIndex = 8;
            this.lblFit.Text = "POINT";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.BackColor = System.Drawing.Color.Transparent;
            this.lblPower.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPower.ForeColor = System.Drawing.Color.White;
            this.lblPower.Location = new System.Drawing.Point(33, 517);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(111, 45);
            this.lblPower.TabIndex = 7;
            this.lblPower.Text = "RAON";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RaonPointWindowsForms.Properties.Resources.bg_login_r1;
            this.pictureBox1.Location = new System.Drawing.Point(-14, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(860, 684);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // roundedBorderedPanel1
            // 
            this.roundedBorderedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedBorderedPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.roundedBorderedPanel1.BorderRadius = 0;
            this.roundedBorderedPanel1.BorderThickness = 2;
            this.roundedBorderedPanel1.Controls.Add(this.label7);
            this.roundedBorderedPanel1.Controls.Add(this.tbPassword);
            this.roundedBorderedPanel1.Controls.Add(this.tbEmail);
            this.roundedBorderedPanel1.Controls.Add(this.lblSignUp);
            this.roundedBorderedPanel1.Controls.Add(this.label4);
            this.roundedBorderedPanel1.Controls.Add(this.label3);
            this.roundedBorderedPanel1.Controls.Add(this.label2);
            this.roundedBorderedPanel1.Controls.Add(this.label1);
            this.roundedBorderedPanel1.Controls.Add(this.btnLogin);
            this.roundedBorderedPanel1.Location = new System.Drawing.Point(671, -2);
            this.roundedBorderedPanel1.Name = "roundedBorderedPanel1";
            this.roundedBorderedPanel1.Size = new System.Drawing.Size(599, 671);
            this.roundedBorderedPanel1.TabIndex = 3;
            this.roundedBorderedPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.roundedBorderedPanel1_MouseDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(81, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(324, 23);
            this.label7.TabIndex = 42;
            this.label7.Text = "Enter your details to access your account";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.White;
            this.tbPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbPassword.BorderRadius = 6;
            this.tbPassword.BorderSize = 2;
            this.tbPassword.Font = new System.Drawing.Font("Calibri Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.Black;
            this.tbPassword.Location = new System.Drawing.Point(84, 324);
            this.tbPassword.MinimumSize = new System.Drawing.Size(0, 30);
            this.tbPassword.Multiline = false;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Padding = new System.Windows.Forms.Padding(10, 10, 10, 7);
            this.tbPassword.PasswordChar = true;
            this.tbPassword.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbPassword.PlaceholderText = "Enter your password";
            this.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPassword.Size = new System.Drawing.Size(422, 47);
            this.tbPassword.TabIndex = 41;
            this.tbPassword.Texts = "";
            this.tbPassword.UnderlinedStyle = false;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.White;
            this.tbEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbEmail.BorderRadius = 6;
            this.tbEmail.BorderSize = 2;
            this.tbEmail.Font = new System.Drawing.Font("Calibri Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.Black;
            this.tbEmail.Location = new System.Drawing.Point(84, 231);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.tbEmail.MinimumSize = new System.Drawing.Size(0, 30);
            this.tbEmail.Multiline = false;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Padding = new System.Windows.Forms.Padding(10, 10, 10, 7);
            this.tbEmail.PasswordChar = false;
            this.tbEmail.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbEmail.PlaceholderText = "Enter your email";
            this.tbEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbEmail.Size = new System.Drawing.Size(422, 46);
            this.tbEmail.TabIndex = 40;
            this.tbEmail.Texts = "";
            this.tbEmail.UnderlinedStyle = false;
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.Location = new System.Drawing.Point(355, 480);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(67, 18);
            this.lblSignUp.TabIndex = 11;
            this.lblSignUp.Text = "Sign Up";
            this.lblSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Don\'t Have an account?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(81, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(81, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(71, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome back";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(84, 404);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(422, 47);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Sign In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1264, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.roundedBorderedPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.roundedBorderedPanel1.ResumeLayout(false);
            this.roundedBorderedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private Views.Components.RoundedBorderedPanel roundedBorderedPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbClose;
        private Views.Components.CustomTextBox tbPassword;
        private Views.Components.CustomTextBox tbEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Label lblFit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMotivation;
    }
}

