namespace RaonPointWindowsForms.Forms
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.roundedBorderedPanel1 = new RaonPointWindowsForms.Views.Components.RoundedBorderedPanel();
            this.tbConfirmPassword = new RaonPointWindowsForms.Views.Components.CustomTextBox();
            this.tbPassword = new RaonPointWindowsForms.Views.Components.CustomTextBox();
            this.tbLastname = new RaonPointWindowsForms.Views.Components.CustomTextBox();
            this.tbFirstName = new RaonPointWindowsForms.Views.Components.CustomTextBox();
            this.tbEmail = new RaonPointWindowsForms.Views.Components.CustomTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
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
            this.pbClose.TabIndex = 5;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // roundedBorderedPanel1
            // 
            this.roundedBorderedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedBorderedPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.roundedBorderedPanel1.BorderRadius = 0;
            this.roundedBorderedPanel1.BorderThickness = 2;
            this.roundedBorderedPanel1.Controls.Add(this.tbConfirmPassword);
            this.roundedBorderedPanel1.Controls.Add(this.tbPassword);
            this.roundedBorderedPanel1.Controls.Add(this.tbLastname);
            this.roundedBorderedPanel1.Controls.Add(this.tbFirstName);
            this.roundedBorderedPanel1.Controls.Add(this.tbEmail);
            this.roundedBorderedPanel1.Controls.Add(this.label7);
            this.roundedBorderedPanel1.Controls.Add(this.label6);
            this.roundedBorderedPanel1.Controls.Add(this.label5);
            this.roundedBorderedPanel1.Controls.Add(this.lblSignIn);
            this.roundedBorderedPanel1.Controls.Add(this.label4);
            this.roundedBorderedPanel1.Controls.Add(this.label3);
            this.roundedBorderedPanel1.Controls.Add(this.label2);
            this.roundedBorderedPanel1.Controls.Add(this.label1);
            this.roundedBorderedPanel1.Controls.Add(this.btnSignUp);
            this.roundedBorderedPanel1.Location = new System.Drawing.Point(380, 63);
            this.roundedBorderedPanel1.Name = "roundedBorderedPanel1";
            this.roundedBorderedPanel1.Size = new System.Drawing.Size(403, 495);
            this.roundedBorderedPanel1.TabIndex = 6;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.BackColor = System.Drawing.Color.White;
            this.tbConfirmPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbConfirmPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbConfirmPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbConfirmPassword.BorderRadius = 6;
            this.tbConfirmPassword.BorderSize = 2;
            this.tbConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.tbConfirmPassword.Location = new System.Drawing.Point(44, 344);
            this.tbConfirmPassword.MinimumSize = new System.Drawing.Size(0, 30);
            this.tbConfirmPassword.Multiline = false;
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Padding = new System.Windows.Forms.Padding(10, 10, 10, 7);
            this.tbConfirmPassword.PasswordChar = false;
            this.tbConfirmPassword.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbConfirmPassword.PlaceholderText = "Enter Your Password";
            this.tbConfirmPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbConfirmPassword.Size = new System.Drawing.Size(300, 33);
            this.tbConfirmPassword.TabIndex = 45;
            this.tbConfirmPassword.Texts = "";
            this.tbConfirmPassword.UnderlinedStyle = false;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.White;
            this.tbPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbPassword.BorderRadius = 6;
            this.tbPassword.BorderSize = 2;
            this.tbPassword.ForeColor = System.Drawing.Color.Black;
            this.tbPassword.Location = new System.Drawing.Point(44, 279);
            this.tbPassword.MinimumSize = new System.Drawing.Size(0, 30);
            this.tbPassword.Multiline = false;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Padding = new System.Windows.Forms.Padding(10, 10, 10, 7);
            this.tbPassword.PasswordChar = false;
            this.tbPassword.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbPassword.PlaceholderText = "Enter Your Password";
            this.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPassword.Size = new System.Drawing.Size(300, 33);
            this.tbPassword.TabIndex = 44;
            this.tbPassword.Texts = "";
            this.tbPassword.UnderlinedStyle = false;
            // 
            // tbLastname
            // 
            this.tbLastname.BackColor = System.Drawing.Color.White;
            this.tbLastname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbLastname.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbLastname.BorderRadius = 6;
            this.tbLastname.BorderSize = 2;
            this.tbLastname.ForeColor = System.Drawing.Color.Black;
            this.tbLastname.Location = new System.Drawing.Point(44, 147);
            this.tbLastname.MinimumSize = new System.Drawing.Size(0, 30);
            this.tbLastname.Multiline = false;
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.Padding = new System.Windows.Forms.Padding(10, 10, 10, 7);
            this.tbLastname.PasswordChar = false;
            this.tbLastname.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbLastname.PlaceholderText = "Enter Last Name";
            this.tbLastname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLastname.Size = new System.Drawing.Size(300, 33);
            this.tbLastname.TabIndex = 43;
            this.tbLastname.Texts = "";
            this.tbLastname.UnderlinedStyle = false;
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.White;
            this.tbFirstName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbFirstName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbFirstName.BorderRadius = 6;
            this.tbFirstName.BorderSize = 2;
            this.tbFirstName.ForeColor = System.Drawing.Color.Black;
            this.tbFirstName.Location = new System.Drawing.Point(44, 81);
            this.tbFirstName.MinimumSize = new System.Drawing.Size(0, 30);
            this.tbFirstName.Multiline = false;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Padding = new System.Windows.Forms.Padding(10, 10, 10, 7);
            this.tbFirstName.PasswordChar = false;
            this.tbFirstName.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbFirstName.PlaceholderText = "Enter First Name";
            this.tbFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbFirstName.Size = new System.Drawing.Size(300, 33);
            this.tbFirstName.TabIndex = 42;
            this.tbFirstName.Texts = "";
            this.tbFirstName.UnderlinedStyle = false;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.White;
            this.tbEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbEmail.BorderRadius = 6;
            this.tbEmail.BorderSize = 2;
            this.tbEmail.ForeColor = System.Drawing.Color.Black;
            this.tbEmail.Location = new System.Drawing.Point(44, 211);
            this.tbEmail.MinimumSize = new System.Drawing.Size(0, 30);
            this.tbEmail.Multiline = false;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Padding = new System.Windows.Forms.Padding(10, 10, 10, 7);
            this.tbEmail.PasswordChar = false;
            this.tbEmail.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbEmail.PlaceholderText = "Enter Your Email";
            this.tbEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbEmail.Size = new System.Drawing.Size(300, 33);
            this.tbEmail.TabIndex = 41;
            this.tbEmail.Texts = "";
            this.tbEmail.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(41, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Confirm Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(41, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(41, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email";
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.Location = new System.Drawing.Point(239, 451);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(59, 18);
            this.lblSignIn.TabIndex = 11;
            this.lblSignIn.Text = "Sign In";
            this.lblSignIn.Click += new System.EventHandler(this.lblSignIn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Already have an account?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(41, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(41, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "First name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sign Up";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(44, 398);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(300, 40);
            this.btnSignUp.TabIndex = 0;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImage = global::RaonPointWindowsForms.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1264, 661);
            this.Controls.Add(this.roundedBorderedPanel1);
            this.Controls.Add(this.pbClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SignUp_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.roundedBorderedPanel1.ResumeLayout(false);
            this.roundedBorderedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbClose;
        private Views.Components.RoundedBorderedPanel roundedBorderedPanel1;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Views.Components.CustomTextBox tbLastname;
        private Views.Components.CustomTextBox tbFirstName;
        private Views.Components.CustomTextBox tbEmail;
        private Views.Components.CustomTextBox tbConfirmPassword;
        private Views.Components.CustomTextBox tbPassword;
    }
}