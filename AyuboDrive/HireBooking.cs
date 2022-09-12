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
        private readonly string _vehicleTypeID;
        private readonly string _vehicleID;
        private readonly string _driverID;
        private readonly string _customerID;
        private readonly string _packageID;
        private readonly string _hireStatus;
        private readonly string _hireType;
        private readonly string _startDate;
        private readonly string _endDate;
        private readonly string _paymentStatus;
        private readonly static QueryHandler s_queryHandler = new QueryHandler();

        public HireBooking(string vehicleTypeID, string vehicleID, string driverID, 
            string customerID, string packageID, string hireStatus, string hireType, 
            string startDate, string endDate, string paymentStatus)
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
            _paymentStatus = paymentStatus;
        }      
        
        public bool Insert()
        {
            string query = "INSERT INTO hireBooking VALUES(@vehicleTypeID, @vehicleID, @driverID, " +
                "@customerID, @packageID, @hireStatus, @hireType, @startDate, @endDate @paymentStatus)";
            string[] parameters = { "@vehicleTypeID", "@vehicleID", "@driverID", "@customerID",
                "@packageID", "@hireStatus", "@hireType", "@startDate", "@endDate", "@paymentStatus" };
            object[] values = { _vehicleTypeID, _vehicleID, _driverID, _customerID, _packageID,
                _hireStatus, _hireType, _startDate, _endDate, _paymentStatus };

            if (s_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Hire booking details successfully inserted", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to insert hire booking details", "Operation failed");
            return false;
        }

        public static bool Delete(string ID)
        {
            string query = "DELETE FROM hireBooking WHERE bookingID = @bookingID";
            string[] parameters = { "@bookingID" };
            object[] values = { ID };

            if (s_queryHandler.InsertQueryHandler(query, parameters, values))
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
                "startDate = @startDate, endDate = @endDate, paymentStatus = @paymentStatus WHERE bookingID = @bookingID";
            string[] parameters = { "@vehicleTypeID", "@vehicleID", "@driverID", "@customerID",
                "@packageID", "@hireStatus", "@hireType", "@startDate", "@endDate", "@paymentStatus", "@bookingID" };
            object[] values = { _vehicleTypeID, _vehicleID, _driverID, _customerID, _packageID,
                _hireStatus, _hireType, _startDate, _endDate, _paymentStatus, ID };

            if (s_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Hire booking details successfully updated", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to update hire booking details", "Operation failed");
            return false;
        }
    }
}
