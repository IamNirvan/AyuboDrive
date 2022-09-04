using AyuboDrive.Interfaces;
using AyuboDrive.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyuboDrive
{
    class RentalBooking : IDatabaseManipulator
    {
        private readonly string _vehicleTypeID;
        private readonly string _vehicleID;
        private readonly string _driverID;
        private readonly string _customerID;
        private readonly string _startDate;
        private readonly string _endDate;
        private static readonly QueryHandler s_queryHandler = new QueryHandler();

        public RentalBooking(string vehicleTypeID, string vehicleID, string driverID, string customerID, 
            string startDate, string endDate)
        {
            _vehicleTypeID = vehicleTypeID;
            _vehicleID = vehicleID;
            _driverID = driverID;
            _customerID = customerID;
            _startDate = startDate;
            _endDate = endDate;
        }

        public bool Insert()
        {
            string query = "INSERT INTO rentalBooking VALUES(@vehicleTypeID, @vehicleID, @driverID, " +
                "@customerID, @startDate, @endDate)";
            string[] parameters = { "@vehicleTypeID", "@vehicleID", "@driverID",
                "@customerID", "@startDate", "@endDate" };
            object[] values = { _vehicleTypeID, _vehicleID, _driverID, _customerID, _startDate, _endDate};

            if (s_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Rental booking details successfully inserted", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to insert rental booking details", "Operation failed");
            return false;
        }

        public bool Delete(string ID)
        {
            string query = "DELETE FROM rentalBooking WHERE bookingID = @bookingID";
            string[] parameters = { "@bookingID" };
            object[] values = { ID };

            if (s_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Rental booking details successfully deleted", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to delete rental booking details", "Operation failed");
            return false;
        }

        public bool Update(string ID)
        {
            string query = "UPDATE rentalBooking SET vehicleTypeID = @vehicleTypeID, vehicleID = @vehicleID, " +
                "driverID = @driverID, customerID = @customerID, startDate = @startDate, endDate = @endDate " +
                "WHERE bookingID = @bookingID";
            string[] parameters = { "@vehicleTypeID", "@vehicleID", "@driverID",
                "@customerID", "@startDate", "@endDate", "@bookingID" };
            object[] values = { _vehicleTypeID, _vehicleID, _driverID, _customerID, _startDate, _endDate, ID };

            if (s_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Rental booking details successfully updated", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to update rental booking details", "Operation failed");
            return false;
        }
    }
}
