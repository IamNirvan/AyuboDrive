using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AyuboDrive.Utility
{
    /// <summary>
    /// This class includes functions that handle all the validation tasks. 
    /// </summary>
    static class ValidationHandler
    {
        private static QueryHandler s_queryHandler = new QueryHandler();

        /// <summary>
        /// Checks to see if the supplied user name exists in the database
        /// </summary>
        /// <param name="userName">The user name</param>
        /// <returns>true if it exists, flase if not</returns>
        public static bool CheckUserNamePresence(string userName)
        {
            string query = "SELECT COUNT(userName) FROM userAccount WHERE userName = '" + userName + "'";
            return (int)s_queryHandler.SelectQueryHandler(query).Rows[0][0] != 0;
        }

        /// <summary>
        /// Checks to see if the package name exists in the database.
        /// </summary>
        /// <param name="packageName">The package name to be checked</param>
        /// <returns>True if the package is valid, and false if otherwise</returns>
        public static bool ValidatePackageName(string packageName)
        {
            string query = $"SELECT COUNT(*) FROM package WHERE packageName = '{packageName}'";
            return packageName.Length != 0 && (int)s_queryHandler.SelectQueryHandler(query).Rows[0][0] == 0;
        }

        /// <summary>
        /// Checks to see if the package name exists in the database.
        /// </summary>
        /// <param name="typeName">The package name to be checked</param>
        /// <returns>True if the package is valid, and false if otherwise</returns>
        public static bool ValidateVehicleTypeName(string typeName)
        {
            string query = $"SELECT COUNT(*) FROM vehicleType WHERE typeName = '{typeName}'";
            return typeName.Length != 0 && (int)s_queryHandler.SelectQueryHandler(query).Rows[0][0] == 0;
        }

        /// <summary>
        /// Checks to see if a VIN does not exist in the database.
        /// </summary>
        /// <param name="tableName">The table to be checked</param>
        /// <param name="columnName">The VIN column name in the table</param>
        /// <param name="VIN">The VIN to be checked</param>
        /// <returns>True if valid. False if not</returns>
        public static bool ValidateVIN(string VIN)
        {
            string query = $"SELECT COUNT(*) FROM vehicle WHERE VIN = '{VIN}'";
            return VIN.Length == 17 && (int)s_queryHandler.SelectQueryHandler(query).Rows[0][0] == 0;
        }

        /// <summary>
        /// Checks to see if the email adderss has a valid composition,
        /// and does not exist in the database
        /// </summary>
        /// <param name="emailAddress">The email address to be checked</param>
        /// <returns>True if valid, and false if not</returns>
        public static bool ValidateEmailAddress(string emailAddress)
        {
            string query = $"SELECT COUNT(*) FROM userAccount WHERE emailAddress = '{emailAddress}'";
            Regex regex = new Regex("^[A-Za-z0-9]{1,50}@[A-Za-z]{1,30}.[A-Za-z]{1,20}$");
            return regex.IsMatch(emailAddress) && (int)s_queryHandler.SelectQueryHandler(query).Rows[0][0] == 0;
        }

        /// <summary>
        /// Checks to see if the file path is valid
        /// </summary>
        /// <param name="filePath">The file path to be checked</param>
        /// <returns>True if the file path is valid, false if not</returns>
        public static bool ValidateFilePath(string filePath)
        {
            return filePath.Length > 0;
        }

        /// <summary>
        /// Checks to see if the NIC is present in the database
        /// </summary>
        /// <param name="NIC">The NIC</param>
        /// <returns>Returns true if valid and false if not</returns>
        public static bool ValidateNIC(string NIC, string tableName, string columnName)
        {
            string query = $"SELECT COUNT(*) FROM {tableName} WHERE {columnName} = '{NIC}'";
            return NIC.Length == 12 && (int)s_queryHandler.SelectQueryHandler(query).Rows[0][0] == 0;
        }

        /// <summary>
        /// Checks to see if the contact number is present in the database
        /// </summary>
        /// <param name="contactNumber">The contact number</param>
        /// <returns>Returns true if the contact number is not found and the length is not 0. Returns false if otherwise</returns>
        public static bool ValidateContactNumber(string contactNumber, string tableName, string columnName)
        {
            string query = $"SELECT COUNT(*) FROM {tableName} WHERE {columnName} = '{contactNumber}'";
            return contactNumber.Length == 10 && (int)s_queryHandler.SelectQueryHandler(query).Rows[0][0] == 0;
        }

        /// <summary>
        /// Checks to see if the password is strong or not.
        /// </summary>
        /// <param name="password">The password</param>
        /// <returns>Returns true if the password is strong, and false if not</returns>
        public static bool ValidatePassword(string password)
        {
            return password.Length >= 8;
        }

        /// <summary>
        /// Checks to see if the end date is greater than or equal to the start date.
        /// Basically, the end date cannot be less than the start date
        /// </summary>
        /// <param name="startDate">The start date</param>
        /// <param name="endDate">The end dare</param>
        /// <returns>Returns true if the date is valid, and false if not</returns>
        public static bool ValidateDate(DateTime startDate, DateTime endDate)
        {
            return endDate >= startDate;
        }

        public static bool ValidateDecimalInput(string mileageString)
        {
            return mileageString.Length > 0 && decimal.Parse(mileageString) > 0m;
        }

        public static bool ValidateComboBoxValue(string value, int selectedIndex)
        {
            return (value.Length != 0 && selectedIndex >= 0);
        }
        
        public static bool ValidateTimeInput(string hour)
        {
            return hour.Length != 0 && int.Parse(hour) > 0;
        }

        public static bool ValidateDistanceInput(string km)
        {
            return km.Length != 0 && int.Parse(km) > 0;
        }

        public static bool ValidateInputLength(string input)
        {
            return input.Length > 0;
        }
    }
}
