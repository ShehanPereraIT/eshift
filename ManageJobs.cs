using Newtonsoft.Json.Linq;
using System;
using System.Data.SqlClient;
using System.Net;
using System.Windows.Forms;

namespace EShiftApp
{
    public partial class ManageJobs : Form
    {
        private DbConnection dbCon;

        public ManageJobs()
        {
            InitializeComponent();
            dbCon = new DbConnection();
        }

        private void ManageJobs_Load(object sender, EventArgs e)
        {
            // Adding sample Sri Lankan city names to dropdowns for Start and End Locations
            LoadCities();
            cmbStatus.Items.AddRange(new string[] { "Pending", "Proceed", "Delivering", "Nearby", "Delivered" });
            LoadJobs();
        }

        private void LoadCities()
        {
            var cities = new[] { "Colombo", "Kandy", "Galle", "Jaffna", "Negombo", "Matara", "Batticaloa", "Trincomalee", "Anuradhapura", "Kurunegala" };
            cmbStartLocation.Items.AddRange(cities);
            cmbEndLocation.Items.AddRange(cities);
        }

        private void LoadJobs(string searchQuery = "")
        {
            try
            {
                dbCon.OpenConnection();
                string query = @"
                    SELECT j.JobID, j.StartLocation, j.EndLocation, j.Status, j.Distance,
                           u.Username AS CustomerName, u.Phone, u.Address
                    FROM Jobs j
                    INNER JOIN Users u ON j.CustomerID = u.UserID
                    WHERE j.StartLocation LIKE @Search OR j.EndLocation LIKE @Search";

                SqlCommand cmd = new SqlCommand(query, dbCon.sqlConnection);
                cmd.Parameters.AddWithValue("@Search", "%" + searchQuery + "%");

                SqlDataReader reader = cmd.ExecuteReader();
                dgvJobs.Rows.Clear();

                while (reader.Read())
                {
                    dgvJobs.Rows.Add(
                        reader["JobID"],
                        reader["StartLocation"],
                        reader["EndLocation"],
                        reader["Status"],
                        reader["Distance"],
                        reader["CustomerName"],
                        reader["Phone"],
                        reader["Address"]
                    );
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading jobs: " + ex.Message);
            }
            finally
            {
                dbCon.CloseConnection();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadJobs(txtSearch.Text.Trim());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dgvJobs.SelectedRows.Count == 0 || cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Select a job and a new status.");
                return;
            }

            try
            {
                int jobId = Convert.ToInt32(dgvJobs.SelectedRows[0].Cells["JobID"].Value);
                string newStatus = cmbStatus.SelectedItem.ToString();

                dbCon.OpenConnection();
                string query = "UPDATE Jobs SET Status = @Status WHERE JobID = @JobID";
                SqlCommand cmd = new SqlCommand(query, dbCon.sqlConnection);
                cmd.Parameters.AddWithValue("@Status", newStatus);
                cmd.Parameters.AddWithValue("@JobID", jobId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Job status updated.");
                LoadJobs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating job: " + ex.Message);
            }
            finally
            {
                dbCon.CloseConnection();
            }
        }

        private void btnDeleteJob_Click(object sender, EventArgs e)
        {
            if (dgvJobs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a job to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Delete selected job?", "Confirm", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;

            try
            {
                int jobId = Convert.ToInt32(dgvJobs.SelectedRows[0].Cells["JobID"].Value);

                dbCon.OpenConnection();
                string query = "DELETE FROM Jobs WHERE JobID = @JobID";
                SqlCommand cmd = new SqlCommand(query, dbCon.sqlConnection);
                cmd.Parameters.AddWithValue("@JobID", jobId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Job deleted.");
                LoadJobs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting job: " + ex.Message);
            }
            finally
            {
                dbCon.CloseConnection();
            }
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            string start = cmbStartLocation.SelectedItem?.ToString();
            string end = cmbEndLocation.SelectedItem?.ToString();
            string instructions = txtInstruction.Text.Trim();

            if (string.IsNullOrEmpty(start) || string.IsNullOrEmpty(end) || cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Please complete all fields.");
                return;
            }

            try
            {
                double distance = GetDistanceBetweenLocations(start, end);
                if (distance < 0)
                {
                    MessageBox.Show("Failed to retrieve distance.");
                    return;
                }

                dbCon.OpenConnection();

                decimal pricePerKm = 0;
                string transportQuery = "SELECT TOP 1 TransportID, PricePerKm FROM Transport WHERE Availability = 'Available'";
                SqlCommand transportCmd = new SqlCommand(transportQuery, dbCon.sqlConnection);
                SqlDataReader transportReader = transportCmd.ExecuteReader();

                int transportId = 0;
                if (transportReader.Read())
                {
                    transportId = Convert.ToInt32(transportReader["TransportID"]);
                    pricePerKm = Convert.ToDecimal(transportReader["PricePerKm"]);
                }
                transportReader.Close();

                decimal totalPrice = Math.Round((decimal)distance * pricePerKm, 2);

                string insertQuery = @"INSERT INTO Jobs (StartLocation, EndLocation, Status, CustomerID, Distance, TransportID, TotalPrice, Instruction)
                                      VALUES (@Start, @End, @Status, @CustomerID, @Distance, @TransportID, @TotalPrice, @Instruction)";

                SqlCommand cmd = new SqlCommand(insertQuery, dbCon.sqlConnection);
                cmd.Parameters.AddWithValue("@Start", start);
                cmd.Parameters.AddWithValue("@End", end);
                cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(txtCustomerID.Text));
                cmd.Parameters.AddWithValue("@Distance", distance);
                cmd.Parameters.AddWithValue("@TransportID", transportId);
                cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                cmd.Parameters.AddWithValue("@Instruction", instructions);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Job added successfully.");
                LoadJobs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding job: " + ex.Message);
            }
            finally
            {
                dbCon.CloseConnection();
            }
        }

        private void btnPickStartLocation_Click(object sender, EventArgs e)
        {
            using (MapSelectorForm mapForm = new MapSelectorForm())
            {
                if (mapForm.ShowDialog() == DialogResult.OK)
                {
                    cmbStartLocation.Text = mapForm.SelectedAddress;
                }
            }
        }

        private void btnPickEndLocation_Click(object sender, EventArgs e)
        {
            using (MapSelectorForm mapForm = new MapSelectorForm())
            {
                if (mapForm.ShowDialog() == DialogResult.OK)
                {
                    cmbEndLocation.Text = mapForm.SelectedAddress;
                }
            }
        }

        private double GetDistanceBetweenLocations(string origin, string destination)
        {
            try
            {
                string apiKey = "AIzaSyAjrH9dZQq0VJ-NhstQ8OBhLCFaJdkBtlI";
                string url = $"https://maps.googleapis.com/maps/api/distancematrix/json?origins={Uri.EscapeDataString(origin)}&destinations={Uri.EscapeDataString(destination)}&key={apiKey}";

                using (WebClient client = new WebClient())
                {
                    string json = client.DownloadString(url);
                    JObject result = JObject.Parse(json);

                    string status = result["rows"]?[0]?["elements"]?[0]?["status"]?.ToString();
                    if (status == "OK")
                    {
                        double meters = (double)result["rows"][0]["elements"][0]["distance"]["value"];
                        return Math.Round(meters / 1000.0, 2);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching distance: " + ex.Message);
            }

            return -1;
        }

        // Define the event handler for dgvJobs_CellContentClick
        private void dgvJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // You can implement the functionality for when a cell is clicked in the DataGridView here
            // For example, you might want to display the details of the selected job
        }

        private void txtInstruction_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
