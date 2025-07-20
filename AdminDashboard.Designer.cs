namespace EShiftApp
{
    partial class AdminDashboard
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
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.lblTotalJobs = new System.Windows.Forms.Label();
            this.lblTotalProducts = new System.Windows.Forms.Label();
            this.btnManageCustomers = new System.Windows.Forms.Button();
            this.btnManageJobs = new System.Windows.Forms.Button();
            this.btnManageProducts = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnTransportOperations = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chartStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.AutoSize = true;
            this.lblTotalCustomers.Location = new System.Drawing.Point(556, 377);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(118, 16);
            this.lblTotalCustomers.TabIndex = 7;
            this.lblTotalCustomers.Text = "Total Customers: 0";
            // 
            // lblTotalJobs
            // 
            this.lblTotalJobs.AutoSize = true;
            this.lblTotalJobs.Location = new System.Drawing.Point(556, 413);
            this.lblTotalJobs.Name = "lblTotalJobs";
            this.lblTotalJobs.Size = new System.Drawing.Size(84, 16);
            this.lblTotalJobs.TabIndex = 8;
            this.lblTotalJobs.Text = "Total Jobs: 0";
            this.lblTotalJobs.Click += new System.EventHandler(this.lblTotalJobs_Click);
            // 
            // lblTotalProducts
            // 
            this.lblTotalProducts.AutoSize = true;
            this.lblTotalProducts.Location = new System.Drawing.Point(556, 449);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(107, 16);
            this.lblTotalProducts.TabIndex = 9;
            this.lblTotalProducts.Text = "Total Products: 0";
            // 
            // btnManageCustomers
            // 
            this.btnManageCustomers.Location = new System.Drawing.Point(52, 89);
            this.btnManageCustomers.Name = "btnManageCustomers";
            this.btnManageCustomers.Size = new System.Drawing.Size(200, 40);
            this.btnManageCustomers.TabIndex = 0;
            this.btnManageCustomers.Text = "Manage Customers";
            this.btnManageCustomers.UseVisualStyleBackColor = true;
            this.btnManageCustomers.Click += new System.EventHandler(this.btnManageCustomers_Click);
            // 
            // btnManageJobs
            // 
            this.btnManageJobs.Location = new System.Drawing.Point(52, 149);
            this.btnManageJobs.Name = "btnManageJobs";
            this.btnManageJobs.Size = new System.Drawing.Size(200, 40);
            this.btnManageJobs.TabIndex = 1;
            this.btnManageJobs.Text = "Manage Jobs";
            this.btnManageJobs.UseVisualStyleBackColor = true;
            this.btnManageJobs.Click += new System.EventHandler(this.btnManageJobs_Click);
            // 
            // btnManageProducts
            // 
            this.btnManageProducts.Location = new System.Drawing.Point(52, 209);
            this.btnManageProducts.Name = "btnManageProducts";
            this.btnManageProducts.Size = new System.Drawing.Size(200, 40);
            this.btnManageProducts.TabIndex = 2;
            this.btnManageProducts.Text = "Manage Products";
            this.btnManageProducts.UseVisualStyleBackColor = true;
            this.btnManageProducts.Click += new System.EventHandler(this.btnManageProducts_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Location = new System.Drawing.Point(52, 269);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(200, 40);
            this.btnManageUsers.TabIndex = 3;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(52, 329);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(200, 40);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "Generate Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnTransportOperations
            // 
            this.btnTransportOperations.Location = new System.Drawing.Point(52, 389);
            this.btnTransportOperations.Name = "btnTransportOperations";
            this.btnTransportOperations.Size = new System.Drawing.Size(200, 40);
            this.btnTransportOperations.TabIndex = 5;
            this.btnTransportOperations.Text = "Transport Operations";
            this.btnTransportOperations.UseVisualStyleBackColor = true;
            this.btnTransportOperations.Click += new System.EventHandler(this.btnTransportOperations_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(52, 449);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 40);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(51, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Admin Panel";
            // 
            // chartStatistics
            // 
            this.chartStatistics.Location = new System.Drawing.Point(301, 33);
            this.chartStatistics.Name = "chartStatistics";
            this.chartStatistics.Size = new System.Drawing.Size(400, 300);
            this.chartStatistics.TabIndex = 10;
            this.chartStatistics.Text = "chart1";
            // 
            // AdminDashboard
            // 
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(732, 518);
            this.Controls.Add(this.chartStatistics);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnTransportOperations);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnManageProducts);
            this.Controls.Add(this.btnManageJobs);
            this.Controls.Add(this.btnManageCustomers);
            this.Controls.Add(this.lblTotalCustomers);
            this.Controls.Add(this.lblTotalJobs);
            this.Controls.Add(this.lblTotalProducts);
            this.Name = "AdminDashboard";
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalCustomers;
        private System.Windows.Forms.Label lblTotalJobs;
        private System.Windows.Forms.Label lblTotalProducts;
        private System.Windows.Forms.Button btnManageCustomers;
        private System.Windows.Forms.Button btnManageJobs;
        private System.Windows.Forms.Button btnManageProducts;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnTransportOperations;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistics;
    }
}
