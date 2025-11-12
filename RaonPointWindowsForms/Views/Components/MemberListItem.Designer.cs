namespace RaonPointWindowsForms.Views.Components
{
    partial class MemberListItem
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.lblPlans = new System.Windows.Forms.Label();
            this.lblJoiningDate = new System.Windows.Forms.Label();
            this.lblExpiredDate = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Silver;
            this.lblName.Location = new System.Drawing.Point(16, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Ryan Paul";
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberId.ForeColor = System.Drawing.Color.Silver;
            this.lblMemberId.Location = new System.Drawing.Point(186, 13);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(35, 15);
            this.lblMemberId.TabIndex = 1;
            this.lblMemberId.Text = "0321";
            // 
            // lblPlans
            // 
            this.lblPlans.AutoSize = true;
            this.lblPlans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlans.ForeColor = System.Drawing.Color.Silver;
            this.lblPlans.Location = new System.Drawing.Point(291, 13);
            this.lblPlans.Name = "lblPlans";
            this.lblPlans.Size = new System.Drawing.Size(58, 15);
            this.lblPlans.TabIndex = 2;
            this.lblPlans.Text = "3 Months";
            // 
            // lblJoiningDate
            // 
            this.lblJoiningDate.AutoSize = true;
            this.lblJoiningDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoiningDate.ForeColor = System.Drawing.Color.Silver;
            this.lblJoiningDate.Location = new System.Drawing.Point(404, 13);
            this.lblJoiningDate.Name = "lblJoiningDate";
            this.lblJoiningDate.Size = new System.Drawing.Size(55, 15);
            this.lblJoiningDate.TabIndex = 3;
            this.lblJoiningDate.Text = "11/11/25";
            // 
            // lblExpiredDate
            // 
            this.lblExpiredDate.AutoSize = true;
            this.lblExpiredDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiredDate.ForeColor = System.Drawing.Color.Silver;
            this.lblExpiredDate.Location = new System.Drawing.Point(524, 14);
            this.lblExpiredDate.Name = "lblExpiredDate";
            this.lblExpiredDate.Size = new System.Drawing.Size(55, 15);
            this.lblExpiredDate.TabIndex = 4;
            this.lblExpiredDate.Text = "11/11/25";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.Color.Silver;
            this.lblCost.Location = new System.Drawing.Point(655, 14);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(38, 15);
            this.lblCost.TabIndex = 5;
            this.lblCost.Text = "4,500";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Silver;
            this.lblStatus.Location = new System.Drawing.Point(759, 13);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(32, 15);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Paid";
            // 
            // MemberListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblExpiredDate);
            this.Controls.Add(this.lblJoiningDate);
            this.Controls.Add(this.lblPlans);
            this.Controls.Add(this.lblMemberId);
            this.Controls.Add(this.lblName);
            this.Name = "MemberListItem";
            this.Size = new System.Drawing.Size(980, 46);
            this.Load += new System.EventHandler(this.MemberListItem_Load);
            this.MouseLeave += new System.EventHandler(this.MemberListItem_MouseLeave);
            this.MouseHover += new System.EventHandler(this.MemberListItem_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.Label lblPlans;
        private System.Windows.Forms.Label lblJoiningDate;
        private System.Windows.Forms.Label lblExpiredDate;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblStatus;
    }
}
