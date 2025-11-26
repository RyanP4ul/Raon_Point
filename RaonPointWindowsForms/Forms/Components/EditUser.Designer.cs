namespace RaonPointWindowsForms.Forms.Components
{
    partial class EditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser));
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPlan = new RaonPointWindowsForms.Views.Components.CustomComboBox();
            this.tbLastName = new RaonPointWindowsForms.Views.Components.CustomTextBox();
            this.tbFirstName = new RaonPointWindowsForms.Views.Components.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNo = new RaonPointWindowsForms.Views.Components.RoundedBorderedButton();
            this.btnSave = new RaonPointWindowsForms.Views.Components.RoundedBorderedButton();
            this.btnRenewal = new RaonPointWindowsForms.Views.Components.RoundedBorderedButton();
            this.tbExpirationDate = new RaonPointWindowsForms.Views.Components.CustomTextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pbClose
            // 
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(565, 15);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(28, 27);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 5;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Edit User";
            // 
            // cbPlan
            // 
            this.cbPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbPlan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbPlan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbPlan.BorderSize = 2;
            this.cbPlan.CornerRadius = 6;
            this.cbPlan.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbPlan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.cbPlan.ForeColor = System.Drawing.Color.White;
            this.cbPlan.FormattingEnabled = true;
            this.cbPlan.IconColor = System.Drawing.Color.White;
            this.cbPlan.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cbPlan.ListTextColor = System.Drawing.Color.White;
            this.cbPlan.Location = new System.Drawing.Point(24, 155);
            this.cbPlan.MinimumSize = new System.Drawing.Size(100, 0);
            this.cbPlan.Name = "cbPlan";
            this.cbPlan.Size = new System.Drawing.Size(241, 32);
            this.cbPlan.TabIndex = 40;
            this.cbPlan.TextColor = System.Drawing.Color.White;
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbLastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tbLastName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbLastName.BorderRadius = 6;
            this.tbLastName.BorderSize = 2;
            this.tbLastName.ForeColor = System.Drawing.Color.White;
            this.tbLastName.Location = new System.Drawing.Point(301, 82);
            this.tbLastName.MinimumSize = new System.Drawing.Size(0, 30);
            this.tbLastName.Multiline = false;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Padding = new System.Windows.Forms.Padding(10, 10, 10, 7);
            this.tbLastName.PasswordChar = false;
            this.tbLastName.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbLastName.PlaceholderText = "";
            this.tbLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLastName.Size = new System.Drawing.Size(241, 33);
            this.tbLastName.TabIndex = 44;
            this.tbLastName.Texts = "";
            this.tbLastName.UnderlinedStyle = false;
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbFirstName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tbFirstName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbFirstName.BorderRadius = 6;
            this.tbFirstName.BorderSize = 2;
            this.tbFirstName.ForeColor = System.Drawing.Color.White;
            this.tbFirstName.Location = new System.Drawing.Point(24, 82);
            this.tbFirstName.MinimumSize = new System.Drawing.Size(0, 30);
            this.tbFirstName.Multiline = false;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Padding = new System.Windows.Forms.Padding(10, 10, 10, 7);
            this.tbFirstName.PasswordChar = false;
            this.tbFirstName.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbFirstName.PlaceholderText = "";
            this.tbFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbFirstName.Size = new System.Drawing.Size(241, 33);
            this.tbFirstName.TabIndex = 43;
            this.tbFirstName.Texts = "";
            this.tbFirstName.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(298, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(21, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(21, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Plan";
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnNo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNo.BorderRadius = 5;
            this.btnNo.BorderThickness = 2;
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.DarkGray;
            this.btnNo.Location = new System.Drawing.Point(382, 227);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(155, 46);
            this.btnNo.TabIndex = 47;
            this.btnNo.Text = "Cancel";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.IndianRed;
            this.btnSave.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnSave.BorderRadius = 5;
            this.btnSave.BorderThickness = 2;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(60, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(155, 46);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRenewal
            // 
            this.btnRenewal.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRenewal.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnRenewal.BorderRadius = 5;
            this.btnRenewal.BorderThickness = 2;
            this.btnRenewal.FlatAppearance.BorderSize = 0;
            this.btnRenewal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenewal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenewal.ForeColor = System.Drawing.Color.White;
            this.btnRenewal.Location = new System.Drawing.Point(221, 227);
            this.btnRenewal.Name = "btnRenewal";
            this.btnRenewal.Size = new System.Drawing.Size(155, 46);
            this.btnRenewal.TabIndex = 48;
            this.btnRenewal.Text = "Renewal";
            this.btnRenewal.UseVisualStyleBackColor = false;
            this.btnRenewal.Click += new System.EventHandler(this.btnRenewal_Click);
            // 
            // tbExpirationDate
            // 
            this.tbExpirationDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbExpirationDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tbExpirationDate.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbExpirationDate.BorderRadius = 6;
            this.tbExpirationDate.BorderSize = 2;
            this.tbExpirationDate.ForeColor = System.Drawing.Color.White;
            this.tbExpirationDate.Location = new System.Drawing.Point(301, 154);
            this.tbExpirationDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.tbExpirationDate.Multiline = false;
            this.tbExpirationDate.Name = "tbExpirationDate";
            this.tbExpirationDate.Padding = new System.Windows.Forms.Padding(10, 10, 10, 7);
            this.tbExpirationDate.PasswordChar = false;
            this.tbExpirationDate.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbExpirationDate.PlaceholderText = "";
            this.tbExpirationDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbExpirationDate.Size = new System.Drawing.Size(241, 33);
            this.tbExpirationDate.TabIndex = 50;
            this.tbExpirationDate.Texts = "";
            this.tbExpirationDate.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(298, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Expiration Date";
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(605, 305);
            this.Controls.Add(this.tbExpirationDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRenewal);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbPlan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditUser";
            this.Text = "EditUser";
            this.Load += new System.EventHandler(this.EditUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label label1;
        private Views.Components.CustomComboBox cbPlan;
        private Views.Components.CustomTextBox tbLastName;
        private Views.Components.CustomTextBox tbFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Views.Components.RoundedBorderedButton btnNo;
        private Views.Components.RoundedBorderedButton btnSave;
        private Views.Components.RoundedBorderedButton btnRenewal;
        private Views.Components.CustomTextBox tbExpirationDate;
        private System.Windows.Forms.Label label5;
    }
}