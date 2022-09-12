using AyuboDrive.Enums;
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
        private GenderOptions _gender;
        private readonly string _imagePath; // Image for the profile picture
        private static readonly QueryHandler s_queryHandler = new QueryHandler();

        public User(string userName, string password, string firstName, string lastName, GenderOptions gender, string imagePath)
        {
            UserName = userName;
            _password = password;
            FirstName = firstName;
            LastName = lastName;
            _gender = gender;
            _imagePath = imagePath;
        }
        /// <summary>
        /// Converts the string version of the gender into the 
        ///  GenderOptions version
        /// </summary>
        /// <param name="gender">The gender in string format</param>
        /// <returns>The gender in GenderOptions format</returns>
        private static GenderOptions GetGender(string gender)
        {
            if (gender.Equals("male"))
            {
                return GenderOptions.MALE;
            }
            else if (gender.Equals("female"))
            {
                return GenderOptions.FEMALE;
            }
            else
            {
                return GenderOptions.OTHER;
            }
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
                    GetGender(dataTable.Rows[0][5].ToString()),
                    dataTable.Rows[0][6].ToString()
                    );
                return user;
            }
            return null;
        }
        
        public bool Insert()
        {
            string query = "INSERT INTO UserAccount VALUES (@userName, @password, @firstName, @lastName, @gender, @imagePath)";
            string[] parameters = { "@userName", "@password", "@firstName", "@lastName", "@gender", "@imagePath" };
            object[] values = { UserName, _password, FirstName, LastName, _gender, _imagePath };

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
            string query = "UPDATE UserAccount SET userName = @userName, password = @password, " +
                "firstName = @firstName, lastName = @lastName, gender = @gender, imagePath = @imagePath " +
                "WHERE userAccountID = @userAccountID";
            string[] parameters = { "@userName", "@password", "@firstName", "@lastName", "@imagePath",
                "@gender", "@userAccountID"};
            object[] values = { UserName, _password, FirstName, LastName, _gender, _imagePath, ID };

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
