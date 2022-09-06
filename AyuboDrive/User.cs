using AyuboDrive.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyuboDrive
{
    public class User
    {
        public string _userName;
        private string _password;
        public string FirstName;
        public string LastName;
        private static readonly QueryHandler s_queryHandler = new QueryHandler();

        public User(string userName, string password, string firstName, string lastName)
        {
            _userName = userName;
            _password = password;
            FirstName = firstName;
            LastName = lastName;
        }

        public static User Login(string userName, string password)
        {
            DataTable dataTable = s_queryHandler.SelectQueryHandler("SELECT * FROM UserAccount WHERE userName = '" 
                + userName + "' AND password = '" + password + "'");
        
            if (dataTable.Rows.Count == 1)
            {
                User user = new User(
                    dataTable.Rows[0][1].ToString(),
                    dataTable.Rows[0][2].ToString(),
                    dataTable.Rows[0][3].ToString(),
                    dataTable.Rows[0][4].ToString()
                    );
                return user;
            }
            return null;
        }

        public bool Logout()
        {
            return false;
        }

        public bool Insert()
        {
            string query = "INSERT INTO UserAccount VALUES (@userName, @password, @firstName, @lastName)";
            string[] parameters = { "@userName", "@password", "@firstName", "@lastName" };
            object[] values = { _userName, _password, FirstName, LastName };

            if (s_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("User account details successfully inserted", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to insert user account details", "Operation failed");
            return false;
        }

        public bool Delete(string ID)
        {
            string query = "DELETE FROM UserAccount WHERE userAccountID = @userAccountID";
            string[] parameters = { "@userAccountID" };
            object[] values = { ID };

            if (s_queryHandler.DeleteQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("User account details successfully deleted", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to delete user account details", "Operation failed");
            return false;
        }

        public bool Update(string ID)
        {
            string query = "UPDATE UserAccount SET userName = @userName, password = @password, " +
                "firstName = @firstName, lastName = @lastName WHERE userAccountID = @userAccountID";
            string[] parameters = { "@userName", "@password", "@firstName", "@lastName", "@userAccountID" };
            object[] values = { _userName, _password, FirstName, LastName, ID };

            if (s_queryHandler.UpdateQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("User account details successfully updated", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to update user account details", "Operation failed");
            return false;
        }
    }
}
