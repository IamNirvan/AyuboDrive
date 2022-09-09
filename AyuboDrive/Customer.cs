using AyuboDrive.Interfaces;
using AyuboDrive.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive
{
    /// <summary>
    /// Represents a customer. It houses methods that can be used to insert, delete 
    /// and update customer information in the customer table.
    /// </summary>
    class Customer : IDatabaseManipulator
    {
        private string _customerNIC { get; set; }
        private string _firstName { get; set; }
        private string _lastName { get; set; }
        private string _contactNumber { get; set; }
        private static QueryHandler _queryHandler = new QueryHandler();

        public Customer(string customerNIC, string firstName, string lastName, string contactNumber)
        {
            _customerNIC = customerNIC;
            _firstName = firstName;
            _lastName = lastName;
            _contactNumber = contactNumber;
        }

        public bool Insert()
        {
            string query = "INSERT INTO Customer VALUES(@customerNIC, @firstName, @lastName, @contactNumber)";
            string[] parameters = { "@customerNIC", "@firstName", "@lastName", "@contactNumber" };
            object[] values = { _customerNIC, _firstName, _lastName, _contactNumber };

            if (_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Customer details successfully inserted", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to insert customer details", "Operation failed");
            return false;
        }

        public static bool Delete(string ID)
        {
            string query = "DELETE FROM Customer WHERE customerID = @customerID";
            string[] parameters = { "@customerID" };
            object[] values = { ID };

            if (_queryHandler.DeleteQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Customer details successfully deleted", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to delete customer details", "Operation failed");
            return false;
        }

        public bool Update(string ID)
        {
            string query = "UPDATE Customer SET customerNIC = @customerNIC, firstName = @firstName, " +
                "lastName = @lastName, contactNumber = @contactNumber WHERE customerID = @customerID";
            string[] parameters = { "@customerNIC", "@firstName", "@lastName", "@contactNumber", "@customerID" };
            object[] values = { _customerNIC, _firstName, _lastName, _contactNumber, ID };

            if (_queryHandler.UpdateQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Customer details successfully updated", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to update customer details", "Operation failed");
            return false;
        }
    }
}
