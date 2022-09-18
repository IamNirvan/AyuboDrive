using AyuboDrive.Interfaces;
using AyuboDrive.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyuboDrive
{
    class RentalPayment : IDatabaseManipulator
    {
        private string _bookingID;
        private readonly string _customerID;
        private readonly string _dateOFPayment;
        private readonly decimal _amountPaid;
        private static readonly QueryHandler s_queryHandler = new QueryHandler();

        public RentalPayment(string bookingID, string customerID, DateTime dateOfPayment, decimal amountPaid)
        {
            _bookingID = bookingID;
            _customerID = customerID;
            _dateOFPayment = dateOfPayment.ToString("yyyy/MM/dd");
            _amountPaid = amountPaid;
        }

        public bool Insert()
        {
            string query = "INSERT INTO rentalPayment VALUES(@rentalBookingID, @customerID, " +
                "@dateOfPayment, @amountPaid)";
            string[] parameters = new string[]{"@rentalBookingID", "@customerID",
                "@dateOfPayment", "@amountPaid"};
            object[] values = new object[] { _bookingID, _customerID,
                _dateOFPayment, _amountPaid };

            if (s_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Rental booking payment details were successfully inserted", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to insert rental booking payment details", "Operation failed");
            return false;
        }

        public static bool Delete(string ID)
        {
            string query = "DELETE FROM rentalPayment WHERE paymentID = @paymentID";
            string[] parameters = { "@paymentID" };
            object[] values = { ID };

            if (s_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Rental booking payment details successfully deleted",
                    "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to delete rental booking payment details",
                "Operation failed");
            return false;
        }

        public bool Update(string ID)
        {
            string query = "UPDATE rentalPayment SET rentalBookingID = @rentalBookingID," +
                "customerID = @customerID, dateOfPayment = @dateOfPayment, " +
                "amountPaid = @amountPaid WHERE paymentID = @paymentID";
            string[] parameters = new string[]{"@rentalBookingID", "@customerID",
                "@dateOfPayment", "@amountPaid", "@paymentID"};
            object[] values = new object[] { _bookingID, _customerID,
                _dateOFPayment, _amountPaid, ID };

            if (s_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Rental booking payment details successfully updated",
                    "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to update rental booking payment details",
                "Operation failed");
            return false;
        }
    }
}
