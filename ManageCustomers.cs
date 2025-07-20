using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EShiftApp
{
    public partial class ManageCustomers : Form
    {
        private DbConnection dbCon;

        public ManageCustomers()
        {
            InitializeComponent();
            dbCon = new DbConnection();
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers(string search = "")
        {
            try
            {
                dbCon.OpenConnection();
                string query = "SELECT * FROM Users WHERE Role = 'Customer' AND (Username LIKE @Search OR Phone LIKE @Search OR Address LIKE @Search)";
                SqlCommand cmd = new SqlCommand(query, dbCon.sqlConnection);
                cmd.Parameters.AddWithValue("@Search", $"%{search}%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCustomers.DataSource = dt;
            }
            finally
            {
                dbCon.CloseConnection();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                dbCon.OpenConnection();
                string query = @"INSERT INTO Users (Username, Password, Role, Phone, Address) 
                                 VALUES (@Username, @Password, 'Customer', @Phone, @Address)";
                SqlCommand cmd = new SqlCommand(query, dbCon.sqlConnection);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer added successfully.");
                LoadCustomers();
            }
            finally
            {
                dbCon.CloseConnection();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["UserID"].Value);
                try
                {
                    dbCon.OpenConnection();
                    string query = @"UPDATE Users SET Username = @Username, Password = @Password, 
                                     Phone = @Phone, Address = @Address WHERE UserID = @UserID";
                    SqlCommand cmd = new SqlCommand(query, dbCon.sqlConnection);
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer updated successfully.");
                    LoadCustomers();
                }
                finally
                {
                    dbCon.CloseConnection();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["UserID"].Value);
                DialogResult result = MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        dbCon.OpenConnection();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE UserID = @UserID", dbCon.sqlConnection);
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer deleted.");
                        LoadCustomers();
                    }
                    finally
                    {
                        dbCon.CloseConnection();
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadCustomers(txtSearch.Text.Trim());
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtUsername.Text = dgvCustomers.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                txtPassword.Text = dgvCustomers.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                txtPhone.Text = dgvCustomers.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                txtAddress.Text = dgvCustomers.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            }
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
