using e_shift;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EShiftApp
{
    public partial class CustomerDashboard : Form
    {
        private readonly DbConnection dbCon;
        private readonly int userId;

        public CustomerDashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            dbCon = new DbConnection();
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            LoadStatistics();
            LoadOngoingJobs();
            SetupCharts();
        }

        private void LoadStatistics()
        {
            int totalJobs = 0;
            int ongoingJobs = 0;

            try
            {
                dbCon.OpenConnection();

                string totalQuery = "SELECT COUNT(*) FROM Jobs WHERE CustomerID = @CustomerID";
                using (var cmd = new SqlCommand(totalQuery, dbCon.sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", userId);
                    totalJobs = Convert.ToInt32(cmd.ExecuteScalar());
                }

                string ongoingQuery = @"SELECT COUNT(*) FROM Jobs 
                                        WHERE CustomerID = @CustomerID 
                                        AND Status IN ('Pending', 'Proceed', 'Delivering', 'Nearby')";
                using (var cmd = new SqlCommand(ongoingQuery, dbCon.sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", userId);
                    ongoingJobs = Convert.ToInt32(cmd.ExecuteScalar());
                }

                lblTotalJobs.Text = $"Total Jobs: {totalJobs}";
                lblOngoingJobs.Text = $"Ongoing Jobs: {ongoingJobs}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load statistics: " + ex.Message);
            }
            finally
            {
                dbCon.CloseConnection();
            }
        }

        private void LoadOngoingJobs()
        {
            lstOngoingJobs.Items.Clear();

            try
            {
                dbCon.OpenConnection();

                string query = @"SELECT JobID, StartLocation, EndLocation, Status 
                                 FROM Jobs 
                                 WHERE CustomerID = @CustomerID 
                                 AND Status IN ('Pending', 'Proceed', 'Delivering', 'Nearby')";
                using (var cmd = new SqlCommand(query, dbCon.sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", userId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string jobDetails = $"Job ID: {reader["JobID"]}, Start: {reader["StartLocation"]}, End: {reader["EndLocation"]}, Status: {reader["Status"]}";
                            lstOngoingJobs.Items.Add(jobDetails);
                        }
                    }
                }
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

        private void SetupCharts()
        {
            chartStatistics.Series.Clear();

            int total = TryParseLabelValue(lblTotalJobs.Text);
            int ongoing = TryParseLabelValue(lblOngoingJobs.Text);
            int completed = Math.Max(0, total - ongoing);

            var series = new Series("Jobs")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true
            };

            series.Points.AddXY("Ongoing", ongoing);
            series.Points.AddXY("Completed", completed);

            chartStatistics.Series.Add(series);
        }

        private int TryParseLabelValue(string labelText)
        {
            if (string.IsNullOrWhiteSpace(labelText)) return 0;
            string[] parts = labelText.Split(':');
            return parts.Length == 2 && int.TryParse(parts[1].Trim(), out int value) ? value : 0;
        }

        private void btnPlaceJob_Click(object sender, EventArgs e)
        {
            var placeJobForm = new PlaceJobs(userId);
            placeJobForm.FormClosed += (s, args) =>
            {
                LoadStatistics();
                LoadOngoingJobs();
                SetupCharts();
            };
            placeJobForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void lblTotalJobs_Click(object sender, EventArgs e) { }

        private void chartStatistics_Click(object sender, EventArgs e) { }
    }
}
