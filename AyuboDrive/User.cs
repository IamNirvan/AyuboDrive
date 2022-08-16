using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyuboDrive
{
    public class User
    {
        public string UserAccountID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private static readonly QueryHandler queryHandler = new QueryHandler();

        private User(string userAccountID, string firstName, string lastName, string userName)
        {
            UserAccountID = userAccountID;
            FirstName = firstName;
            LastName = lastName;
        }

        // Invoke this method first to login. If the login is successful, a user object with the appropriate data will be returned.
        public static User Login(string userName, string password)
        {
            string query = "SELECT * FROM User WHERE userName = @userName AND password = @password";
            string[] parameters = { "@userName", "@password"};
            object[] values = {userName, password};

            // Check if the user account exists in the database             
            if(queryHandler.SelectQueryHandler(query).Rows.Count == 1)
            {
                return new User("userAccountID", "FirstName", "LastName", "UserName");
            }
            return null;
        }

        public bool Logout()
        {
            return false;
        }

        public static bool RegisterAccount(string firstName, string lastName, string userName, string password)
        {
            string query = "INSERT INTO Users VALUES (@firstName, @lastName, @userName, @password)";
            string[] parameters = { "@firstName", "@lastName", "@userName", "@password" };
            object[] values = { firstName, lastName, userName, password};

            return queryHandler.HandleInsertDeleteUpdateQuery(query, parameters, values);
        }

        public bool DeleteAccount()
        {
            string query = "DELETE FROM User WHERE userAccountID = @userAccountID";
            string[] parameters = { "@userAccountID" };
            object[] values = { UserAccountID };

            return queryHandler.HandleInsertDeleteUpdateQuery(query, parameters, values);
        }

        public bool UpdateAccount(string firstName, string lastName, string userName, string password)
        {
            string query = "UPDATE User SET firstName = @firstName, lastName = @lastName, userName = @userName, " +
                "password = @password WHERE userAccountID = @userAccountID";
            string[] parameters = { "@firstName", "@lastName", "@userName", "@password", "@userAccountID" };
            object[] values = { firstName, lastName, userName, password, UserAccountID };

            // Modify the attributes to reflect the changes in the existing object
            FirstName = firstName;
            LastName = lastName;

            return queryHandler.HandleInsertDeleteUpdateQuery(query, parameters, values);
        }
    }
}
