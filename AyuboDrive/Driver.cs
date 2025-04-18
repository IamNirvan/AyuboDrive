﻿using AyuboDrive.Enums;
using AyuboDrive.Interfaces;
using AyuboDrive.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyuboDrive
{
    class Driver : IDatabaseManipulator
    {
        private readonly string _driverNIC;
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly string _contactNumber;
        private readonly string _driverStatus;
        private readonly decimal _dailyRate;
        private readonly decimal _overnightRate;
        private static readonly QueryHandler s_queryHandler = new QueryHandler();

        public Driver(string driverNIC, string firstName, string lastName, string contactNumber, 
            DriverStatus driverAvailability, decimal dailyRate, decimal overnightRate)
        {
            _driverNIC = driverNIC;
            _firstName = firstName;
            _lastName = lastName;
            _contactNumber = contactNumber;
            _driverStatus = driverAvailability.ToString().ToLower();
            _dailyRate = dailyRate;
            _overnightRate = overnightRate;
        }

        public bool Insert()
        {
            string query = "INSERT INTO Driver VALUES(@driverNIC, @firstName, @lastName, @contactNumber, " +
                "@driverStatus, @dailyRate, @overnightRate)";
            string[] parameters = { "@driverNIC", "@firstName", "@lastName", "@contactNumber",
                "@driverStatus", "@dailyRate", "@overnightRate" };
            object[] values = { _driverNIC, _firstName, _lastName, _contactNumber, _driverStatus,
            _dailyRate, _overnightRate};

            if (s_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Driver details successfully inserted", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to insert driver details", "Operation failed");
            return false;
        }

        public bool Update(string ID)
        {
            string query = "UPDATE Driver SET driverNIC = @driverNIC, firstName = @firstName, lastName = @lastName, " +
                "contactNumber = @contactNumber, driverStatus = @driverStatus, dailyRate = @dailyRate, " +
                "overnightRate = @overnightRate WHERE driverID = @driverID";
            string[] parameters = { "@driverNIC", "@firstName", "@lastName", "@contactNumber",
                "@driverStatus", "@dailyRate", "@overnightRate" , "@driverID"};
            object[] values = { _driverNIC, _firstName, _lastName, _contactNumber, _driverStatus,
            _dailyRate, _overnightRate, ID};

            if (s_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Driver details successfully updated", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to update driver details", "Operation failed");
            return false;
        }

        public static bool UpdateDriverAvailability(string ID, DriverStatus availability)
        {
            string query = "UPDATE Driver SET driverStatus = @driverStatus WHERE driverID = @driverID";
            string[] parameters = { "@driverStatus", "@driverID"};
            object[] values = { availability.ToString().ToLower(), ID};

            if (s_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Driver details successfully updated", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to update driver details", "Operation failed");
            return false;
        }

        public static bool Delete(string ID)
        {
            string query = "DELETE from driver WHERE driverID = @driverID";
            string[] parameters = { "@driverID" };
            object[] values = { ID};

            if (s_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Driver details successfully deleted", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to delete driver details", "Operation failed");
            return false;
        }
    }
}
