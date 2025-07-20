namespace EShiftApp
{
    partial class CustomerDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">True if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTotalJobs = new System.Windows.Forms.Label();
            this.lblOngoingJobs = new System.Windows.Forms.Label();
            this.lstOngoingJobs = new System.Windows.Forms.ListBox();
            this.btnPlaceJob = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chartStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalJobs
            // 
            this.lblTotalJobs.AutoSize = true;
            this.lblTotalJobs.Location = new System.Drawing.Point(60, 246);
            this.lblTotalJobs.Name = "lblTotalJobs";
            this.lblTotalJobs.Size = new System.Drawing.Size(84, 16);
            this.lblTotalJobs.TabIndex = 7;
            this.lblTotalJobs.Text = "Total Jobs: 0";
            this.lblTotalJobs.Click += new System.EventHandler(this.lblTotalJobs_Click);
            // 
            // lblOngoingJobs
            // 
            this.lblOngoingJobs.AutoSize = true;
            this.lblOngoingJobs.Location = new System.Drawing.Point(60, 284);
            this.lblOngoingJobs.Name = "lblOngoingJobs";
            this.lblOngoingJobs.Size = new System.Drawing.Size(104, 16);
            this.lblOngoingJobs.TabIndex = 8;
            this.lblOngoingJobs.Text = "Ongoing Jobs: 0";
            // 
            // lstOngoingJobs
            // 
            this.lstOngoingJobs.FormattingEnabled = true;
            this.lstOngoingJobs.ItemHeight = 16;
            this.lstOngoingJobs.Location = new System.Drawing.Point(300, 279);
            this.lstOngoingJobs.Name = "lstOngoingJobs";
            this.lstOngoingJobs.Size = new System.Drawing.Size(400, 180);
            this.lstOngoingJobs.TabIndex = 9;
            // 
            // btnPlaceJob
            // 
            this.btnPlaceJob.Location = new System.Drawing.Point(56, 107);
            this.btnPlaceJob.Name = "btnPlaceJob";
            this.btnPlaceJob.Size = new System.Drawing.Size(200, 40);
            this.btnPlaceJob.TabIndex = 10;
            this.btnPlaceJob.Text = "Place New Job";
            this.btnPlaceJob.UseVisualStyleBackColor = true;
            this.btnPlaceJob.Click += new System.EventHandler(this.btnPlaceJob_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(56, 166);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 40);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "Customer Panel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chartStatistics
            // 
            this.chartStatistics.Location = new System.Drawing.Point(300, 29);
            this.chartStatistics.Name = "chartStatistics";
            this.chartStatistics.Size = new System.Drawing.Size(400, 234);
            this.chartStatistics.TabIndex = 13;
            this.chartStatistics.Text = "chart1";
            this.chartStatistics.Click += new System.EventHandler(this.chartStatistics_Click);
            // 
            // CustomerDashboard
            // 
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.chartStatistics);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPlaceJob);
            this.Controls.Add(this.lstOngoingJobs);
            this.Controls.Add(this.lblOngoingJobs);
            this.Controls.Add(this.lblTotalJobs);
            this.Name = "CustomerDashboard";
            this.Text = "Customer Dashboard";
            this.Load += new System.EventHandler(this.CustomerDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalJobs;
        private System.Windows.Forms.Label lblOngoingJobs;
        private System.Windows.Forms.ListBox lstOngoingJobs;
        private System.Windows.Forms.Button btnPlaceJob;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistics;
    }
}
