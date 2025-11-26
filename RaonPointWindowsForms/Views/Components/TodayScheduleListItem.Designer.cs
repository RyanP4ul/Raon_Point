namespace RaonPointWindowsForms.Views.Components
{
    partial class TodayScheduleListItem
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStudio = new System.Windows.Forms.Label();
            this.roundedBorderedPanel1 = new RaonPointWindowsForms.Views.Components.RoundedBorderedPanel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.roundedBorderedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(123, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(46, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // lblStudio
            // 
            this.lblStudio.AutoSize = true;
            this.lblStudio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudio.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStudio.Location = new System.Drawing.Point(124, 45);
            this.lblStudio.Name = "lblStudio";
            this.lblStudio.Size = new System.Drawing.Size(89, 15);
            this.lblStudio.TabIndex = 2;
            this.lblStudio.Text = "Studio A - Ryan";
            // 
            // roundedBorderedPanel1
            // 
            this.roundedBorderedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.roundedBorderedPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.roundedBorderedPanel1.BorderRadius = 20;
            this.roundedBorderedPanel1.BorderThickness = 2;
            this.roundedBorderedPanel1.Controls.Add(this.lblTime);
            this.roundedBorderedPanel1.Controls.Add(this.lblStatus);
            this.roundedBorderedPanel1.Location = new System.Drawing.Point(12, 9);
            this.roundedBorderedPanel1.Name = "roundedBorderedPanel1";
            this.roundedBorderedPanel1.Size = new System.Drawing.Size(94, 58);
            this.roundedBorderedPanel1.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(0, 29);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(94, 25);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "5 PM";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblStatus.Location = new System.Drawing.Point(3, 4);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(88, 23);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "NOW";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TodayScheduleListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.lblStudio);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.roundedBorderedPanel1);
            this.Name = "TodayScheduleListItem";
            this.Size = new System.Drawing.Size(544, 76);
            this.Load += new System.EventHandler(this.TodayScheduleListItem_Load);
            this.roundedBorderedPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedBorderedPanel roundedBorderedPanel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStudio;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblStatus;
    }
}
