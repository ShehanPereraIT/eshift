using e_shift;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EShiftApp
{
    public partial class Login : Form
    {
        private DbConnection dbCon;

        public Login()
        {
            InitializeComponent();
            dbCon = new DbConnection();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dbCon.OpenConnection();

                // Get user role and ID
                string loginQuery = "SELECT Role, UserID FROM Users WHERE Username = @Username AND Password = @Password";
                SqlCommand cmd = new SqlCommand(loginQuery, dbCon.sqlConnection);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string role = reader["Role"].ToString();
                    int userId = Convert.ToInt32(reader["UserID"]);
                    reader.Close();

                    if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                    {
                        AdminDashboard adminDashboard = new AdminDashboard();
                        adminDashboard.Show();
                        this.Hide();
                    }
                    else if (role.Equals("Customer", StringComparison.OrdinalIgnoreCase))
                    {
                        CustomerDashboard customerDashboard = new CustomerDashboard(userId); // Pass userId
                        customerDashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Unrecognized user role.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbCon.CloseConnection();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            Signup signUpForm = new Signup();
            signUpForm.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e) { }
    }
}
