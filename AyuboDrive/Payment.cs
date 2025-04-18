﻿using AyuboDrive.Interfaces;
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
        private string _hireBookingID;
        private string _rentalBookingID;
        private readonly string _customerID;
        private readonly string _dateOFPayment;
        private readonly decimal _amountPaid;
        private static readonly QueryHandler s_queryHandler = new QueryHandler();
        public static readonly string NullValuePlaceHolder = "N/A";

        public Payment(string hireBookingID, string rentalBookingID, string customerID, string dateOfPayment, decimal amountPaid)
        {
            _hireBookingID = hireBookingID;
            _rentalBookingID = rentalBookingID;
            _customerID = customerID;
            _dateOFPayment = dateOfPayment;
            _amountPaid = amountPaid;
        }

        public bool Insert()
        {
            _hireBookingID = _hireBookingID == null ? NullValuePlaceHolder : _hireBookingID;
            _rentalBookingID = _rentalBookingID == null ? NullValuePlaceHolder : _rentalBookingID;

            string query = "INSERT INTO payment VALUES(@hireBookingID, @rentalBookingID, " +
                "@customerID, @dateOfPayment, @amountPaid)";
            string[] parameters = new string[]{"@hireBookingID", "@rentalBookingID", "@customerID",
                "@dateOfPayment", "@amountPaid"};
            object[] values = new object[] { _hireBookingID, _rentalBookingID, _customerID,
                _dateOFPayment, _amountPaid };

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
            _hireBookingID = _hireBookingID == null ? NullValuePlaceHolder : _hireBookingID;
            _rentalBookingID = _rentalBookingID == null ? NullValuePlaceHolder : _rentalBookingID;

            string query = "UPDATE payment SET hireBookingID = @hireBookingID, rentalBookingID = " +
                "@rentalBookingID, customerID = @customerID, dateOfPayment = @dateOfPayment, " +
                "amountPaid = @amountPaid WHERE paymentID = @paymentID";
            string[] parameters = new string[]{"@hireBookingID", "@rentalBookingID", "@customerID",
                "@dateOfPayment", "@amountPaid", "@paymentID"};
            object[] values = new object[] { _hireBookingID, _rentalBookingID, _customerID,
                _dateOFPayment, _amountPaid, ID };
            
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
