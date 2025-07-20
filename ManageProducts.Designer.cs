namespace EShiftApp
{
    partial class ManageProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Declare your controls here (these are already correct in your snippet)
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInstructions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            //
            // dgvProducts
            //
            this.dgvProducts.AllowUserToAddRows = false; // Prevents blank row at the bottom
            this.dgvProducts.AllowUserToDeleteRows = false; // Prevents user deletion directly from grid
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            // Define the columns explicitly here:
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductID,
            this.colProductName,
            this.colCategory,
            this.colWeight,
            this.colInstructions});
            this.dgvProducts.Location = new System.Drawing.Point(400, 20); // Your existing location
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true; // Make the grid read-only by default
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24; // Standard row height
            this.dgvProducts.Size = new System.Drawing.Size(500, 300); // Your existing size
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            //
            // colProductID
            //
            this.colProductID.DataPropertyName = "ProductID"; // Maps to your database column name
            this.colProductID.HeaderText = "Product ID";
            this.colProductID.Name = "colProductID";
            this.colProductID.ReadOnly = true;
            this.colProductID.Width = 80; // Example width
            //
            // colProductName
            //
            this.colProductName.DataPropertyName = "ProductName";
            this.colProductName.HeaderText = "Product Name";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            this.colProductName.Width = 120;
            //
            // colCategory
            //
            this.colCategory.DataPropertyName = "Category";
            this.colCategory.HeaderText = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            this.colCategory.Width = 100;
            //
            // colWeight
            //
            this.colWeight.DataPropertyName = "Weight";
            this.colWeight.HeaderText = "Weight";
            this.colWeight.Name = "colWeight";
            this.colWeight.ReadOnly = true;
            this.colWeight.Width = 70;
            //
            // colInstructions
            //
            this.colInstructions.DataPropertyName = "SpecialInstructions";
            this.colInstructions.HeaderText = "Special Instructions";
            this.colInstructions.Name = "colInstructions";
            this.colInstructions.ReadOnly = true;
            this.colInstructions.Width = 150; // Adjust as needed

            // (The rest of your InitializeComponent code for other controls remains the same)
            //
            // txtProductName
            //
            this.txtProductName.Location = new System.Drawing.Point(133, 103);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(250, 22);
            this.txtProductName.TabIndex = 1;
            //
            // txtCategory
            //
            this.txtCategory.Location = new System.Drawing.Point(133, 143);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(250, 22);
            this.txtCategory.TabIndex = 2;
            //
            // txtWeight
            //
            this.txtWeight.Location = new System.Drawing.Point(133, 183);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(250, 22);
            this.txtWeight.TabIndex = 3;
            //
            // txtInstructions
            //
            this.txtInstructions.Location = new System.Drawing.Point(150, 223);
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(233, 22);
            this.txtInstructions.TabIndex = 4;
            //
            // txtSearch
            //
            this.txtSearch.Location = new System.Drawing.Point(23, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(275, 22);
            this.txtSearch.TabIndex = 5;
            //
            // lblProductName
            //
            this.lblProductName.Location = new System.Drawing.Point(23, 103);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(100, 23);
            this.lblProductName.TabIndex = 6;
            this.lblProductName.Text = "Product Name:";
            //
            // lblCategory
            //
            this.lblCategory.Location = new System.Drawing.Point(23, 143);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(100, 23);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Category:";
            //
            // lblWeight
            //
            this.lblWeight.Location = new System.Drawing.Point(23, 183);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(100, 23);
            this.lblWeight.TabIndex = 8;
            this.lblWeight.Text = "Weight:";
            //
            // lblInstructions
            //
            this.lblInstructions.Location = new System.Drawing.Point(23, 226);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(168, 23);
            this.lblInstructions.TabIndex = 9;
            this.lblInstructions.Text = "Special Instructions:";
            //
            // btnAdd
            //
            this.btnAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.Location = new System.Drawing.Point(133, 299);
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
            this.btnUpdate.Location = new System.Drawing.Point(221, 299);
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
            this.btnDelete.Location = new System.Drawing.Point(308, 297);
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
            this.btnSearch.Location = new System.Drawing.Point(308, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            //
            // ManageProducts
            //
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(930, 345);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Name = "ManageProducts";
            this.Text = "Manage Products";
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Add the declarations for your DataGridView Columns here
        // These are automatically generated by the designer when you add columns
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInstructions;
    }
}