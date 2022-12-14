
namespace LEC_Main_Project
{
    partial class frmEmployee
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
            this.picCompanyLogo = new System.Windows.Forms.PictureBox();
            this.groupBox_WeeklyUpdates = new System.Windows.Forms.GroupBox();
            this.lblWeeklyUpdates = new System.Windows.Forms.Label();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCompanyLogo)).BeginInit();
            this.groupBox_WeeklyUpdates.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCompanyLogo
            // 
            this.picCompanyLogo.Image = global::LEC_Main_Project.Properties.Resources.Lees_Electrical_Logo_Blue_Small_removebg_preview__1_;
            this.picCompanyLogo.Location = new System.Drawing.Point(696, 390);
            this.picCompanyLogo.Name = "picCompanyLogo";
            this.picCompanyLogo.Size = new System.Drawing.Size(64, 60);
            this.picCompanyLogo.TabIndex = 2;
            this.picCompanyLogo.TabStop = false;
            // 
            // groupBox_WeeklyUpdates
            // 
            this.groupBox_WeeklyUpdates.Controls.Add(this.lblWeeklyUpdates);
            this.groupBox_WeeklyUpdates.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_WeeklyUpdates.Location = new System.Drawing.Point(13, 61);
            this.groupBox_WeeklyUpdates.Name = "groupBox_WeeklyUpdates";
            this.groupBox_WeeklyUpdates.Size = new System.Drawing.Size(236, 100);
            this.groupBox_WeeklyUpdates.TabIndex = 3;
            this.groupBox_WeeklyUpdates.TabStop = false;
            this.groupBox_WeeklyUpdates.Text = "Weekly Updates:";
            // 
            // lblWeeklyUpdates
            // 
            this.lblWeeklyUpdates.AutoSize = true;
            this.lblWeeklyUpdates.Location = new System.Drawing.Point(7, 43);
            this.lblWeeklyUpdates.Name = "lblWeeklyUpdates";
            this.lblWeeklyUpdates.Size = new System.Drawing.Size(215, 48);
            this.lblWeeklyUpdates.TabIndex = 0;
            this.lblWeeklyUpdates.Text = "Jobs completed: 19\r\nIncome last week: £1900\r\n";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.Location = new System.Drawing.Point(13, 13);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(175, 20);
            this.lblCurrentUser.TabIndex = 4;
            this.lblCurrentUser.Text = "Current User: Ellis Ollier";
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.groupBox_WeeklyUpdates);
            this.Controls.Add(this.picCompanyLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployee";
            this.Text = "frmEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.picCompanyLogo)).EndInit();
            this.groupBox_WeeklyUpdates.ResumeLayout(false);
            this.groupBox_WeeklyUpdates.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picCompanyLogo;
        private System.Windows.Forms.GroupBox groupBox_WeeklyUpdates;
        private System.Windows.Forms.Label lblWeeklyUpdates;
        private System.Windows.Forms.Label lblCurrentUser;
    }
}