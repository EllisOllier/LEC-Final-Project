
namespace LEC_Main_Project
{
    partial class frmHome
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
            this.groupBox_WeeklyJobs = new System.Windows.Forms.GroupBox();
            this.lblJobInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCompanyLogo)).BeginInit();
            this.groupBox_WeeklyJobs.SuspendLayout();
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
            // groupBox_WeeklyJobs
            // 
            this.groupBox_WeeklyJobs.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_WeeklyJobs.Controls.Add(this.lblJobInfo);
            this.groupBox_WeeklyJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_WeeklyJobs.Location = new System.Drawing.Point(12, 12);
            this.groupBox_WeeklyJobs.Name = "groupBox_WeeklyJobs";
            this.groupBox_WeeklyJobs.Size = new System.Drawing.Size(233, 128);
            this.groupBox_WeeklyJobs.TabIndex = 3;
            this.groupBox_WeeklyJobs.TabStop = false;
            this.groupBox_WeeklyJobs.Text = "Jobs this week:";
            // 
            // lblJobInfo
            // 
            this.lblJobInfo.AutoSize = true;
            this.lblJobInfo.Location = new System.Drawing.Point(6, 33);
            this.lblJobInfo.Name = "lblJobInfo";
            this.lblJobInfo.Size = new System.Drawing.Size(74, 72);
            this.lblJobInfo.TabIndex = 0;
            this.lblJobInfo.Text = "Lee: 10\r\nBen: 12\r\nTony: 9";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.groupBox_WeeklyJobs);
            this.Controls.Add(this.picCompanyLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.Text = "frmHome";
            ((System.ComponentModel.ISupportInitialize)(this.picCompanyLogo)).EndInit();
            this.groupBox_WeeklyJobs.ResumeLayout(false);
            this.groupBox_WeeklyJobs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picCompanyLogo;
        private System.Windows.Forms.GroupBox groupBox_WeeklyJobs;
        private System.Windows.Forms.Label lblJobInfo;
    }
}