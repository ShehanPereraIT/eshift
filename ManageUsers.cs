using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EShiftApp
{
    public partial class ManageUsers : Form
    {
        private DbConnection dbCon;
        private int selectedUserId = -1;

        public ManageUsers()
        {
            InitializeComponent();
            dbCon = new DbConnection();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            dbCon.OpenConnection();
            string query = "SELECT * FROM Users";
            SqlDataAdapter adapter = new SqlDataAdapter(query, dbCon.sqlConnection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvUsers.DataSource = table;
            dbCon.CloseConnection();
        }

        private void ClearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = -1;
            txtPhone.Clear();
            txtAddress.Clear();
            selectedUserId = -1;
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

                selectedUserId = Convert.ToInt32(row.Cells["UserID"].Value);
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
                cmbRole.Text = row.Cells["Role"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || cmbRole.Text == "" || txtPhone.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            dbCon.OpenConnection();
            string query = "INSERT INTO Users (Username, Password, Role, Phone, Address) VALUES (@Username, @Password, @Role, @Phone, @Address)";
            SqlCommand cmd = new SqlCommand(query, dbCon.sqlConnection);
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@Role", cmbRole.Text);
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.ExecuteNonQuery();
            dbCon.CloseConnection();

            MessageBox.Show("User added successfully.");
            LoadUsers();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }

            dbCon.OpenConnection();
            string query = "UPDATE Users SET Username=@Username, Password=@Password, Role=@Role, Phone=@Phone, Address=@Address WHERE UserID=@UserID";
            SqlCommand cmd = new SqlCommand(query, dbCon.sqlConnection);
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@Role", cmbRole.Text);
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@UserID", selectedUserId);
            cmd.ExecuteNonQuery();
            dbCon.CloseConnection();

            MessageBox.Show("User updated successfully.");
            LoadUsers();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                dbCon.OpenConnection();
                string query = "DELETE FROM Users WHERE UserID=@UserID";
                SqlCommand cmd = new SqlCommand(query, dbCon.sqlConnection);
                cmd.Parameters.AddWithValue("@UserID", selectedUserId);
                cmd.ExecuteNonQuery();
                dbCon.CloseConnection();

                MessageBox.Show("User deleted successfully.");
                LoadUsers();
                ClearFields();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            dbCon.OpenConnection();
            string query = "SELECT * FROM Users WHERE Username LIKE @Keyword OR Role LIKE @Keyword OR Phone LIKE @Keyword";
            SqlCommand cmd = new SqlCommand(query, dbCon.sqlConnection);
            cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvUsers.DataSource = table;

            dbCon.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
