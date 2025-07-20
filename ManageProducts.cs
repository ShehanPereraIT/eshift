using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EShiftApp
{
    public partial class ManageProducts : Form
    {
        private DbConnection dbCon; // Assuming DbConnection is a class you have defined for database operations.

        public ManageProducts()
        {
            InitializeComponent();
            dbCon = new DbConnection();
        
            dgvProducts.AutoGenerateColumns = false;
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts(string searchTerm = "")
        {
            dgvProducts.Rows.Clear(); // Clear existing rows before loading new ones
            try
            {
                dbCon.OpenConnection();
                // Explicitly select columns matching your DataGridView setup
                string query = "SELECT ProductID, ProductName, Category, Weight, SpecialInstructions FROM Products WHERE ProductName LIKE @search OR Category LIKE @search";
                SqlCommand cmd = new SqlCommand(query, dbCon.sqlConnection);
                cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Add values to the DataGridView rows, matching the order of your defined columns
                    dgvProducts.Rows.Add(
                        reader["ProductID"],
                        reader["ProductName"],
                        reader["Category"],
                        reader["Weight"],
                        reader["SpecialInstructions"]
                    );
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbCon.CloseConnection();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Input validation
            if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
                string.IsNullOrWhiteSpace(txtCategory.Text) ||
                string.IsNullOrWhiteSpace(txtWeight.Text) ||
                string.IsNullOrWhiteSpace(txtInstructions.Text))
            {
                MessageBox.Show("Please fill in all product details.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Weight as a number
            if (!decimal.TryParse(txtWeight.Text, out decimal weight))
            {
                MessageBox.Show("Weight must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWeight.Focus(); // Set focus back to the weight field for correction
                return;
            }

            try
            {
                dbCon.OpenConnection();
                string query = @"INSERT INTO Products (ProductName, Category, Weight, SpecialInstructions)
                                 VALUES (@Name, @Category, @Weight, @Instructions)";
                SqlCommand cmd = new SqlCommand(query, dbCon.sqlConnection);
                cmd.Parameters.AddWithValue("@Name", txtProductName.Text.Trim());
                cmd.Parameters.AddWithValue("@Category", txtCategory.Text.Trim());
                cmd.Parameters.AddWithValue("@Weight", weight); // Use the parsed decimal weight
                cmd.Parameters.AddWithValue("@Instructions", txtInstructions.Text.Trim());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputFields(); // Clear input fields after successful add
                LoadProducts(); // Reload grid to show the new product
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbCon.CloseConnection();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Input validation
            if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
                string.IsNullOrWhiteSpace(txtCategory.Text) ||
                string.IsNullOrWhiteSpace(txtWeight.Text) ||
                string.IsNullOrWhiteSpace(txtInstructions.Text))
            {
                MessageBox.Show("Please fill in all product details for update.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtWeight.Text, out decimal weight))
            {
                MessageBox.Show("Weight must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWeight.Focus();
                return;
            }

            // Get ProductID from the selected row using the column name for robustness
            int productId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["colProductID"].Value);

            try
            {
                dbCon.OpenConnection();
                string query = @"UPDATE Products SET ProductName=@Name, Category=@Category,
                                 Weight=@Weight, SpecialInstructions=@Instructions
                                 WHERE ProductID=@ProductID";
                SqlCommand cmd = new SqlCommand(query, dbCon.sqlConnection);
                cmd.Parameters.AddWithValue("@Name", txtProductName.Text.Trim());
                cmd.Parameters.AddWithValue("@Category", txtCategory.Text.Trim());
                cmd.Parameters.AddWithValue("@Weight", weight);
                cmd.Parameters.AddWithValue("@Instructions", txtInstructions.Text.Trim());
                cmd.Parameters.AddWithValue("@ProductID", productId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputFields(); // Clear input fields after successful update
                LoadProducts(); // Reload grid to show updated product
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbCon.CloseConnection();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected product?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return; // User chose No

            // Get ProductID from the selected row using the column name
            int productId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["colProductID"].Value);

            try
            {
                dbCon.OpenConnection();
                string query = "DELETE FROM Products WHERE ProductID=@ProductID";
                SqlCommand cmd = new SqlCommand(query, dbCon.sqlConnection);
                cmd.Parameters.AddWithValue("@ProductID", productId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputFields(); // Clear input fields after successful deletion
                LoadProducts(); // Reload grid to reflect deletion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbCon.CloseConnection();
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure a valid row is clicked (not header row or empty space)
            if (e.RowIndex >= 0 && e.RowIndex < dgvProducts.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvProducts.Rows[e.RowIndex];

                // Populate textboxes using column names for safety and readability
                txtProductName.Text = selectedRow.Cells["colProductName"].Value?.ToString() ?? string.Empty;
                txtCategory.Text = selectedRow.Cells["colCategory"].Value?.ToString() ?? string.Empty;

                // Handle potential DBNull values for Weight
                txtWeight.Text = selectedRow.Cells["colWeight"].Value != DBNull.Value ? selectedRow.Cells["colWeight"].Value.ToString() : string.Empty;

                txtInstructions.Text = selectedRow.Cells["colInstructions"].Value?.ToString() ?? string.Empty;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            LoadProducts(searchTerm);
        }

      
        private void ClearInputFields()
        {
            txtProductName.Clear();
            txtCategory.Clear();
            txtWeight.Clear();
            txtInstructions.Clear();
            txtSearch.Clear();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}