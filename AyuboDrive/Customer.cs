using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive
{

    class Customer
    {
        public int CustomerID { get; }
        private string FirstName { get; }
        private string LastName { get; }
        private string ContactNumber { get; }
        private const string connectionString = @"Data Source=DESKTOP-0CECDCR;Initial Catalog=AyuboDriveV1;Integrated Security=True";

        public Customer(int customerID, string firstName, string lastName, string contactNumber)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            ContactNumber = contactNumber;
        }

        public static bool RegisterCustomer(string firstName, string lastName, string contactNumber)
        {
            string query = "INSERT INTO Customer VALUES(@customerID, @firstName, @lastName, @contactNumber)";

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@customerID", 8);
                    sqlCommand.Parameters.AddWithValue("@firstName", firstName);
                    sqlCommand.Parameters.AddWithValue("@lastName", lastName);
                    sqlCommand.Parameters.AddWithValue("@contactNumber", contactNumber);
                    sqlCommand.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e}", "An error occurred when updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static bool UpdateCustomer(int customerID, string firstName, string lastName, string contactNumber)
        {
            string query = "UPDATE Customer SET firstName = @firstName, lastName = @lastName, contactNumber = " +
                "@contactNumber WHERE customerID = @customerID";
            
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@customerID", customerID);
                    sqlCommand.Parameters.AddWithValue("@firstName", firstName);
                    sqlCommand.Parameters.AddWithValue("@lastName", lastName);
                    sqlCommand.Parameters.AddWithValue("@contactNumber", contactNumber);
                    sqlCommand.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e}", "An error occurred when updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static bool DeleteCustomer(int customerID)
        {
            string query = "DELETE FROM Customer WHERE customerID = @customerID";

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@customerID", customerID);
                    sqlCommand.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e}", "An error occurred when deleting", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
