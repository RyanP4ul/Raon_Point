namespace RaonPointWindowsForms.Views.Pages.User
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblExpiration = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblMem = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDaysLeft = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelTodaySchedules = new RaonPointWindowsForms.Views.Components.RoundedBorderedPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedBorderedPanel1 = new RaonPointWindowsForms.Views.Components.RoundedBorderedPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMotivationShit = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.roundedBorderedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.lblPlan);
            this.panel1.Controls.Add(this.lblExpiration);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblFullName);
            this.panel1.Controls.Add(this.lblMem);
            this.panel1.Location = new System.Drawing.Point(24, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 242);
            this.panel1.TabIndex = 8;
            // 
            // lblPlan
            // 
            this.lblPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlan.ForeColor = System.Drawing.Color.White;
            this.lblPlan.Location = new System.Drawing.Point(12, 26);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(377, 39);
            this.lblPlan.TabIndex = 6;
            this.lblPlan.Text = "Starter";
            this.lblPlan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExpiration
            // 
            this.lblExpiration.AutoSize = true;
            this.lblExpiration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiration.ForeColor = System.Drawing.Color.White;
            this.lblExpiration.Location = new System.Drawing.Point(258, 198);
            this.lblExpiration.Name = "lblExpiration";
            this.lblExpiration.Size = new System.Drawing.Size(116, 20);
            this.lblExpiration.TabIndex = 5;
            this.lblExpiration.Text = "Dec 21, 2025";
            this.lblExpiration.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(31, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Expires";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(316, 169);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(58, 20);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Active";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(31, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Status";
            // 
            // lblFullName
            // 
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.White;
            this.lblFullName.Location = new System.Drawing.Point(19, 120);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(370, 20);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Ryan Paul Espinola";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMem
            // 
            this.lblMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMem.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblMem.Location = new System.Drawing.Point(19, 94);
            this.lblMem.Name = "lblMem";
            this.lblMem.Size = new System.Drawing.Size(370, 25);
            this.lblMem.TabIndex = 0;
            this.lblMem.Text = "M-1001";
            this.lblMem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.lblCheckIn);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(451, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 119);
            this.panel2.TabIndex = 9;
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.ForeColor = System.Drawing.Color.White;
            this.lblCheckIn.Location = new System.Drawing.Point(94, 49);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(30, 31);
            this.lblCheckIn.TabIndex = 4;
            this.lblCheckIn.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(96, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Check in";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RaonPointWindowsForms.Properties.Resources.favorite_place;
            this.pictureBox2.Location = new System.Drawing.Point(16, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel3.Controls.Add(this.lblDaysLeft);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(746, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(282, 119);
            this.panel3.TabIndex = 10;
            // 
            // lblDaysLeft
            // 
            this.lblDaysLeft.AutoSize = true;
            this.lblDaysLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysLeft.ForeColor = System.Drawing.Color.White;
            this.lblDaysLeft.Location = new System.Drawing.Point(104, 49);
            this.lblDaysLeft.Name = "lblDaysLeft";
            this.lblDaysLeft.Size = new System.Drawing.Size(46, 31);
            this.lblDaysLeft.TabIndex = 2;
            this.lblDaysLeft.Text = "45";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(106, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Days Left";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RaonPointWindowsForms.Properties.Resources.weight;
            this.pictureBox1.Location = new System.Drawing.Point(24, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel4.Controls.Add(this.panelTodaySchedules);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(451, 337);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(577, 242);
            this.panel4.TabIndex = 9;
            // 
            // panelTodaySchedules
            // 
            this.panelTodaySchedules.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelTodaySchedules.BorderRadius = 5;
            this.panelTodaySchedules.BorderThickness = 2;
            this.panelTodaySchedules.Location = new System.Drawing.Point(16, 46);
            this.panelTodaySchedules.Name = "panelTodaySchedules";
            this.panelTodaySchedules.Size = new System.Drawing.Size(547, 182);
            this.panelTodaySchedules.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Today\'s Schedule";
            // 
            // roundedBorderedPanel1
            // 
            this.roundedBorderedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(119)))), ((int)(((byte)(235)))));
            this.roundedBorderedPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.roundedBorderedPanel1.BorderRadius = 0;
            this.roundedBorderedPanel1.BorderThickness = 2;
            this.roundedBorderedPanel1.Controls.Add(this.pictureBox4);
            this.roundedBorderedPanel1.Controls.Add(this.pictureBox3);
            this.roundedBorderedPanel1.Controls.Add(this.label2);
            this.roundedBorderedPanel1.Controls.Add(this.lblMotivationShit);
            this.roundedBorderedPanel1.Location = new System.Drawing.Point(24, 16);
            this.roundedBorderedPanel1.Name = "roundedBorderedPanel1";
            this.roundedBorderedPanel1.Size = new System.Drawing.Size(1004, 160);
            this.roundedBorderedPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(46, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Keep it up!";
            // 
            // lblMotivationShit
            // 
            this.lblMotivationShit.AutoSize = true;
            this.lblMotivationShit.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivationShit.ForeColor = System.Drawing.Color.White;
            this.lblMotivationShit.Location = new System.Drawing.Point(43, 40);
            this.lblMotivationShit.Name = "lblMotivationShit";
            this.lblMotivationShit.Size = new System.Drawing.Size(393, 45);
            this.lblMotivationShit.TabIndex = 0;
            this.lblMotivationShit.Text = "Time to grind, Ryan Paul";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RaonPointWindowsForms.Properties.Resources.weight;
            this.pictureBox3.Location = new System.Drawing.Point(908, 51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 133);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::RaonPointWindowsForms.Properties.Resources.weight;
            this.pictureBox4.Location = new System.Drawing.Point(-106, 73);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(150, 133);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.roundedBorderedPanel1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1063, 606);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.roundedBorderedPanel1.ResumeLayout(false);
            this.roundedBorderedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.RoundedBorderedPanel roundedBorderedPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMotivationShit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblExpiration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDaysLeft;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Components.RoundedBorderedPanel panelTodaySchedules;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
