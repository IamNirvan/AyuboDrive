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
    class Package : IDatabaseManipulator
    {
        private readonly string _packageName;
        private readonly int _maxHour;
        private readonly int _maxKilometer;
        private readonly decimal _extraHourRate;
        private readonly decimal _extraKilometerRate;
        private readonly string _packageStatus;
        private static QueryHandler _queryHandler = new QueryHandler();

        public Package(string packageName, int maxHour, int maxKilometer, decimal extraHourRate, 
            decimal extraKilometerRate, PackageStatus packageStatus)
        {
            _packageName = packageName;
            _maxHour = maxHour;
            _maxKilometer = maxKilometer;
            _extraKilometerRate = extraKilometerRate;
            _extraHourRate = extraHourRate;
            _packageStatus = packageStatus.ToString().ToLower();
        }

        public bool Insert()
        {
            string query = "INSERT INTO package VALUES(@packageName, @maxHour, @maxKilometer, " +
                "@extraHourRate, @extraKilometerRate, @packageStatus)";
            string[] parameters = { "@packageName", "@maxHour", "@maxKilometer",
                "@extraHourRate", "@extraKilometerRate", "@packageStatus" };
            object[] values = { _packageName, _maxHour, _maxKilometer, _extraHourRate,
                _extraKilometerRate, _packageStatus };

            if (_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Package details successfully inserted", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to insert package details", "Operation failed");
            return false;
        }

        public bool Update(string ID)
        {
            string query = "UPDATE package SET packageName = @packageName, maxHour = @maxHour, " +
                "maxKilometer = @maxKilometer, extraHourRate = @extraHourRate, " +
                "extraKilometerRate = @extraKilometerRate, packageStatus = @packageStatus" +
                " WHERE packageID = @packageID";
            string[] parameters = { "@packageName", "@maxHour", "@maxKilometer", "@extraHourRate",
                "@extraKilometerRate", "@packageStatus", "@packageID"};
            object[] values = { _packageName, _maxHour, _maxKilometer,_extraHourRate, _extraKilometerRate,
                _packageStatus, ID };

            if (_queryHandler.UpdateQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Package details successfully updated", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to update package details", "Operation failed");
            return false;
        }

        public static bool Delete(string ID)
        {
            string query = "DELETE FROM package WHERE packageID = @packageID";
            string[] parameters = { "@packageID" };
            object[] values = { ID };

            if (_queryHandler.DeleteQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Package details successfully deleted", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to delete package details", "Operation failed");
            return false;
        }

        public static bool DiscontinuePackage(string ID)
        {
            string query = "UPDATE package SET packageStatus = @packageStatus WHERE packageID = @packageID";
            string[] parameters = { "@packageStatus", "@packageID"};
            object[] values = { PackageStatus.DISCONTINUED.ToString().ToLower(), ID };

            if (_queryHandler.UpdateQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Package successfully discontinued", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to discontinue package", "Operation failed");
            return false;
        }
    }
}
