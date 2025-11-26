namespace RaonPointWindowsForms.Forms.Components
{
    partial class CreateSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateSchedule));
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.lblMaxCapacity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNo = new RaonPointWindowsForms.Views.Components.RoundedBorderedButton();
            this.btnYes = new RaonPointWindowsForms.Views.Components.RoundedBorderedButton();
            this.tbEndTime = new RaonPointWindowsForms.Views.Components.CustomTextBox();
            this.tbStartTime = new RaonPointWindowsForms.Views.Components.CustomTextBox();
            this.cbTrainer = new RaonPointWindowsForms.Views.Components.CustomComboBox();
            this.tbMaxCapacity = new RaonPointWindowsForms.Views.Components.CustomTextBox();
            this.tbClassName = new RaonPointWindowsForms.Views.Components.CustomTextBox();
            this.tbCategory = new RaonPointWindowsForms.Views.Components.CustomTextBox();
            this.tbLocation = new RaonPointWindowsForms.Views.Components.CustomTextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(196, 33);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Create Schedule";
            // 
            // pbClose
            // 
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(528, 9);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(28, 27);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 6;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // lblMaxCapacity
            // 
            this.lblMaxCapacity.AutoSize = true;
            this.lblMaxCapacity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMaxCapacity.Location = new System.Drawing.Point(292, 65);
            this.lblMaxCapacity.Name = "lblMaxCapacity";
            this.lblMaxCapacity.Size = new System.Drawing.Size(71, 13);
            this.lblMaxCapacity.TabIndex = 46;
            this.lblMaxCapacity.Text = "Max Capacity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(15, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(15, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(292, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Trainer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(292, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "End Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(15, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Start Time";
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
            this.btnNo.Location = new System.Drawing.Point(284, 359);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(155, 46);
            this.btnNo.TabIndex = 58;
            this.btnNo.Text = "No Cancel";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnYes.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnYes.BorderRadius = 5;
            this.btnYes.BorderThickness = 2;
            this.btnYes.FlatAppearance.BorderSize = 0;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.Location = new System.Drawing.Point(104, 359);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(155, 46);
            this.btnYes.TabIndex = 57;
            this.btnYes.Text = "Create";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // tbEndTime
            // 
            this.tbEndTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbEndTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tbEndTime.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbEndTime.BorderRadius = 6;
            this.tbEndTime.BorderSize = 2;
            this.tbEndTime.ForeColor = System.Drawing.Color.White;
            this.tbEndTime.Location = new System.Drawing.Point(295, 232);
            this.tbEndTime.MinimumSize = new System.Drawing.Size(0, 30);
            this.tbEndTime.Multiline = false;
            this.tbEndTime.Name = "tbEndTime";
            this.tbEndTime.Padding = new System.Windows.Forms.Padding(10, 10, 10, 7);
            this.tbEndTime.PasswordChar = false;
            this.tbEndTime.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbEndTime.PlaceholderText = "";
            this.tbEndTime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbEndTime.Size = new System.Drawing.Size(241, 33);
            this.tbEndTime.TabIndex = 56;
            this.tbEndTime.Texts = "09:00 AM";
            this.tbEndTime.UnderlinedStyle = false;
            // 
            // tbStartTime
            // 
            this.tbStartTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbStartTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tbStartTime.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbStartTime.BorderRadius = 6;
            this.tbStartTime.BorderSize = 2;
            this.tbStartTime.ForeColor = System.Drawing.Color.White;
            this.tbStartTime.Location = new System.Drawing.Point(18, 232);
            this.tbStartTime.MinimumSize = new System.Drawing.Size(0, 30);
            this.tbStartTime.Multiline = false;
            this.tbStartTime.Name = "tbStartTime";
            this.tbStartTime.Padding = new System.Windows.Forms.Padding(10, 10, 10, 7);
            this.tbStartTime.PasswordChar = false;
            this.tbStartTime.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbStartTime.PlaceholderText = "";
            this.tbStartTime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbStartTime.Size = new System.Drawing.Size(241, 33);
            this.tbStartTime.TabIndex = 55;
            this.tbStartTime.Texts = "06:00 AM";
            this.tbStartTime.UnderlinedStyle = false;
            // 
            // cbTrainer
            // 
            this.cbTrainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbTrainer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbTrainer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbTrainer.BorderSize = 2;
            this.cbTrainer.CornerRadius = 6;
            this.cbTrainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbTrainer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTrainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.cbTrainer.ForeColor = System.Drawing.Color.White;
            this.cbTrainer.FormattingEnabled = true;
            this.cbTrainer.IconColor = System.Drawing.Color.White;
            this.cbTrainer.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cbTrainer.ListTextColor = System.Drawing.Color.White;
            this.cbTrainer.Location = new System.Drawing.Point(295, 158);
            this.cbTrainer.MinimumSize = new System.Drawing.Size(100, 0);
            this.cbTrainer.Name = "cbTrainer";
            this.cbTrainer.Size = new System.Drawing.Size(241, 32);
            this.cbTrainer.TabIndex = 51;
            this.cbTrainer.TextColor = System.Drawing.Color.White;
            // 
            // tbMaxCapacity
            // 
            this.tbMaxCapacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbMaxCapacity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tbMaxCapacity.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbMaxCapacity.BorderRadius = 6;
            this.tbMaxCapacity.BorderSize = 2;
            this.tbMaxCapacity.ForeColor = System.Drawing.Color.White;
            this.tbMaxCapacity.Location = new System.Drawing.Point(295, 85);
            this.tbMaxCapacity.MinimumSize = new System.Drawing.Size(0, 30);
            this.tbMaxCapacity.Multiline = false;
            this.tbMaxCapacity.Name = "tbMaxCapacity";
            this.tbMaxCapacity.Padding = new System.Windows.Forms.Padding(10, 10, 10, 7);
            this.tbMaxCapacity.PasswordChar = false;
            this.tbMaxCapacity.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbMaxCapacity.PlaceholderText = "";
            this.tbMaxCapacity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMaxCapacity.Size = new System.Drawing.Size(241, 33);
            this.tbMaxCapacity.TabIndex = 48;
            this.tbMaxCapacity.Texts = "0";
            this.tbMaxCapacity.UnderlinedStyle = false;
            // 
            // tbClassName
            // 
            this.tbClassName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbClassName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tbClassName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbClassName.BorderRadius = 6;
            this.tbClassName.BorderSize = 2;
            this.tbClassName.ForeColor = System.Drawing.Color.White;
            this.tbClassName.Location = new System.Drawing.Point(18, 85);
            this.tbClassName.MinimumSize = new System.Drawing.Size(0, 30);
            this.tbClassName.Multiline = false;
            this.tbClassName.Name = "tbClassName";
            this.tbClassName.Padding = new System.Windows.Forms.Padding(10, 10, 10, 7);
            this.tbClassName.PasswordChar = false;
            this.tbClassName.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbClassName.PlaceholderText = "";
            this.tbClassName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbClassName.Size = new System.Drawing.Size(241, 33);
            this.tbClassName.TabIndex = 47;
            this.tbClassName.Texts = "";
            this.tbClassName.UnderlinedStyle = false;
            // 
            // tbCategory
            // 
            this.tbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tbCategory.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbCategory.BorderRadius = 6;
            this.tbCategory.BorderSize = 2;
            this.tbCategory.ForeColor = System.Drawing.Color.White;
            this.tbCategory.Location = new System.Drawing.Point(18, 158);
            this.tbCategory.MinimumSize = new System.Drawing.Size(0, 30);
            this.tbCategory.Multiline = false;
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Padding = new System.Windows.Forms.Padding(10, 10, 10, 7);
            this.tbCategory.PasswordChar = false;
            this.tbCategory.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbCategory.PlaceholderText = "";
            this.tbCategory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCategory.Size = new System.Drawing.Size(241, 33);
            this.tbCategory.TabIndex = 59;
            this.tbCategory.Texts = "";
            this.tbCategory.UnderlinedStyle = false;
            // 
            // tbLocation
            // 
            this.tbLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbLocation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tbLocation.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbLocation.BorderRadius = 6;
            this.tbLocation.BorderSize = 2;
            this.tbLocation.ForeColor = System.Drawing.Color.White;
            this.tbLocation.Location = new System.Drawing.Point(18, 306);
            this.tbLocation.MinimumSize = new System.Drawing.Size(0, 30);
            this.tbLocation.Multiline = false;
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Padding = new System.Windows.Forms.Padding(10, 10, 10, 7);
            this.tbLocation.PasswordChar = false;
            this.tbLocation.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbLocation.PlaceholderText = "";
            this.tbLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLocation.Size = new System.Drawing.Size(518, 33);
            this.tbLocation.TabIndex = 61;
            this.tbLocation.Texts = "Main Gym";
            this.tbLocation.UnderlinedStyle = false;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLocation.Location = new System.Drawing.Point(15, 286);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 60;
            this.lblLocation.Text = "Location";
            // 
            // CreateSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(568, 438);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.tbCategory);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.tbEndTime);
            this.Controls.Add(this.tbStartTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTrainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMaxCapacity);
            this.Controls.Add(this.tbClassName);
            this.Controls.Add(this.lblMaxCapacity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateSchedule";
            this.Text = "CreateSchedule";
            this.Load += new System.EventHandler(this.CreateSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label lblTitle;
        private Views.Components.CustomTextBox tbMaxCapacity;
        private Views.Components.CustomTextBox tbClassName;
        private System.Windows.Forms.Label lblMaxCapacity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Views.Components.CustomComboBox cbTrainer;
        private Views.Components.CustomTextBox tbEndTime;
        private Views.Components.CustomTextBox tbStartTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Views.Components.RoundedBorderedButton btnNo;
        private Views.Components.RoundedBorderedButton btnYes;
        private Views.Components.CustomTextBox tbCategory;
        private Views.Components.CustomTextBox tbLocation;
        private System.Windows.Forms.Label lblLocation;
    }
}