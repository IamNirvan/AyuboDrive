using AyuboDrive.Enums;
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
    class Customer : IDatabaseManipulator
    {
        private readonly string _customerNIC;
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly string _contactNumber;
        private readonly string _gender;
        private readonly static QueryHandler s_queryHandler = new QueryHandler();

        public Customer(string customerNIC, string firstName, string lastName, string contactNumber, GenderOptions gender)
        {
            _customerNIC = customerNIC;
            _firstName = firstName;
            _lastName = lastName;
            _contactNumber = contactNumber;
            _gender = gender.ToString().ToLower();
        }

        public bool Insert()
        {
            string query = "INSERT INTO Customer VALUES(@customerNIC, @firstName, @lastName, @contactNumber, @gender)";
            string[] parameters = { "@customerNIC", "@firstName", "@lastName", "@contactNumber", "@gender" };
            object[] values = { _customerNIC, _firstName, _lastName, _contactNumber, _gender };

            if (s_queryHandler.InsertQueryHandler(query, parameters, values))
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

            if (s_queryHandler.DeleteQueryHandler(query, parameters, values))
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
                "lastName = @lastName, contactNumber = @contactNumber, gender = @gender WHERE customerID = @customerID";
            string[] parameters = { "@customerNIC", "@firstName", "@lastName", "@contactNumber", "@gender", "@customerID" };
            object[] values = { _customerNIC, _firstName, _lastName, _contactNumber, ID };

            if (s_queryHandler.UpdateQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Customer details successfully updated", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to update customer details", "Operation failed");
            return false;
        }
    }
}
