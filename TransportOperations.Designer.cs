using System.Windows.Forms; // This line is usually at the top of the .cs file, but if it's in designer, keep it.

namespace EShiftApp
{
    partial class TransportOperations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Declare all UI controls
        private System.Windows.Forms.DataGridView dgvTransport;
        private System.Windows.Forms.TextBox txtDriverName;
        private System.Windows.Forms.TextBox txtVehicle;
        private System.Windows.Forms.TextBox txtVehicleNo;
        private System.Windows.Forms.ComboBox cmbAvailability;
        private System.Windows.Forms.TextBox txtWeightCapacity;
        private System.Windows.Forms.TextBox txtPricePerKM;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDriverName;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label lblVehicleNo;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Label lblWeightCapacity;
        private System.Windows.Forms.Label lblPricePerKM;

        // Declare DataGridView Columns (NEWLY ADDED / ENSURED)
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicleNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvailability;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeightCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPricePerKM;


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
            // Initialize all controls first
            this.dgvTransport = new System.Windows.Forms.DataGridView();
            this.txtDriverName = new System.Windows.Forms.TextBox();
            this.txtVehicle = new System.Windows.Forms.TextBox();
            this.txtVehicleNo = new System.Windows.Forms.TextBox();
            this.cmbAvailability = new System.Windows.Forms.ComboBox();
            this.txtWeightCapacity = new System.Windows.Forms.TextBox();
            this.txtPricePerKM = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDriverName = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.lblVehicleNo = new System.Windows.Forms.Label();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.lblWeightCapacity = new System.Windows.Forms.Label();
            this.lblPricePerKM = new System.Windows.Forms.Label();

            // Initialize DataGridView Columns (CRITICAL FOR "UNDECLARED" ERRORS)
            this.colTransportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehicleNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvailability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeightCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPricePerKM = new System.Windows.Forms.DataGridViewTextBoxColumn();


            ((System.ComponentModel.ISupportInitialize)(this.dgvTransport)).BeginInit();
            this.SuspendLayout();

