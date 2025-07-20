using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EShiftApp
{
    public partial class Signup : Form
    {
        private DbConnection dbCon;

        public Signup()
        {
            InitializeComponent();
            dbCon = new DbConnection();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();
            string role = "Customer";

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword) ||
                string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                dbCon.OpenConnection();

                string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                SqlCommand checkCmd = new SqlCommand(checkUserQuery, dbCon.sqlConnection);
                checkCmd.Parameters.AddWithValue("@Username", username);

                int userCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (userCount > 0)
                {
                    MessageBox.Show("Username already exists.", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string insertUserQuery = @"INSERT INTO Users (Username, Password, Role, Phone, Address)
                                           VALUES (@Username, @Password, @Role, @Phone, @Address)";

                SqlCommand insertCmd = new SqlCommand(insertUserQuery, dbCon.sqlConnection);
                insertCmd.Parameters.AddWithValue("@Username", username);
                insertCmd.Parameters.AddWithValue("@Password", password);
                insertCmd.Parameters.AddWithValue("@Role", role);
                insertCmd.Parameters.AddWithValue("@Phone", phone);
                insertCmd.Parameters.AddWithValue("@Address", address);

                int rows = insertCmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Registration successful! Please log in.", "Signup Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    Login login = new Login();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Signup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbCon.CloseConnection();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLoginRedirect_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Signup_Load(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e) { }
    }
}
