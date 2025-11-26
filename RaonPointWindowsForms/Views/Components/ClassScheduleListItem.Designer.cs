namespace RaonPointWindowsForms.Views.Components
{
    partial class ClassScheduleListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pgBooking = new System.Windows.Forms.ProgressBar();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTrainer = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBookings = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnViewBooking = new RaonPointWindowsForms.Views.Components.RoundedBorderedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pgBooking
            // 
            this.pgBooking.Location = new System.Drawing.Point(17, 182);
            this.pgBooking.Name = "pgBooking";
            this.pgBooking.Size = new System.Drawing.Size(264, 10);
            this.pgBooking.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(11, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(172, 33);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Morning Rush";
            // 
            // lblTrainer
            // 
            this.lblTrainer.AutoSize = true;
            this.lblTrainer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainer.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTrainer.Location = new System.Drawing.Point(39, 86);
            this.lblTrainer.Name = "lblTrainer";
            this.lblTrainer.Size = new System.Drawing.Size(73, 19);
            this.lblTrainer.TabIndex = 3;
            this.lblTrainer.Text = "Ryan Paul";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTime.Location = new System.Drawing.Point(39, 113);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(146, 19);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "06:00 AM - 09:00 AM";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RaonPointWindowsForms.Properties.Resources.timer;
            this.pictureBox2.Location = new System.Drawing.Point(18, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pbDelete
            // 
            this.pbDelete.Image = global::RaonPointWindowsForms.Properties.Resources.trash;
            this.pbDelete.Location = new System.Drawing.Point(259, 10);
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.Size = new System.Drawing.Size(28, 29);
            this.pbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDelete.TabIndex = 4;
            this.pbDelete.TabStop = false;
            this.pbDelete.Click += new System.EventHandler(this.pbDelete_Click);
            this.pbDelete.MouseEnter += new System.EventHandler(this.pbDelete_MouseEnter);
            this.pbDelete.MouseLeave += new System.EventHandler(this.pbDelete_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RaonPointWindowsForms.Properties.Resources.user;
            this.pictureBox3.Location = new System.Drawing.Point(18, 88);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(14, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bookings";
            // 
            // lblBookings
            // 
            this.lblBookings.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBookings.Location = new System.Drawing.Point(180, 163);
            this.lblBookings.Name = "lblBookings";
            this.lblBookings.Size = new System.Drawing.Size(101, 13);
            this.lblBookings.TabIndex = 10;
            this.lblBookings.Text = "0";
            this.lblBookings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.LightGray;
            this.lblCategory.Location = new System.Drawing.Point(16, 46);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(91, 29);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Cardio";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnViewBooking
            // 
            this.btnViewBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnViewBooking.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnViewBooking.BorderRadius = 5;
            this.btnViewBooking.BorderThickness = 2;
            this.btnViewBooking.FlatAppearance.BorderSize = 0;
            this.btnViewBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBooking.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBooking.ForeColor = System.Drawing.Color.White;
            this.btnViewBooking.Location = new System.Drawing.Point(18, 200);
            this.btnViewBooking.Name = "btnViewBooking";
            this.btnViewBooking.Size = new System.Drawing.Size(263, 34);
            this.btnViewBooking.TabIndex = 5;
            this.btnViewBooking.Text = "View Booking Details";
            this.btnViewBooking.UseVisualStyleBackColor = false;
            this.btnViewBooking.Click += new System.EventHandler(this.btnViewBooking_Click);
            // 
            // ClassScheduleListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblBookings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnViewBooking);
            this.Controls.Add(this.pbDelete);
            this.Controls.Add(this.lblTrainer);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pgBooking);
            this.Name = "ClassScheduleListItem";
            this.Size = new System.Drawing.Size(298, 256);
            this.Load += new System.EventHandler(this.ClassScheduleListItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgBooking;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTrainer;
        private System.Windows.Forms.PictureBox pbDelete;
        private RoundedBorderedButton btnViewBooking;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBookings;
        private System.Windows.Forms.Label lblCategory;
    }
}
