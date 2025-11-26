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
            this.lblJoiningDate = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblExpiredDate = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Silver;
            this.lblName.Location = new System.Drawing.Point(159, 14);
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
            this.lblMemberId.Location = new System.Drawing.Point(21, 14);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(50, 15);
            this.lblMemberId.TabIndex = 1;
            this.lblMemberId.Text = "M-1001";
            // 
            // lblJoiningDate
            // 
            this.lblJoiningDate.AutoSize = true;
            this.lblJoiningDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoiningDate.ForeColor = System.Drawing.Color.Silver;
            this.lblJoiningDate.Location = new System.Drawing.Point(455, 14);
            this.lblJoiningDate.Name = "lblJoiningDate";
            this.lblJoiningDate.Size = new System.Drawing.Size(55, 15);
            this.lblJoiningDate.TabIndex = 3;
            this.lblJoiningDate.Text = "11/11/25";
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlan.ForeColor = System.Drawing.Color.Silver;
            this.lblPlan.Location = new System.Drawing.Point(365, 14);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(43, 15);
            this.lblPlan.TabIndex = 4;
            this.lblPlan.Text = "Starter";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblStatus.Location = new System.Drawing.Point(682, 13);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 15);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Active";
            // 
            // lblExpiredDate
            // 
            this.lblExpiredDate.AutoSize = true;
            this.lblExpiredDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiredDate.ForeColor = System.Drawing.Color.Silver;
            this.lblExpiredDate.Location = new System.Drawing.Point(560, 14);
            this.lblExpiredDate.Name = "lblExpiredDate";
            this.lblExpiredDate.Size = new System.Drawing.Size(55, 15);
            this.lblExpiredDate.TabIndex = 7;
            this.lblExpiredDate.Text = "11/11/25";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.ForeColor = System.Drawing.Color.Silver;
            this.lblEdit.Location = new System.Drawing.Point(840, 13);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(32, 15);
            this.lblEdit.TabIndex = 8;
            this.lblEdit.Text = "Edit";
            this.lblEdit.Click += new System.EventHandler(this.lblEdit_Click);
            this.lblEdit.MouseLeave += new System.EventHandler(this.lblEdit_MouseLeave);
            this.lblEdit.MouseHover += new System.EventHandler(this.lblEdit_MouseHover);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.ForeColor = System.Drawing.Color.Silver;
            this.lblDelete.Location = new System.Drawing.Point(898, 14);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(49, 15);
            this.lblDelete.TabIndex = 9;
            this.lblDelete.Text = "Delete";
            this.lblDelete.Click += new System.EventHandler(this.lblDelete_Click);
            this.lblDelete.MouseEnter += new System.EventHandler(this.lblDelete_MouseEnter);
            this.lblDelete.MouseLeave += new System.EventHandler(this.lblDelete_MouseLeave);
            // 
            // MemberListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.lblExpiredDate);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.lblJoiningDate);
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
        private System.Windows.Forms.Label lblJoiningDate;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblExpiredDate;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblDelete;
    }
}
