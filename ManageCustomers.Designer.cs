namespace EShiftApp
{
    partial class ManageCustomers
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeight = 29;
            this.dgvCustomers.Location = new System.Drawing.Point(400, 20);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.Size = new System.Drawing.Size(500, 266);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            this.dgvCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellContentClick);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(125, 82);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(241, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(125, 122);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(241, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(125, 162);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(241, 22);
            this.txtPhone.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(125, 202);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(241, 22);
            this.txtAddress.TabIndex = 4;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(28, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(243, 22);
            this.txtSearch.TabIndex = 5;
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(25, 82);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(81, 23);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(25, 122);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 23);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password:";
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(25, 162);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(53, 23);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Phone:";
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(25, 202);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(75, 23);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Address:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.Location = new System.Drawing.Point(126, 263);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Cyan;
            this.btnUpdate.Location = new System.Drawing.Point(207, 263);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Location = new System.Drawing.Point(288, 263);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Cornsilk;
            this.btnSearch.Location = new System.Drawing.Point(291, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ManageCustomers
            // 
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(929, 312);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Name = "ManageCustomers";
            this.Text = "Manage Customers";
            this.Load += new System.EventHandler(this.ManageCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
