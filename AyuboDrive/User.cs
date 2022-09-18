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
        public string UserName;
        private readonly string _password;
        public string FirstName;
        public string LastName;
        private readonly string _imagePath;
        private readonly string _emailAddress;
        private static readonly QueryHandler s_queryHandler = new QueryHandler();

        public User(string userName, string password, string firstName, string lastName, string imagePath, string emailAddress)
        {
            UserName = userName;
            _password = password;
            FirstName = firstName;
            LastName = lastName;
            _imagePath = imagePath;
            _emailAddress = emailAddress;
        }

        public static User Login(string userName, string password)
        {
            DataTable dataTable = s_queryHandler.SelectQueryHandler("SELECT * FROM UserAccount WHERE userName = '" 
                + userName + "' AND accountPassword = '" + password + "'");
        
            if (dataTable != null && dataTable.Rows.Count == 1)
            {
                User user = new User(
                    dataTable.Rows[0][1].ToString(),
                    dataTable.Rows[0][2].ToString(),
                    dataTable.Rows[0][3].ToString(),
                    dataTable.Rows[0][4].ToString(),
                    dataTable.Rows[0][5].ToString(),
                    dataTable.Rows[0][6].ToString()
                    );
                return user;
            }
            return null;
        }
        
        public bool Insert()
        {
            string query = "INSERT INTO UserAccount VALUES (@userName, @accountPassword, @firstName, @lastName, @imagePath, @emailAddress)";
            string[] parameters = { "@userName", "@accountPassword", "@firstName", "@lastName", "@imagePath", "@emailAddress" };
            object[] values = { UserName, _password, FirstName, LastName, _imagePath, _emailAddress };

            if (s_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("User account details successfully inserted", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to insert user account details", "Operation failed");
            return false;
        }

        public static bool Delete(string ID)
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
            string query = "UPDATE UserAccount SET userName = @userName, accountPassword = @accountPassword, " +
                "firstName = @firstName, lastName = @lastName, imagePath = @imagePath, emailAddress = @emailAddress " +
                "WHERE userAccountID = @userAccountID";
            string[] parameters = { "@userName", "@accountPassword", "@firstName", "@lastName", "@imagePath",
                "emailAddress", "@userAccountID"};
            object[] values = { UserName, _password, FirstName, LastName, _imagePath, _emailAddress, ID };

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
