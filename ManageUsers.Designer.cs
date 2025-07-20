namespace EShiftApp
{
    partial class ManageUsers
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(400, 20);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.Size = new System.Drawing.Size(480, 300);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(127, 82);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(250, 22);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(127, 122);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // cmbRole
            // 
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Customer"});
            this.cmbRole.Location = new System.Drawing.Point(127, 162);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(250, 24);
            this.cmbRole.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(127, 202);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(250, 22);
            this.txtPhone.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(127, 242);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 22);
            this.txtAddress.TabIndex = 4;
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(27, 82);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(100, 23);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(27, 122);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 23);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            // 
            // lblRole
            // 
            this.lblRole.Location = new System.Drawing.Point(27, 162);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(100, 23);
            this.lblRole.TabIndex = 7;
            this.lblRole.Text = "Role:";
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(27, 202);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(100, 23);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Phone:";
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(27, 242);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 23);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Address:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.Location = new System.Drawing.Point(127, 297);
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
            this.btnUpdate.Location = new System.Drawing.Point(208, 297);
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
            this.btnDelete.Location = new System.Drawing.Point(289, 297);
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
            this.btnSearch.Location = new System.Drawing.Point(309, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(30, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(273, 22);
            this.txtSearch.TabIndex = 13;
            // 
            // ManageUsers
            // 
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(900, 334);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvUsers);
            this.Name = "ManageUsers";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
