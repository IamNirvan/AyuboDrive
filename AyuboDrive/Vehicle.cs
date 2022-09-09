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
    class Vehicle : IDatabaseManipulator
    {
        private readonly string _VIN;
        private readonly string _vehicleTypeID;
        private readonly string _manufacturer;
        private readonly string _model;
        private readonly int _seatingCapacity;
        private readonly int _mileage;
        private readonly int _torque;
        private readonly int _horsepower;
        private readonly double _dailyRate;
        private readonly double _weeklyRate;
        private readonly double _monthlyRate;
        private readonly double _overnightRate;
        private readonly double _standardPackageRate;
        private readonly Availability _vehicleStatus;
        private readonly string _imagePath;
        private static QueryHandler _queryHandler = new QueryHandler();

        public Vehicle(string VIN, string vehicleTypeID, string manufacturer, string model, int seatingCapacity,
            int mileage, int torque, int horsepower, double dailyRate, double weeklyRate, double monthlyRate,
            double overnightRate, double standardPackageRate, Availability vehicleStatus, string imagePath)
        {
            _VIN = VIN;
            _vehicleTypeID = vehicleTypeID;
            _manufacturer = manufacturer;
            _model = model;
            _seatingCapacity = seatingCapacity;
            _mileage = mileage;
            _torque = torque;
            _horsepower = horsepower;
            _dailyRate = dailyRate;
            _weeklyRate = weeklyRate;
            _monthlyRate = monthlyRate;
            _overnightRate = overnightRate;
            _standardPackageRate = standardPackageRate;
            _vehicleStatus = vehicleStatus;
            _imagePath = imagePath;
        }

        public bool Insert()
        {
            string query = "INSERT INTO vehicle VALUES(@VIN, @vehicleTypeID, @manufacturer, @model, @seatingCapacity, " +
                "@mileage, @torque, @horsePower, @dailyRate, @weeklyRate, @monthlyRate, @overnightRate, @vehicleStatus, " +
                "@imagePath, @standardPackageRate)";
            string[] parameters = { "@VIN", "@vehicleTypeID", "@manufacturer", "@model", "@seatingCapacity",
                "@mileage", "@torque", "@horsePower", "@dailyRate", "@weeklyRate", "@monthlyRate", "@overnightRate",
                "@vehicleStatus", "@imagePath", "@standardPackageRate" };
            object[] values = { _VIN, _vehicleTypeID, _manufacturer, _model, _seatingCapacity, _mileage, _torque,
                _horsepower, _dailyRate, _weeklyRate, _monthlyRate, _overnightRate, _vehicleStatus, _imagePath,
                _standardPackageRate};

            if (_queryHandler.InsertQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Vehicle details successfully inserted", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to insert vehicle details", "Operation failed");
            return false;
        }

        public static bool Delete(string ID)
        {
            string query = "DELETE FROM vehicle WHERE vehicleID = @vehicleID";
            string[] parameters = { "@vehicleID" };
            object[] values = { ID};

            if (_queryHandler.DeleteQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Vehicle details successfully deleted", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to delete vehicle details", "Operation failed");
            return false;
        }

        public bool Update(string ID)
        {
            string query = "UPDATE vehicle SET VIN = @VIN, vehicleTypeID = @vehicleTypeID, manufacturer = @manufacturer, " +
                "model = @model, seatingCapacity = @seatingCapacity, mileage = @mileage, torque = @torque, " +
                "horsepower = @horsePower, dailyRate = @dailyRate, weeklyRate = @weeklyRate, " +
                "monthlyRate = @monthlyRate, overnightRate = @overnightRate, vehicleStatus = @vehicleStatus, " +
                "imagePath = @imagePath, standardPackageRate = @standardPackageRate WHERE vehicleID = @vehicleID";
            string[] parameters = { "@VIN", "@vehicleTypeID", "@manufacturer", "@model", "@seatingCapacity",
                "@mileage", "@torque", "@horsePower", "@dailyRate", "@weeklyRate", "@monthlyRate", "@overnightRate",
                "@vehicleStatus", "@imagePath", "@standardPackageRate", "@vehicleID" };
            object[] values = { _VIN, _vehicleTypeID, _manufacturer, _model, _seatingCapacity, _mileage, _torque,
                _horsepower, _dailyRate, _weeklyRate, _monthlyRate, _overnightRate, _vehicleStatus, _imagePath,
                _standardPackageRate, ID};

            if (_queryHandler.UpdateQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Vehicle details successfully updated", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to update vehicle details", "Operation failed");
            return false;
        }
    }
}
