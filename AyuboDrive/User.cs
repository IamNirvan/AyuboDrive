using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyuboDrive
{
    public class User
    {
        public string _userAccountID;
        public string _firstName;
        public string _lastName;
        private static readonly QueryHandler queryHandler = new QueryHandler();

        private User(string userAccountID, string firstName, string lastName, string userName)
        {
            _userAccountID = userAccountID;
            _firstName = firstName;
            _lastName = lastName;
        }

        // Invoke this method first to login. If the login is successful, a user object with the appropriate data will be returned.
        public static User Login(string userName, string password)
        {
            string query = "SELECT * FROM User WHERE userName = @userName AND password = @password";
            string[] parameters = { "@userName", "@password"};
            object[] values = {userName, password};

            // Invoke the select query handler here
            if(true)
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

            //return queryHandler.HandleInsertDeleteUpdateQuery(query, parameters, values);
            return false;
        }

        public bool DeleteAccount()
        {
            string query = "DELETE FROM User WHERE userAccountID = @userAccountID";
            string[] parameters = { "@userAccountID" };
            object[] values = { _userAccountID };

            return queryHandler.HandleInsertDeleteUpdateQuery(query, parameters, values);
        }
    }
}
