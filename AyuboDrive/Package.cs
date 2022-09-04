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
        private readonly double _extraHourRate;
        private readonly double _extraKilometerRate;
        private static QueryHandler _queryHandler = new QueryHandler();

        public Package(string packageName, int maxHour, int maxKilometer, double extraHourRate, 
            double extraKilometerRate)
        {
            _packageName = packageName;
            _maxHour = maxHour;
            _maxKilometer = maxKilometer;
            _extraKilometerRate = extraKilometerRate;
            _extraHourRate = extraHourRate;
        }

        public bool Insert()
        {
            string query = "INSERT INTO package VALUES(@packageName, @maxHour, @maxKilometer, " +
                "@extraHourRate, @extraKilometerRate)";
            string[] parameters = { "@packageName", "@maxHour", "@maxKilometer",
                "@extraHourRate", "@extraKilometerRate" };
            object[] values = { _packageName, _maxHour, _maxKilometer, _extraHourRate, _extraKilometerRate };

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
            string query = "UPDATE package SET packageName = @packageName, maxHour = @maxHour, maxKilometer = @maxKilometer, " +
                "extraHourRate = @extraHourRate, extraKilometerRate = @extraKilometerRate" +
                " WHERE packageID = @packageID";
            string[] parameters = { "@packageName", "@maxHour", "@maxKilometer", "@extraHourRate", "@extraKilometerRate", "@packageID"};
            object[] values = { _packageName, _maxHour, _maxKilometer,_extraHourRate, _extraKilometerRate, ID };

            if (_queryHandler.UpdateQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Package details successfully updated", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to update package details", "Operation failed");
            return false;
        }

        public bool Delete(string ID)
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
    }
}
