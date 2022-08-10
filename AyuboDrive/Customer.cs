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
        public string CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        private static QueryHandler queryHandler = new QueryHandler();

        public Customer(string customerID, string firstName, string lastName, string contactNumber)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            ContactNumber = contactNumber;
        }

        //public void RegisterCustomer(string firstName, string lastName, string contactNumber)
        //{
        //    string query = "INSERT INTO Customer VALUES(@customerID, @firstName, @lastName, @contactNumber)";
        //    string[] parameters = {"@customerID", "@firstName", "@lastName", "@contactNumber"};
        //    object[] values = {CustomerID, FirstName, LastName, ContactNumber};

        //    if (queryHandler.HandleInsertDeleteUpdateQuery(query, parameters, values))
        //    {
        //        MessageBox.Show($"Details successfully inserted", "Insert successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    } else
        //    {
        //        MessageBox.Show("Query execution failed", "nsert failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        /// <summary>
        /// The <c>RegisterCustomer</c> method is responsible for registering a 
        /// new customer into the database
        /// </summary>
        /// <param name="firstName">The customer's first name</param>
        /// <param name="lastName">The customer's last name</param>
        /// <param name="contactNumber">The customer's contact number</param>
        /// <returns>An initialized Customer object</returns>
        public static Customer RegisterCustomer(string firstName, string lastName, string contactNumber)
        {
            string customerID = "";
            string query = "INSERT INTO Customer VALUES(@customerID, @firstName, @lastName, @contactNumber)";
            string[] parameters = { "@customerID", "@firstName", "@lastName", "@contactNumber" };
            object[] values = { customerID, firstName, lastName, contactNumber };

            if (queryHandler.HandleInsertDeleteUpdateQuery(query, parameters, values))
            {
                MessageBox.Show($"Details successfully inserted", "Insert successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return new Customer(customerID, firstName, lastName, contactNumber);
            }
            MessageBox.Show("Query execution failed", "nsert failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        public void UpdateCustomer(string customerID, string firstName, string lastName, string contactNumber)
        {
            string query = "UPDATE Customer SET firstName = @firstName, lastName = @lastName, contactNumber = " +
                "@contactNumber WHERE customerID = @customerID";
            
            string[] parameters = { "@firstName", "@lastName", "@contactNumber", "customerID" };
            object[] values = { CustomerID, FirstName, LastName, ContactNumber };

            if (queryHandler.HandleInsertDeleteUpdateQuery(query, parameters, values))
            {
                UpdateObject(customerID, firstName, lastName, contactNumber);
                MessageBox.Show($"Details successfully updated", "Update successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Query execution failed", "Update failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteCustomer(int customerID)
        {
            string query = "DELETE FROM Customer WHERE customerID = @customerID";
            string[] parameters = { "customerID" };
            object[] values = { customerID };

            if (queryHandler.HandleInsertDeleteUpdateQuery(query, parameters, values))
            {
                MessageBox.Show($"Details successfully deleted", "Delete successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Query execution failed", "Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateObject(string customerID, string firstName, string lastName, string contactNumber)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            ContactNumber = contactNumber;
        }
    }
}
