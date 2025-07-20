using System.Windows.Forms;

namespace EShiftApp
{
    partial class Reports
    {
        private System.ComponentModel.IContainer components = null;

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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnDownloadSelectedJob = new System.Windows.Forms.Button();
            this.btnDownloadAllCustomers = new System.Windows.Forms.Button();
            this.btnDownloadAllJobs = new System.Windows.Forms.Button();
            this.btnDownloadAllTransport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 80);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.Size = new System.Drawing.Size(760, 350);
            this.dgvData.TabIndex = 0;
            // 
            // btnDownloadSelectedJob
            // 
            this.btnDownloadSelectedJob.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDownloadSelectedJob.Location = new System.Drawing.Point(12, 20);
            this.btnDownloadSelectedJob.Name = "btnDownloadSelectedJob";
            this.btnDownloadSelectedJob.Size = new System.Drawing.Size(180, 40);
            this.btnDownloadSelectedJob.TabIndex = 1;
            this.btnDownloadSelectedJob.Text = "Download Selected Job";
            this.btnDownloadSelectedJob.UseVisualStyleBackColor = false;
            this.btnDownloadSelectedJob.Click += new System.EventHandler(this.btnDownloadSelectedJob_Click);
            // 
            // btnDownloadAllCustomers
            // 
            this.btnDownloadAllCustomers.BackColor = System.Drawing.Color.Cornsilk;
            this.btnDownloadAllCustomers.Location = new System.Drawing.Point(200, 20);
            this.btnDownloadAllCustomers.Name = "btnDownloadAllCustomers";
            this.btnDownloadAllCustomers.Size = new System.Drawing.Size(180, 40);
            this.btnDownloadAllCustomers.TabIndex = 2;
            this.btnDownloadAllCustomers.Text = "Download All Customers";
            this.btnDownloadAllCustomers.UseVisualStyleBackColor = false;
            this.btnDownloadAllCustomers.Click += new System.EventHandler(this.btnDownloadAllCustomers_Click);
            // 
            // btnDownloadAllJobs
            // 
            this.btnDownloadAllJobs.BackColor = System.Drawing.Color.Crimson;
            this.btnDownloadAllJobs.Location = new System.Drawing.Point(388, 20);
            this.btnDownloadAllJobs.Name = "btnDownloadAllJobs";
            this.btnDownloadAllJobs.Size = new System.Drawing.Size(180, 40);
            this.btnDownloadAllJobs.TabIndex = 3;
            this.btnDownloadAllJobs.Text = "Download All Jobs";
            this.btnDownloadAllJobs.UseVisualStyleBackColor = false;
            this.btnDownloadAllJobs.Click += new System.EventHandler(this.btnDownloadAllJobs_Click);
            // 
            // btnDownloadAllTransport
            // 
            this.btnDownloadAllTransport.BackColor = System.Drawing.Color.Cyan;
            this.btnDownloadAllTransport.Location = new System.Drawing.Point(576, 20);
            this.btnDownloadAllTransport.Name = "btnDownloadAllTransport";
            this.btnDownloadAllTransport.Size = new System.Drawing.Size(196, 40);
            this.btnDownloadAllTransport.TabIndex = 4;
            this.btnDownloadAllTransport.Text = "Download All Transport";
            this.btnDownloadAllTransport.UseVisualStyleBackColor = false;
            this.btnDownloadAllTransport.Click += new System.EventHandler(this.btnDownloadAllTransport_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.btnDownloadAllTransport);
            this.Controls.Add(this.btnDownloadAllJobs);
            this.Controls.Add(this.btnDownloadAllCustomers);
            this.Controls.Add(this.btnDownloadSelectedJob);
            this.Controls.Add(this.dgvData);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnDownloadSelectedJob;
        private System.Windows.Forms.Button btnDownloadAllCustomers;
        private System.Windows.Forms.Button btnDownloadAllJobs;
        private System.Windows.Forms.Button btnDownloadAllTransport;
    }
}
