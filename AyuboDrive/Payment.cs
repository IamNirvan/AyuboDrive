using AyuboDrive.Interfaces;
using AyuboDrive.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyuboDrive
{
    class Payment : IDatabaseManipulator
    {
        private readonly string _hireBookingID;
        private readonly string _rentalBookingID;
        private readonly string _customerID;
        private readonly string _dateOFPayment;
        private readonly double _amountPaid;
        private static readonly QueryHandler s_queryHandler = new QueryHandler();

        public Payment(string hireBookingID, string rentalBookingID, string customerID, string dateOfPayment, double amountPaid)
        {
            _hireBookingID = hireBookingID;
            _rentalBookingID = rentalBookingID;
            _customerID = customerID;
            _dateOFPayment = dateOfPayment;
            _amountPaid = amountPaid;
        }

        public bool Insert()
        {
            string query;
            string[] parameters;
            object[] values;

            if (_hireBookingID == null)
            {
                query = "INSERT INTO payment VALUES(NULL, @rentalBookingID, @customerID, " +
                "@dateOfPayment, @amountPaid)";
                parameters = new string[]{"@rentalBookingID", "@customerID",
                "@dateOfPayment", "@amountPaid"};
                values = new object[]{ _rentalBookingID, _customerID, _dateOFPayment, _amountPaid};
            }
            else
            {
                query = "INSERT INTO payment VALUES(@hireBookingID, NULL, @customerID, " +
                "@dateOfPayment, @amountPaid)";
                parameters = new string[]{"@hireBookingID", "@customerID",
                "@dateOfPayment", "@amountPaid"};
                values = new object[]{ _hireBookingID, _customerID, _dateOFPayment, _amountPaid};
            } 

            if (s_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Payment details successfully inserted", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to insert payment details", "Operation failed");
            return false;
        }

        public static bool Delete(string ID)
        {
            string query = "DELETE FROM payment WHERE paymentID = @paymentID";
            string[] parameters = { "@paymentID"};
            object[] values = { ID };

            if (s_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Payment details successfully deleted", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to delete payment details", "Operation failed");
            return false;
        }

        public bool Update(string ID)
        {
            string query;
            string[] parameters;
            object[] values;

            if (_hireBookingID == null)
            {
                query = "UPDATE payment SET hireBookingID = NULL, rentalBookingID = @rentalBookingID, " +
                    "customerID = @customerID, dateOfPayment = @dateOfPayment, amountPaid = @amountPaid " +
                    "WHERE paymentID = @paymentID";
                parameters = new string[]{ "@rentalBookingID", "@customerID", "@dateOfPayment", "@amountPaid", "@paymentID"};
                values = new object[]{ _rentalBookingID, _customerID, _dateOFPayment, _amountPaid, ID };
            }
            else
            {
                query = "UPDATE payment SET hireBookingID = @hireBookingID, rentalBookingID = NULL, " +
                    "customerID = @customerID, dateOfPayment = @dateOfPayment, amountPaid = @amountPaid " +
                    "WHERE paymentID = @paymentID";
                parameters = new string[]{ "@hireBookingID", "@customerID", "@dateOfPayment", "@amountPaid", "@paymentID"};
                values = new object[]{ _hireBookingID, _customerID, _dateOFPayment, _amountPaid, ID };
            }

            if (s_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Payment details successfully updated", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to update payment details", "Operation failed");
            return false;
        }
    }
}
