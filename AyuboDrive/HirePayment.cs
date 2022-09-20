using AyuboDrive.Interfaces;
using AyuboDrive.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyuboDrive
{
    class HirePayment : IDatabaseManipulator
    {
        private string _hireBookingID;
        private readonly string _customerID;
        private readonly string _dateOFPayment;
        private readonly decimal _amountPaid;
        private static readonly QueryHandler s_queryHandler = new QueryHandler();

        public HirePayment(string hireBookingID, string customerID, DateTime dateOfPayment, decimal amountPaid)
        {
            _hireBookingID = hireBookingID;
            _customerID = customerID;
            _dateOFPayment = dateOfPayment.Date.ToString("yyyy/MM/dd");
            _amountPaid = amountPaid;
        }

        public bool Insert()
        {
            string query = "INSERT INTO hirePayment VALUES(@hireBookingID, @customerID, " +
                "@dateOfPayment, @amountPaid)";
            string[] parameters = new string[]{"@hireBookingID", "@customerID",
                "@dateOfPayment", "@amountPaid"};
            object[] values = new object[] { _hireBookingID, _customerID,
                _dateOFPayment, _amountPaid };

            if (s_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Hire booking payment details were successfully inserted", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to insert hire booking payment details", "Operation failed");
            return false;
        }

        public static bool Delete(string ID)
        {
            string query = "DELETE FROM hirePayment WHERE paymentID = @paymentID";
            string[] parameters = { "@paymentID" };
            object[] values = { ID };

            if (s_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Hire booking payment details successfully deleted",
                    "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to delete hire booking payment details",
                "Operation failed");
            return false;
        }

        public bool Update(string ID)
        {
            string query = "UPDATE hirePayment SET hireBookingID = @hireBookingID," +
                "customerID = @customerID, dateOfPayment = @dateOfPayment, " +
                "amountPaid = @amountPaid WHERE paymentID = @paymentID";
            string[] parameters = new string[]{"@hireBookingID", "@customerID",
                "@dateOfPayment", "@amountPaid", "@paymentID"};
            object[] values = new object[] { _hireBookingID, _customerID,
                _dateOFPayment, _amountPaid, ID };

            if (s_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Hire booking payment details successfully updated",
                    "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to update hire booking payment details",
                "Operation failed");
            return false;
        }
    }
}