            //
            // dgvTransport
            //
            this.dgvTransport.AllowUserToAddRows = false; // Prevent adding rows directly
            this.dgvTransport.AllowUserToDeleteRows = false; // Prevent deleting rows directly
            this.dgvTransport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTransportID,
            this.colDriverName,
            this.colVehicle,
            this.colVehicleNo,
            this.colAvailability,
            this.colWeightCapacity,
            this.colPricePerKM});
            this.dgvTransport.Location = new System.Drawing.Point(20, 250);
            this.dgvTransport.Name = "dgvTransport";
            this.dgvTransport.ReadOnly = true; // Make it read-only by default, update via buttons
            this.dgvTransport.RowHeadersWidth = 51;
            this.dgvTransport.RowTemplate.Height = 24;
            this.dgvTransport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect; // Select entire row
            this.dgvTransport.Size = new System.Drawing.Size(740, 200);
            this.dgvTransport.TabIndex = 0;
            this.dgvTransport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; // Optional: Makes columns fill the width
            this.dgvTransport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransport_CellClick);
            this.dgvTransport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransport_CellContentClick);
            //
            // colTransportID
            //
            this.colTransportID.DataPropertyName = "TransportID"; // IMPORTANT: Matches database column name
            this.colTransportID.HeaderText = "Transport ID";
            this.colTransportID.Name = "colTransportID";
            this.colTransportID.ReadOnly = true;
            //
            // colDriverName
            //
            this.colDriverName.DataPropertyName = "DriverName";
            this.colDriverName.HeaderText = "Driver Name";
            this.colDriverName.Name = "colDriverName";
            this.colDriverName.ReadOnly = true;
            //
            // colVehicle
            //
            this.colVehicle.DataPropertyName = "Vehicle";
            this.colVehicle.HeaderText = "Vehicle Type";
            this.colVehicle.Name = "colVehicle";
            this.colVehicle.ReadOnly = true;
            //
            // colVehicleNo
            //
            this.colVehicleNo.DataPropertyName = "VehicleNo";
            this.colVehicleNo.HeaderText = "Vehicle No";
            this.colVehicleNo.Name = "colVehicleNo";
            this.colVehicleNo.ReadOnly = true;
            //
            // colAvailability
            //
            this.colAvailability.DataPropertyName = "Availability";
            this.colAvailability.HeaderText = "Availability";
            this.colAvailability.Name = "colAvailability";
            this.colAvailability.ReadOnly = true;
            //
            // colWeightCapacity
            //
            this.colWeightCapacity.DataPropertyName = "WeightCapacity";
            this.colWeightCapacity.HeaderText = "Weight Capacity (KG)";
            this.colWeightCapacity.Name = "colWeightCapacity";
            this.colWeightCapacity.ReadOnly = true;
            //
            // colPricePerKM
            //
            this.colPricePerKM.DataPropertyName = "PricePerKM";
            this.colPricePerKM.HeaderText = "Price per KM (LKR)";
            this.colPricePerKM.Name = "colPricePerKM";
            this.colPricePerKM.ReadOnly = true;


            //
            // txtDriverName
            //
            this.txtDriverName.Location = new System.Drawing.Point(130, 20);
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(225, 22);
            this.txtDriverName.TabIndex = 1;
            //
            // txtVehicle
            //
            this.txtVehicle.Location = new System.Drawing.Point(130, 60);
            this.txtVehicle.Name = "txtVehicle";
            this.txtVehicle.Size = new System.Drawing.Size(225, 22);
            this.txtVehicle.TabIndex = 2;
            //
            // txtVehicleNo
            //
            this.txtVehicleNo.Location = new System.Drawing.Point(130, 101);
            this.txtVehicleNo.Name = "txtVehicleNo";
            this.txtVehicleNo.Size = new System.Drawing.Size(225, 22);
            this.txtVehicleNo.TabIndex = 3;
            //
            // cmbAvailability
            //
            this.cmbAvailability.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
            this.cmbAvailability.Location = new System.Drawing.Point(130, 140);
            this.cmbAvailability.Name = "cmbAvailability";
            this.cmbAvailability.Size = new System.Drawing.Size(225, 24);
            this.cmbAvailability.TabIndex = 4;
            //
            // txtWeightCapacity
            //
            this.txtWeightCapacity.Location = new System.Drawing.Point(130, 180);
            this.txtWeightCapacity.Name = "txtWeightCapacity";
            this.txtWeightCapacity.Size = new System.Drawing.Size(225, 22);
            this.txtWeightCapacity.TabIndex = 5;
            //
            // txtPricePerKM
            //
            this.txtPricePerKM.Location = new System.Drawing.Point(130, 220);
            this.txtPricePerKM.Name = "txtPricePerKM";
            this.txtPricePerKM.Size = new System.Drawing.Size(225, 22);
            this.txtPricePerKM.TabIndex = 6;
            //
            // txtSearch
            //
            this.txtSearch.Location = new System.Drawing.Point(435, 221);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(244, 22);
            this.txtSearch.TabIndex = 7;
            //
            // btnSearch
            //
            this.btnSearch.BackColor = System.Drawing.Color.Cornsilk;
            this.btnSearch.Location = new System.Drawing.Point(685, 221);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            //
            // btnAdd
            //
            this.btnAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.Location = new System.Drawing.Point(435, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnUpdate
            //
            this.btnUpdate.BackColor = System.Drawing.Color.Cyan;
            this.btnUpdate.Location = new System.Drawing.Point(435, 60);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            //
            // btnDelete
            //
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Location = new System.Drawing.Point(435, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // lblDriverName
            //
            this.lblDriverName.Location = new System.Drawing.Point(20, 20);
            this.lblDriverName.Name = "lblDriverName";
            this.lblDriverName.Size = new System.Drawing.Size(100, 23);
            this.lblDriverName.TabIndex = 12;
            this.lblDriverName.Text = "Driver Name";
            //
            // lblVehicle
            //
            this.lblVehicle.Location = new System.Drawing.Point(20, 60);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(100, 23);
            this.lblVehicle.TabIndex = 13;
            this.lblVehicle.Text = "Vehicle";
            //
            // lblVehicleNo
            //
            this.lblVehicleNo.Location = new System.Drawing.Point(20, 100);
            this.lblVehicleNo.Name = "lblVehicleNo";
            this.lblVehicleNo.Size = new System.Drawing.Size(100, 23);
            this.lblVehicleNo.TabIndex = 14;
            this.lblVehicleNo.Text = "Vehicle No";
            //
            // lblAvailability
            //
            this.lblAvailability.Location = new System.Drawing.Point(20, 140);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(100, 23);
            this.lblAvailability.TabIndex = 15;
            this.lblAvailability.Text = "Availability";
            //
            // lblWeightCapacity
            //
            this.lblWeightCapacity.Location = new System.Drawing.Point(20, 180);
            this.lblWeightCapacity.Name = "lblWeightCapacity";
            this.lblWeightCapacity.Size = new System.Drawing.Size(100, 23);
            this.lblWeightCapacity.TabIndex = 16;
            this.lblWeightCapacity.Text = "Weight Capacity";
            //
            // lblPricePerKM
            //
            this.lblPricePerKM.Location = new System.Drawing.Point(20, 220);
            this.lblPricePerKM.Name = "lblPricePerKM";
            this.lblPricePerKM.Size = new System.Drawing.Size(100, 23);
            this.lblPricePerKM.TabIndex = 17;
            this.lblPricePerKM.Text = "Price per KM";
            //
            // TransportOperations
            //
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(784, 461); // Keep original size
            this.Controls.Add(this.lblPricePerKM);
            this.Controls.Add(this.lblWeightCapacity);
            this.Controls.Add(this.lblAvailability);
            this.Controls.Add(this.lblVehicleNo);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.lblDriverName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtPricePerKM);
            this.Controls.Add(this.txtWeightCapacity);
            this.Controls.Add(this.cmbAvailability);
            this.Controls.Add(this.txtVehicleNo);
            this.Controls.Add(this.txtVehicle);
            this.Controls.Add(this.txtDriverName);
            this.Controls.Add(this.dgvTransport);
            this.Name = "TransportOperations";
            this.Text = "Transport Operations";
            this.Load += new System.EventHandler(this.TransportOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}