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

            if (_hireBookingID == "")
            {
                query = "INSERT INTO payment VALUES(NULL, @rentalBookingID, @customerID, " +
                "@dateOfPayment, @amountPaid)";
            } else if (_rentalBookingID == "")
            {
                query = "INSERT INTO payment VALUES(@hireBookingID, NULL, @customerID, " +
                "@dateOfPayment, @amountPaid)";
            } else
            {
                query = "INSERT INTO payment VALUES(@hireBookingID, @rentalBookingID, @customerID, " +
                    "@dateOfPayment, @amountPaid)";
            }

            string[] parameters = { "@hireBookingID", "@rentalBookingID", "@customerID",
                "@dateOfPayment", "@amountPaid"};
            object[] values = { _hireBookingID, _rentalBookingID, _customerID, _dateOFPayment, _amountPaid};

            if (s_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Payment details successfully inserted", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to insert payment details", "Operation failed");
            return false;
        }

        public bool Delete(string ID)
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

            if(_hireBookingID == "")
            {
                query = "UPDATE payment SET hireBookingID = NULL, rentalBookingID = @rentalBookingID, " +
                    "customerID = @customerID, dateOfPayment = @dateOfPayment, amountPaid = @amountPaid " +
                    "WHERE paymentID = @paymentID";
            }
            else if(_rentalBookingID == "")
            {
                query = "UPDATE payment SET hireBookingID = @hireBookingID, rentalBookingID = NULL, " +
                    "customerID = @customerID, dateOfPayment = @dateOfPayment, amountPaid = @amountPaid " +
                    "WHERE paymentID = @paymentID";
            } 
            else
            {
                query = "UPDATE payment SET hireBookingID = @hireBookingID, rentalBookingID = @rentalBookingID, " +
                    "customerID = @customerID, dateOfPayment = @dateOfPayment, amountPaid = @amountPaid " +
                    "WHERE paymentID = @paymentID";
            }
            string[] parameters = {"@hireBookingID", "@rentalBookingID", "@customerID",
                "@dateOfPayment", "@amountPaid", "@paymentID"};
            object[] values = { _hireBookingID, _rentalBookingID, _customerID, _dateOFPayment, _amountPaid, ID };

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
