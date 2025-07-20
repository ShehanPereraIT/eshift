using System.Windows.Forms;

namespace EShiftApp
{
    partial class ManageJobs
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
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.JobID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.btnDeleteJob = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbStartLocation = new System.Windows.Forms.ComboBox();
            this.cmbEndLocation = new System.Windows.Forms.ComboBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtInstruction = new System.Windows.Forms.TextBox();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.lblStartLocation = new System.Windows.Forms.Label();
            this.lblEndLocation = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJobs
            // 
            this.dgvJobs.AllowUserToAddRows = false;
            this.dgvJobs.AllowUserToDeleteRows = false;
            this.dgvJobs.AllowUserToResizeColumns = false;
            this.dgvJobs.AllowUserToResizeRows = false;
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JobID,
            this.StartLocation,
            this.EndLocation,
            this.Status,
            this.Distance,
            this.CustomerName,
            this.Phone,
            this.Address});
            this.dgvJobs.Location = new System.Drawing.Point(12, 60);
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.ReadOnly = true;
            this.dgvJobs.RowHeadersVisible = false;
            this.dgvJobs.RowHeadersWidth = 51;
            this.dgvJobs.RowTemplate.Height = 24;
            this.dgvJobs.Size = new System.Drawing.Size(880, 260);
            this.dgvJobs.TabIndex = 0;
            this.dgvJobs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJobs_CellContentClick);
            // 
            // JobID
            // 
            this.JobID.HeaderText = "Job ID";
            this.JobID.MinimumWidth = 6;
            this.JobID.Name = "JobID";
            this.JobID.ReadOnly = true;
            this.JobID.Visible = false;
            this.JobID.Width = 125;
            // 
            // StartLocation
            // 
            this.StartLocation.HeaderText = "Start Location";
            this.StartLocation.MinimumWidth = 6;
            this.StartLocation.Name = "StartLocation";
            this.StartLocation.ReadOnly = true;
            this.StartLocation.Width = 120;
            // 
            // EndLocation
            // 
            this.EndLocation.HeaderText = "End Location";
            this.EndLocation.MinimumWidth = 6;
            this.EndLocation.Name = "EndLocation";
            this.EndLocation.ReadOnly = true;
            this.EndLocation.Width = 120;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // Distance
            // 
            this.Distance.HeaderText = "Distance (km)";
            this.Distance.MinimumWidth = 6;
            this.Distance.Name = "Distance";
            this.Distance.ReadOnly = true;
            this.Distance.Width = 110;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 120;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 150;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Cornsilk;
            this.btnSearch.Location = new System.Drawing.Point(270, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Location = new System.Drawing.Point(15, 397);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(150, 24);
            this.cmbStatus.TabIndex = 3;
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.BackColor = System.Drawing.Color.DarkCyan;
            this.btnUpdateStatus.Location = new System.Drawing.Point(171, 393);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(110, 30);
            this.btnUpdateStatus.TabIndex = 4;
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = false;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // btnDeleteJob
            // 
            this.btnDeleteJob.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteJob.Location = new System.Drawing.Point(287, 393);
            this.btnDeleteJob.Name = "btnDeleteJob";
            this.btnDeleteJob.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteJob.TabIndex = 5;
            this.btnDeleteJob.Text = "Delete Job";
            this.btnDeleteJob.UseVisualStyleBackColor = false;
            this.btnDeleteJob.Click += new System.EventHandler(this.btnDeleteJob_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCancel.Location = new System.Drawing.Point(393, 393);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbStartLocation
            // 
            this.cmbStartLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartLocation.Location = new System.Drawing.Point(14, 350);
            this.cmbStartLocation.Name = "cmbStartLocation";
            this.cmbStartLocation.Size = new System.Drawing.Size(120, 24);
            this.cmbStartLocation.TabIndex = 6;
            // 
            // cmbEndLocation
            // 
            this.cmbEndLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEndLocation.Location = new System.Drawing.Point(140, 350);
            this.cmbEndLocation.Name = "cmbEndLocation";
            this.cmbEndLocation.Size = new System.Drawing.Size(120, 24);
            this.cmbEndLocation.TabIndex = 7;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(266, 350);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 22);
            this.txtCustomerID.TabIndex = 8;
            // 
            // txtInstruction
            // 
            this.txtInstruction.Location = new System.Drawing.Point(372, 350);
            this.txtInstruction.Name = "txtInstruction";
            this.txtInstruction.Size = new System.Drawing.Size(100, 22);
            this.txtInstruction.TabIndex = 9;
            // 
            // btnAddJob
            // 
            this.btnAddJob.BackColor = System.Drawing.Color.Cyan;
            this.btnAddJob.Location = new System.Drawing.Point(478, 345);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(80, 30);
            this.btnAddJob.TabIndex = 9;
            this.btnAddJob.Text = "Add Job";
            this.btnAddJob.UseVisualStyleBackColor = false;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // lblStartLocation
            // 
            this.lblStartLocation.Location = new System.Drawing.Point(14, 330);
            this.lblStartLocation.Name = "lblStartLocation";
            this.lblStartLocation.Size = new System.Drawing.Size(120, 20);
            this.lblStartLocation.TabIndex = 11;
            this.lblStartLocation.Text = "Start Location";
            // 
            // lblEndLocation
            // 
            this.lblEndLocation.Location = new System.Drawing.Point(140, 330);
            this.lblEndLocation.Name = "lblEndLocation";
            this.lblEndLocation.Size = new System.Drawing.Size(120, 20);
            this.lblEndLocation.TabIndex = 12;
            this.lblEndLocation.Text = "End Location";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.Location = new System.Drawing.Point(266, 330);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(100, 20);
            this.lblCustomerID.TabIndex = 13;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // lblInstruction
            // 
            this.lblInstruction.Location = new System.Drawing.Point(372, 330);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(100, 20);
            this.lblInstruction.TabIndex = 14;
            this.lblInstruction.Text = "Instruction";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Status";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ManageJobs
            // 
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvJobs);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.btnDeleteJob);
            this.Controls.Add(this.cmbStartLocation);
            this.Controls.Add(this.cmbEndLocation);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtInstruction);
            this.Controls.Add(this.btnAddJob);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblStartLocation);
            this.Controls.Add(this.lblEndLocation);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblInstruction);
            this.Name = "ManageJobs";
            this.Text = "Manage Jobs";
            this.Load += new System.EventHandler(this.ManageJobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvJobs;
        private DataGridViewTextBoxColumn JobID;
        private DataGridViewTextBoxColumn StartLocation;
        private DataGridViewTextBoxColumn EndLocation;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Distance;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Address;

        private TextBox txtSearch;
        private Button btnSearch;
        private ComboBox cmbStatus;
        private Button btnUpdateStatus;
        private Button btnDeleteJob;
        private Button btnCancel;
        // Changed from TextBox to ComboBox
        private ComboBox cmbStartLocation;
        private ComboBox cmbEndLocation;
        // Existing TextBox for CustomerID and Instruction
        private TextBox txtCustomerID;
        private TextBox txtInstruction;
        private Button btnAddJob;

        private Label lblStartLocation;
        private Label lblEndLocation;
        private Label lblCustomerID;
        private Label lblInstruction; // Added this missing declaration
        private Label label1;
    }
}