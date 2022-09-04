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
    class HireBooking : IDatabaseManipulator
    {
        private string _vehicleTypeID { get; set; }
        private string _vehicleID { get; set; }
        private string _driverID { get; set; }
        private string _customerID { get; set; }
        private string _packageID { get; set; }
        private HireStatus _hireStatus { get; set; }
        private HireType _hireType { get; set; }
        private string _startDate { get; set; }
        private string _endDate { get; set; }
        private static QueryHandler _queryHandler = new QueryHandler();

        public HireBooking(string vehicleTypeID, string vehicleID, string driverID, 
            string customerID, string packageID, HireStatus hireStatus, HireType hireType, 
            string startDate, string endDate)
        {
            _vehicleTypeID = vehicleTypeID;
            _vehicleID = vehicleID;
            _driverID = driverID;
            _customerID = customerID;
            _packageID = packageID;
            _hireStatus = hireStatus;
            _hireType = hireType;
            _startDate = startDate;
            _endDate = endDate;
        }      
        
        public bool Insert()
        {
            string query = "INSERT INTO hireBooking VALUES(@vehicleTypeID, @vehicleID, @driverID, " +
                "@customerID, @packageID, @hireStatus, @hireType, @startDate, @endDate)";
            string[] parameters = { "@vehicleTypeID", "@vehicleID", "@driverID", "@customerID",
                "@packageID", "@hireStatus", "@hireType", "@startDate", "@endDate" };
            object[] values = { _vehicleTypeID, _vehicleID, _driverID, _customerID, _packageID,
                _hireStatus, _hireType, _startDate, _endDate };

            if (_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Hire booking details successfully inserted", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to insert hire booking details", "Operation failed");
            return false;
        }

        public bool Delete(string ID)
        {
            string query = "DELETE FROM hireBooking WHERE bookingID = @bookingID";
            string[] parameters = { "@bookingID" };
            object[] values = { ID };

            if (_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Hire booking details successfully deleted", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to delete hire booking details", "Operation failed");
            return false;
        }

        public bool Update(string ID)
        {
            string query = "UPDATE hireBooking SET vehicleTypeID = @vehicleTypeID, vehicleID = @vehicleID, driverID = @driverID, " +
                "customerID = @customerID, packageID = @packageID, hireStatus = @hireStatus, hireType = @hireType, " +
                "startDate = @startDate, endDate = @endDate WHERE bookingID = @bookingID";
            string[] parameters = { "@vehicleTypeID", "@vehicleID", "@driverID", "@customerID",
                "@packageID", "@hireStatus", "@hireType", "@startDate", "@endDate", "@bookingID" };
            object[] values = { _vehicleTypeID, _vehicleID, _driverID, _customerID, _packageID,
                _hireStatus, _hireType, _startDate, _endDate, ID };

            if (_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Hire booking details successfully updated", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to update hire booking details", "Operation failed");
            return false;
        }
    }
}
