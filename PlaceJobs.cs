using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net;

namespace EShiftApp
{
    public partial class PlaceJobs : Form
    {
        private readonly DbConnection dbCon;
        private readonly int userId;

        public PlaceJobs(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            dbCon = new DbConnection();
        }

        private void PlaceJobs_Load(object sender, EventArgs e)
        {
            LoadTransports();
            LoadSriLankanCities();
        }

        // Populate Transport dropdown with available transport vehicles
        private void LoadTransports()
        {
            try
            {
                dbCon.OpenConnection();
                string query = "SELECT TransportID, Vehicle FROM Transport WHERE Availability = 'Available'";
                SqlCommand cmd = new SqlCommand(query, dbCon.sqlConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbTransport.Items.Add(new ComboBoxItem
                    {
                        Text = reader["Vehicle"].ToString(),
                        Value = reader["TransportID"].ToString()
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transports: " + ex.Message);
            }
            finally
            {
                dbCon.CloseConnection();
            }
        }

        // Populate the dropdowns with Sri Lankan city names
        private void LoadSriLankanCities()
        {
            var cities = new[] {
                "Colombo", "Kandy", "Galle", "Jaffna", "Anuradhapura", "Matara", "Negombo", "Trincomalee", "Batticaloa", "Kurunegala"
            };

            cmbStartLocation.Items.AddRange(cities);
            cmbEndLocation.Items.AddRange(cities);
        }

        // Handle the submit button click
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string start = cmbStartLocation.SelectedItem.ToString();
            string end = cmbEndLocation.SelectedItem.ToString();
            string instructions = txtInstructions.Text.Trim();
            string transportId = ((ComboBoxItem)cmbTransport.SelectedItem)?.Value;

            if (string.IsNullOrEmpty(start) || string.IsNullOrEmpty(end) || transportId == null)
            {
                MessageBox.Show("Please complete all required fields.");
                return;
            }

            // Get distance between the selected locations using Google Maps API
            double distance = GetDistanceBetweenLocations(start, end);

            if (distance < 0)
            {
                MessageBox.Show("Failed to retrieve distance.");
                return;
            }

            try
            {
                dbCon.OpenConnection();
                string getPriceQuery = "SELECT PricePerKM FROM Transport WHERE TransportID = @TransportID";
                SqlCommand priceCmd = new SqlCommand(getPriceQuery, dbCon.sqlConnection);
                priceCmd.Parameters.AddWithValue("@TransportID", transportId);
                decimal pricePerKm = (decimal)priceCmd.ExecuteScalar();
                decimal totalPrice = pricePerKm * (decimal)distance;

                string insertQuery = @"INSERT INTO Jobs (CustomerID, StartLocation, EndLocation, Distance, Status, TransportID, TotalPrice, Instruction)
                                       VALUES (@CustomerID, @Start, @End, @Distance, 'Pending', @TransportID, @TotalPrice, @Instruction)";

                SqlCommand cmd = new SqlCommand(insertQuery, dbCon.sqlConnection);
                cmd.Parameters.AddWithValue("@CustomerID", userId);
                cmd.Parameters.AddWithValue("@Start", start);
                cmd.Parameters.AddWithValue("@End", end);
                cmd.Parameters.AddWithValue("@Distance", distance);
                cmd.Parameters.AddWithValue("@TransportID", transportId);
                cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                cmd.Parameters.AddWithValue("@Instruction", instructions);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Job placed successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error placing job: " + ex.Message);
            }
            finally
            {
                dbCon.CloseConnection();
            }
        }

        // Get the distance between two locations using Google Maps API
        private double GetDistanceBetweenLocations(string origin, string destination)
        {
            try
            {
                string apiKey = "AIzaSyAjrH9dZQq0VJ-NhstQ8OBhLCFaJdkBtlI"; // Replace with your actual Google Maps API key
                string url = $"https://maps.googleapis.com/maps/api/distancematrix/json?origins={Uri.EscapeDataString(origin)}&destinations={Uri.EscapeDataString(destination)}&key={apiKey}";

                using (WebClient client = new WebClient())
                {
                    string json = client.DownloadString(url);
                    JObject result = JObject.Parse(json);

                    string status = result["rows"]?[0]?["elements"]?[0]?["status"]?.ToString();
                    if (status == "OK")
                    {
                        double meters = (double)result["rows"][0]["elements"][0]["distance"]["value"];
                        return Math.Round(meters / 1000.0, 2); // return kilometers
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching distance: " + ex.Message);
            }

            return -1;
        }

        // Handle start location pick button
        private void btnPickStart_Click(object sender, EventArgs e)
        {
            using (MapSelectorForm mapForm = new MapSelectorForm())
            {
                if (mapForm.ShowDialog() == DialogResult.OK)
                {
                    cmbStartLocation.SelectedItem = mapForm.SelectedAddress;
                }
            }
        }

        // Handle end location pick button
        private void btnPickEnd_Click(object sender, EventArgs e)
        {
            using (MapSelectorForm mapForm = new MapSelectorForm())
            {
                if (mapForm.ShowDialog() == DialogResult.OK)
                {
                    cmbEndLocation.SelectedItem = mapForm.SelectedAddress;
                }
            }
        }

        private void txtInstructions_TextChanged(object sender, EventArgs e)
        {

        }
    }

    // Class for handling ComboBox items with both Text and Value
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public override string ToString() => Text;
    }
}
