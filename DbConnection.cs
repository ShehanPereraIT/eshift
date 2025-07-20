using System;
using System.Data;
using System.Data.SqlClient;

namespace EShiftApp
{
    public class DbConnection
    {
        // Connection string to your SQL Server database
        private string connectionString = @"Server=DESKTOP-QT104GF\SQLEXPRESS;Database=eshift;Integrated Security=True;";

        // SqlConnection instance to manage the connection
        public SqlConnection sqlConnection;  // Changed from private to public

        public DbConnection()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        // Open the database connection
        public void OpenConnection()
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                    Console.WriteLine("Connection opened successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening connection: {ex.Message}");
            }
        }

        // Close the database connection
        public void CloseConnection()
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                    Console.WriteLine("Connection closed successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error closing connection: {ex.Message}");
            }
        }

        // Method to execute a SELECT query and return a DataTable
        public DataTable ExecuteQuery(string query)
        {
            DataTable resultTable = new DataTable();
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(resultTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error executing query: {ex.Message}");
            }
            return resultTable;
        }

        // Method to execute an INSERT, UPDATE, or DELETE query
        public int ExecuteNonQuery(string query)
        {
            int rowsAffected = 0;
            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                rowsAffected = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error executing non-query: {ex.Message}");
            }
            return rowsAffected;
        }

        // Method to execute a query and return a single value (e.g., COUNT, SUM)
        public object ExecuteScalar(string query)
        {
            object result = null;
            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                result = sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error executing scalar query: {ex.Message}");
            }
            return result;
        }
    }
}
