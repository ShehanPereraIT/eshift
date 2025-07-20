using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EShiftApp
{
    public partial class TransportOperations : Form
    {
        private DbConnection dbCon; // Assuming DbConnection is a class you have defined for database operations.

        public TransportOperations()
        {
            InitializeComponent();
            dbCon = new DbConnection();
            // Crucial: Set AutoGenerateColumns to false if you are defining columns in the designer.
            // This prevents the DataGridView from automatically creating columns when data is loaded,
            // which would cause conflicts with your pre-defined columns.
            dgvTransport.AutoGenerateColumns = false;
        }

        private void TransportOperations_Load(object sender, EventArgs e)
        {
            // You could optionally add column definitions here programmatically
            // if you prefer not to use the designer. For example:
            /*
            dgvTransport.Columns.Clear();
            dgvTransport.Columns.Add("colTransportID", "Transport ID");
            dgvTransport.Columns.Add("colDriverName", "Driver Name");
            dgvTransport.Columns.Add("colVehicle", "Vehicle");
            dgvTransport.Columns.Add("colVehicleNo", "Vehicle No");
            dgvTransport.Columns.Add("colAvailability", "Availability");
            dgvTransport.Columns.Add("colWeightCapacity", "Weight Capacity");
            dgvTransport.Columns.Add("colPricePerKM", "Price Per KM");
            foreach (DataGridViewColumn col in dgvTransport.Columns)
            {
                col.ReadOnly = true;
            }
            */

            LoadTransports();

            // Populate cmbAvailability if not done in designer
            if (cmbAvailability.Items.Count == 0)
            {
                cmbAvailability.Items.AddRange(new string[] { "Available", "Unavailable", "On Trip", "Maintenance" });
                cmbAvailability.SelectedIndex = 0; // Set a default selected item
            }
        }

        private void LoadTransports(string search = "")
        {
            dgvTransport.Rows.Clear(); // Clear existing rows before loading new ones
            try
            {
                dbCon.OpenConnection();

                // It's good practice to explicitly list columns rather than using SELECT *
                string query = "SELECT TransportID, DriverName, Vehicle, VehicleNo, Availability, WeightCapacity, PricePerKM FROM Transport WHERE DriverName LIKE @search OR VehicleNo LIKE @search";
                SqlCommand cmd = new SqlCommand(query, dbCon.sqlConnection);
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Ensure the order of adding values matches the order of columns defined
                    // in your DataGridView (either in the designer or programmatically).
                    dgvTransport.Rows.Add(
                        reader["TransportID"],
                        reader["DriverName"],
                        reader["Vehicle"],
                        reader["VehicleNo"],
                        reader["Availability"],
                        reader["WeightCapacity"],
                        reader["PricePerKM"]
                    );
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transports: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbCon.CloseConnection();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadTransports(txtSearch.Text.Trim());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Input Validation
            if (string.IsNullOrWhiteSpace(txtDriverName.Text) ||
                string.IsNullOrWhiteSpace(txtVehicle.Text) ||
                string.IsNullOrWhiteSpace(txtVehicleNo.Text) ||
                cmbAvailability.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtWeightCapacity.Text) ||
                string.IsNullOrWhiteSpace(txtPricePerKM.Text))
            {
                MessageBox.Show("Please fill in all transport details.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtWeightCapacity.Text, out decimal weightCapacity))
            {
                MessageBox.Show("Weight Capacity must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWeightCapacity.Focus();
                return;
            }

            if (!decimal.TryParse(txtPricePerKM.Text, out decimal pricePerKm))
            {
                MessageBox.Show("Price Per KM must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPricePerKM.Focus();
                return;
            }

            try
            {
                dbCon.OpenConnection();
                string query = "INSERT INTO Transport (DriverName, Vehicle, VehicleNo, Availability, WeightCapacity, PricePerKM) " +
                               "VALUES (@DriverName, @Vehicle, @VehicleNo, @Availability, @WeightCapacity, @PricePerKM)";
                SqlCommand cmd = new SqlCommand(query, dbCon.sqlConnection);
                cmd.Parameters.AddWithValue("@DriverName", txtDriverName.Text.Trim());
                cmd.Parameters.AddWithValue("@Vehicle", txtVehicle.Text.Trim());
                cmd.Parameters.AddWithValue("@VehicleNo", txtVehicleNo.Text.Trim());
                cmd.Parameters.AddWithValue("@Availability", cmbAvailability.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@WeightCapacity", weightCapacity); // Use parsed decimal
                cmd.Parameters.AddWithValue("@PricePerKM", pricePerKm);     // Use parsed decimal
                cmd.ExecuteNonQuery();

                MessageBox.Show("Transport added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputFields(); // Clear fields after adding
                LoadTransports(); // Reload grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding transport: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbCon.CloseConnection();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvTransport.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Input Validation
            if (string.IsNullOrWhiteSpace(txtDriverName.Text) ||
                string.IsNullOrWhiteSpace(txtVehicle.Text) ||
                string.IsNullOrWhiteSpace(txtVehicleNo.Text) ||
                cmbAvailability.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtWeightCapacity.Text) ||
                string.IsNullOrWhiteSpace(txtPricePerKM.Text))
            {
                MessageBox.Show("Please fill in all transport details for update.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtWeightCapacity.Text, out decimal weightCapacity))
            {
                MessageBox.Show("Weight Capacity must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWeightCapacity.Focus();
                return;
            }

            if (!decimal.TryParse(txtPricePerKM.Text, out decimal pricePerKm))
            {
                MessageBox.Show("Price Per KM must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPricePerKM.Focus();
                return;
            }

            // Get TransportID from the selected row using the column name for robustness
            // Assuming your first column is named "colTransportID" in the designer.
            int transportId = Convert.ToInt32(dgvTransport.SelectedRows[0].Cells["colTransportID"].Value);

            try
            {
                dbCon.OpenConnection();
                string query = "UPDATE Transport SET DriverName = @DriverName, Vehicle = @Vehicle, VehicleNo = @VehicleNo, " +
                               "Availability = @Availability, WeightCapacity = @WeightCapacity, PricePerKM = @PricePerKM WHERE TransportID = @TransportID";
                SqlCommand cmd = new SqlCommand(query, dbCon.sqlConnection);
                cmd.Parameters.AddWithValue("@DriverName", txtDriverName.Text.Trim());
                cmd.Parameters.AddWithValue("@Vehicle", txtVehicle.Text.Trim());
                cmd.Parameters.AddWithValue("@VehicleNo", txtVehicleNo.Text.Trim());
                cmd.Parameters.AddWithValue("@Availability", cmbAvailability.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@WeightCapacity", weightCapacity);
                cmd.Parameters.AddWithValue("@PricePerKM", pricePerKm);
                cmd.Parameters.AddWithValue("@TransportID", transportId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Transport updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputFields(); // Clear fields after updating
                LoadTransports(); // Reload grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating transport: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbCon.CloseConnection();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTransport.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected transport record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return; // User chose No

            // Get TransportID from the selected row using the column name
            int transportId = Convert.ToInt32(dgvTransport.SelectedRows[0].Cells["colTransportID"].Value);

            try
            {
                dbCon.OpenConnection();
                string query = "DELETE FROM Transport WHERE TransportID = @TransportID";
                SqlCommand cmd = new SqlCommand(query, dbCon.sqlConnection);
                cmd.Parameters.AddWithValue("@TransportID", transportId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Transport deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputFields(); // Clear fields after deletion
                LoadTransports(); // Reload grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting transport: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbCon.CloseConnection();
            }
        }

        private void dgvTransport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure a valid row is clicked (not header row or empty space)
            if (e.RowIndex >= 0 && e.RowIndex < dgvTransport.Rows.Count)
            {
                DataGridViewRow row = dgvTransport.Rows[e.RowIndex];

                // Populate textboxes using column names for safety and readability
                // Replace "colColumnName" with the actual names you gave your DataGridView columns in the designer.
                // If you used default names like "Column1", "Column2", etc., you would use those.
                // It's highly recommended to use descriptive names.
                txtDriverName.Text = row.Cells["colDriverName"].Value?.ToString() ?? string.Empty;
                txtVehicle.Text = row.Cells["colVehicle"].Value?.ToString() ?? string.Empty;
                txtVehicleNo.Text = row.Cells["colVehicleNo"].Value?.ToString() ?? string.Empty;
                cmbAvailability.SelectedItem = row.Cells["colAvailability"].Value?.ToString(); // Set selected item directly

                // Handle potential DBNull values for numeric fields
                txtWeightCapacity.Text = row.Cells["colWeightCapacity"].Value != DBNull.Value ? row.Cells["colWeightCapacity"].Value.ToString() : string.Empty;
                txtPricePerKM.Text = row.Cells["colPricePerKM"].Value != DBNull.Value ? row.Cells["colPricePerKM"].Value.ToString() : string.Empty;
            }
        }

        // Helper method to clear all input fields on the form
        private void ClearInputFields()
        {
            txtDriverName.Clear();
            txtVehicle.Clear();
            txtVehicleNo.Clear();
            cmbAvailability.SelectedIndex = -1; // Deselect any item
            txtWeightCapacity.Clear();
            txtPricePerKM.Clear();
            txtSearch.Clear(); // Clear search box too
        }

        private void dgvTransport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // This event fires when content within a cell (like a button or checkbox) is clicked.
            // For general row selection, dgvTransport_CellClick is usually more appropriate.
        }
    }
}