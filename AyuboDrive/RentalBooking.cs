using AyuboDrive.Enums;
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
        private string _driverID;
        private readonly string _customerID;
        private readonly string _startDate;
        private readonly string _endDate;
        private readonly string _rentalStatus;
        private readonly string _paymentStatus;
        private static readonly QueryHandler s_queryHandler = new QueryHandler();
        public static readonly string NullValuePlaceHolder = "No driver";

        public RentalBooking(string vehicleTypeID, string vehicleID, string driverID, string customerID, 
            DateTime startDate, DateTime endDate, BookingStatus rentalStatus, PaymentStatus paymentStatus)
        {
            _vehicleTypeID = vehicleTypeID;
            _vehicleID = vehicleID;
            _driverID = driverID;
            _customerID = customerID;
            _startDate = startDate.Date.ToString("yyyy/MM/dd");
            _endDate = endDate.Date.ToString("yyyy/MM/dd");
            _rentalStatus = rentalStatus.ToString().ToLower();
            _paymentStatus = paymentStatus.ToString().ToLower();
        }

        public bool Insert()
        {
            string query;
            string[] parameters;
            object[] values;

            if(_driverID == null)
            {
                query = "INSERT INTO rentalBooking(vehicleTypeID, vehicleID, customerID, " +
                    "startDate, endDate, rentalStatus, paymentStatus) VALUES(@vehicleTypeID, @vehicleID, " +
                "@customerID, @startDate, @endDate, @rentalStatus, @paymentStatus)";
                parameters = new string[] { "@vehicleTypeID", "@vehicleID", "@customerID",
                    "@startDate", "@endDate", "@rentalStatus", "@paymentStatus" };
                values = new object[] { _vehicleTypeID, _vehicleID, _customerID, _startDate, _endDate,
                _rentalStatus, _paymentStatus };
            }
            else
            {
                query = "INSERT INTO rentalBooking (vehicleTypeID, vehicleID, driverID, customerID, " +
                    "startDate, endDate, rentalStatus, paymentStatus) VALUES(@vehicleTypeID, @vehicleID, @driverID, " +
                "@customerID, @startDate, @endDate, @rentalStatus, @paymentStatus)";
                parameters = new string[]{ "@vehicleTypeID", "@vehicleID", "@driverID", "@customerID",
                    "@startDate", "@endDate", "@rentalStatus", "@paymentStatus" };
                values = new object[]{ _vehicleTypeID, _vehicleID, _driverID, _customerID, _startDate, _endDate,
                _rentalStatus, _paymentStatus };
            }
            

            if (s_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Rental booking details successfully inserted", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to insert rental booking details", "Operation failed");
            return false;
        }

        public static bool Delete(string ID)
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
            string query;
            string[] parameters;
            object[] values;

            if (_driverID == null)
            {
                query = "UPDATE rentalBooking SET vehicleTypeID = @vehicleTypeID, vehicleID = @vehicleID," +
                    "customerID = customerID, startDate = @startDate, endDate = @endDate, rentalStatus = @rentalStatus," +
                    "paymentStatus = @paymentStatus WHERE bookingID = @bookingID";
                parameters = new string[] { "@vehicleTypeID", "@vehicleID", "@customerID",
                    "@startDate", "@endDate", "@rentalStatus", "@paymentStatus", "@bookingID" };
                values = new object[] { _vehicleTypeID, _vehicleID, _customerID, _startDate, _endDate,
                _rentalStatus, _paymentStatus, ID };
            }
            else
            {
                query = "UPDATE rentalBooking SET vehicleTypeID = @vehicleTypeID, vehicleID = @vehicleID, driverID = @driverID," +
                    "customerID = customerID, startDate = @startDate, endDate = @endDate, rentalStatus = @rentalStatus," +
                    "paymentStatus = @paymentStatus WHERE bookingID = @bookingID";
                parameters = new string[] { "@vehicleTypeID", "@vehicleID", "@driverID", "@customerID",
                    "@startDate", "@endDate", "@rentalStatus", "@paymentStatus", "@bookingID" };
                values = new object[] { _vehicleTypeID, _vehicleID, _driverID, _customerID, _startDate, _endDate,
                _rentalStatus, _paymentStatus, ID };
            }

            if (s_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Rental booking details successfully updated", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to update rental booking details", "Operation failed");
            return false;
        }

        // This method is used in the booking closure form.
        public static bool UpdateBooking(string ID, DateTime returnDate, PaymentStatus paymentStatus = PaymentStatus.PAID)
        {
            string query = "UPDATE rentalBooking SET endDate = @endDate, rentalStatus = @rentalStatus," +
                    "paymentStatus = @paymentStatus WHERE bookingID = @bookingID";
            string[] parameters = new string[] { "@endDate", "@rentalStatus", "@paymentStatus", "@bookingID" };
            object[] values = new object[] { returnDate.ToString("yyyy/MM/dd"), BookingStatus.CLOSED.ToString().ToLower(),
                paymentStatus.ToString().ToLower(), ID };

            if (s_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Rental booking details successfully updated", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to update rental booking details", "Operation failed");
            return false;
        }

        // This method is used in the payment form.
        public static bool UpdateBooking(string ID, PaymentStatus paymentStatus = PaymentStatus.PAID)
        {
            string query = "UPDATE rentalBooking SET rentalStatus = @rentalStatus," +
                    "paymentStatus = @paymentStatus WHERE bookingID = @bookingID";
            string[] parameters = new string[] { "@rentalStatus", "@paymentStatus", "@bookingID" };
            object[] values = new object[] { BookingStatus.CLOSED.ToString().ToLower(), paymentStatus.ToString().ToLower(), ID };

            if (s_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Rental booking details successfully updated", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to update rental booking details", "Operation failed");
            return false;
        }

        // When the vehicle type is updated, all the booking records that 
        // reference that vehicle will have the vehicle type ID updated
        public static bool UpdateBooking(string vehicleID, string vehicleTypeID)
        {
            string query = "UPDATE rentalBooking SET vehicleTypeID = @vehicleTypeID WHERE vehicleID = @vehicleID";
            string[] parameters = { "@vehicleTypeID", "@vehicleID" };
            object[] values = { vehicleTypeID, vehicleID };

            if (s_queryHandler.UpdateQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Vehicle type for the rental booking successfully updated", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to update vehicle type for the rental booking", "Operation failed");
            return false;
        }
    }
}
