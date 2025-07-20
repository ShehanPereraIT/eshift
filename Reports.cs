using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EShiftApp
{
    public partial class Reports : Form
    {
        private readonly DbConnection dbCon;

        public Reports()
        {
            InitializeComponent();
            dbCon = new DbConnection();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // Optional: Default data on load
        }

        private void btnDownloadSelectedJob_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a job row to download.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int jobId = Convert.ToInt32(dgvData.SelectedRows[0].Cells["JobID"].Value);
            LoadJobById(jobId);
        }

        private void btnDownloadAllCustomers_Click(object sender, EventArgs e)
        {
            LoadDataIntoGrid("SELECT UserID, Username, Role, Phone, Address FROM Users WHERE Role = 'Customer'");
        }

        private void btnDownloadAllJobs_Click(object sender, EventArgs e)
        {
            LoadDataIntoGrid(@"SELECT j.JobID, j.StartLocation, j.EndLocation, j.Distance, j.Status, 
                                      j.TotalPrice, j.Vehicle, j.Category, j.Instruction, u.Username AS Customer 
                               FROM Jobs j
                               INNER JOIN Users u ON j.CustomerID = u.UserID");
        }

        private void btnDownloadAllTransport_Click(object sender, EventArgs e)
        {
            LoadDataIntoGrid("SELECT TransportID, DriverName, Vehicle, VehicleNo, Availability, WeightCapacity, PricePerKM FROM Transport");
        }

        private void LoadJobById(int jobId)
        {
            string query = @"SELECT j.JobID, j.StartLocation, j.EndLocation, j.Distance, j.Status,
                                    j.TotalPrice, j.Vehicle, j.Category, j.Instruction, u.Username AS Customer 
                             FROM Jobs j
                             INNER JOIN Users u ON j.CustomerID = u.UserID
                             WHERE j.JobID = @JobID";

            try
            {
                dbCon.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, dbCon.sqlConnection);
                cmd.Parameters.AddWithValue("@JobID", jobId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading job data: " + ex.Message);
            }
            finally
            {
                dbCon.CloseConnection();
            }
        }

        private void LoadDataIntoGrid(string query)
        {
            try
            {
                dbCon.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(query, dbCon.sqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                dbCon.CloseConnection();
            }
        }
    }
}
