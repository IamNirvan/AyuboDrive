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
        private string _userNIC;
        public string _userName;
        private string _password;
        public string _firstName;
        public string _lastName;
        private static readonly QueryHandler s_queryHandler = new QueryHandler();

        public User(string userNIC, string userName, string password, string firstName, string lastName)
        {
            _userNIC = userNIC;
            _userName = userName;
            _password = password;
            _firstName = firstName;
            _lastName = lastName;
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
                    dataTable.Rows[0][4].ToString(),
                    dataTable.Rows[0][5].ToString()
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
            string query = "INSERT INTO UserAccount VALUES (@userNIC, @userName, @password, @firstName, @lastName)";
            string[] parameters = { "@userNIC", "@userName", "@password", "@firstName", "@lastName" };
            object[] values = { _userNIC, _userName, _password, _firstName, _lastName };

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
            string query = "UPDATE UserAccount SET userNIC = @userNIC, userName = @userName, password = @password, " +
                "firstName = @firstName, lastName = @lastName WHERE userAccountID = @userAccountID";
            string[] parameters = { "@userNIC", "@userName", "@password", "@firstName", "@lastName", "@userAccountID" };
            object[] values = { _userNIC, _userName, _password, _firstName, _lastName, ID };

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
