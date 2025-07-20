using e_shift;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EShiftApp
{
    public partial class AdminDashboard : Form
    {
        private DbConnection dbCon;

        public AdminDashboard()
        {
            InitializeComponent();
            dbCon = new DbConnection();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadStatistics();
            SetupCharts();
        }

        private void LoadStatistics()
        {
            try
            {
                dbCon.OpenConnection();

                string customersQuery = "SELECT COUNT(*) FROM Customers";
                string jobsQuery = "SELECT COUNT(*) FROM Jobs";
                string productsQuery = "SELECT COUNT(*) FROM Products";

                int totalCustomers = Convert.ToInt32(new SqlCommand(customersQuery, dbCon.sqlConnection).ExecuteScalar());
                int totalJobs = Convert.ToInt32(new SqlCommand(jobsQuery, dbCon.sqlConnection).ExecuteScalar());
                int totalProducts = Convert.ToInt32(new SqlCommand(productsQuery, dbCon.sqlConnection).ExecuteScalar());

                lblTotalCustomers.Text = $"Total Customers: {totalCustomers}";
                lblTotalJobs.Text = $"Total Jobs: {totalJobs}";
                lblTotalProducts.Text = $"Total Products: {totalProducts}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading statistics: " + ex.Message);
            }
            finally
            {
                dbCon.CloseConnection();
            }
        }

        private void SetupCharts()
        {
            chartStatistics.Series.Clear();
            chartStatistics.ChartAreas.Clear();
            chartStatistics.ChartAreas.Add(new ChartArea("Main"));

            var series = new Series("Overview")
            {
                ChartType = SeriesChartType.Bar,
                IsValueShownAsLabel = true
            };

            int customers = ParseLabelValue(lblTotalCustomers.Text);
            int jobs = ParseLabelValue(lblTotalJobs.Text);
            int products = ParseLabelValue(lblTotalProducts.Text);

            series.Points.AddXY("Customers", customers);
            series.Points.AddXY("Jobs", jobs);
            series.Points.AddXY("Products", products);

            chartStatistics.Series.Add(series);
        }

        private int ParseLabelValue(string label)
        {
            if (string.IsNullOrWhiteSpace(label)) return 0;
            var parts = label.Split(':');
            return parts.Length > 1 && int.TryParse(parts[1].Trim(), out int value) ? value : 0;
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            new ManageCustomers().Show();
          
        }

        private void btnManageJobs_Click(object sender, EventArgs e)
        {
            new ManageJobs().Show();
            
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            new ManageProducts().Show();
        
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            new ManageUsers().Show();
         
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            new Reports().Show();
          
        }

        private void btnTransportOperations_Click(object sender, EventArgs e)
        {
            new TransportOperations().Show();
         
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void lblTotalJobs_Click(object sender, EventArgs e) { }
    }
}
