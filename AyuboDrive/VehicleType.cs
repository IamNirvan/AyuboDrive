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
    class VehicleType : IDatabaseManipulator
    {
        private readonly string _typeName;
        private static QueryHandler _queryHandler = new QueryHandler();

        public VehicleType(string typeName)
        {
            _typeName = typeName;
        }

        public bool Insert()
        {
            string query = "INSERT INTO vehicleType VALUES(@typeName)";
            string[] parameters = { "@typeName" };
            object[] values = { _typeName };

            if (_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Vehicle type details successfully inserted", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to insert vehicle type details", "Operation failed");
            return false;
        }

        public static bool Delete(string ID)
        {
            string query = "DELETE FROM vehicleType WHERE vehicleTypeID = @vehicleTypeID";
            string[] parameters = { "@vehicleTypeID" };
            object[] values = { ID };

            if (_queryHandler.DeleteQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Vehicle type details successfully deleted",
                    "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to delete vehicle type details",
                "Operation failed");
            return false;
        }

        public bool Update(string ID)
        {
            string query = "UPDATE vehicleType SET typeName = @typeName WHERE vehicleTypeID = @vehicleTypeID";
            string[] parameters = { "@typeName", "@vehicleTypeID" };
            object[] values = { _typeName, ID };

            if (_queryHandler.UpdateQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Vehicle type details successfully updated",
                    "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to update vehicle type details",
                "Operation failed");
            return false;
        }
    }
}
