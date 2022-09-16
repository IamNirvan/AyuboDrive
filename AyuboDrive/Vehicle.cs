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
        private readonly string _gearbox;
        private readonly int _torque;
        private readonly int _horsepower;
        private readonly decimal _trunkVolume;
        private readonly string _color;
        private readonly decimal _dailyRate;
        private readonly decimal _weeklyRate;
        private readonly decimal _monthlyRate;
        private readonly decimal _overnightRate;
        private readonly string _vehicleStatus;
        private readonly string _imagePath;
        private readonly decimal _standardPackageRate;
        private static QueryHandler s_queryHandler = new QueryHandler();

        public Vehicle(string VIN, string vehicleTypeID, string manufacturer, string model, int seatingCapacity,
            int mileage, string gearbox, int torque, int horsepower, decimal trunkVolume, string color, 
            decimal dailyRate, decimal weeklyRate, decimal monthlyRate, decimal overnightRate, 
            decimal standardPackageRate, VehicleStatus vehicleStatus, string imagePath)
        {
            _VIN = VIN;
            _vehicleTypeID = vehicleTypeID;
            _manufacturer = manufacturer;
            _model = model;
            _seatingCapacity = seatingCapacity;
            _mileage = mileage;
            _gearbox = gearbox;
            _torque = torque;
            _horsepower = horsepower;
            _trunkVolume = trunkVolume;
            _color = color;
            _dailyRate = dailyRate;
            _weeklyRate = weeklyRate;
            _monthlyRate = monthlyRate;
            _overnightRate = overnightRate;
            _vehicleStatus = vehicleStatus.ToString().ToLower();
            _imagePath = imagePath;
            _standardPackageRate = standardPackageRate;
        }

        public bool Insert()
        {
            string query = "INSERT INTO vehicle VALUES(@VIN, @vehicleTypeID, @manufacturer, @model, @seatingCapacity, " +
                "@mileage, @gearboxType, @torque, @horsePower, @trunkVolume, @color, @dailyRate, @weeklyRate, @monthlyRate, " +
                "@overnightRate, @vehicleStatus, @imagePath, @standardPackageRate)";
            string[] parameters = { "@VIN", "@vehicleTypeID", "@manufacturer", "@model", "@seatingCapacity",
                "@mileage", "@gearboxType", "@torque", "@horsePower", "@trunkVolume", "@color", "@dailyRate", "@weeklyRate",
                "@monthlyRate", "@overnightRate", "@vehicleStatus", "@imagePath", "@standardPackageRate" };
            object[] values = { _VIN, _vehicleTypeID, _manufacturer, _model, _seatingCapacity, _mileage, _gearbox, _torque,
                _horsepower, _trunkVolume, _color, _dailyRate, _weeklyRate, _monthlyRate, _overnightRate, _vehicleStatus, _imagePath,
                _standardPackageRate};

            if (s_queryHandler.InsertQueryHandler(query, parameters, values))
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

            if (s_queryHandler.DeleteQueryHandler(query, parameters, values))
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
                "model = @model, seatingCapacity = @seatingCapacity, mileage = @mileage, gearboxType = @gearboxType, torque = @torque, " +
                "horsepower = @horsePower, trunkVolume = @trunkVolume, color = @color, dailyRate = @dailyRate, weeklyRate = @weeklyRate, " +
                "monthlyRate = @monthlyRate, overnightRate = @overnightRate, vehicleStatus = @vehicleStatus, " +
                "imagePath = @imagePath, standardPackageRate = @standardPackageRate WHERE vehicleID = @vehicleID";
            string[] parameters = { "@VIN", "@vehicleTypeID", "@manufacturer", "@model", "@seatingCapacity",
                "@mileage", "@gearboxType", "@torque", "@horsePower", "@trunkVolume", "@color", "@dailyRate", "@weeklyRate",
                "@monthlyRate", "@overnightRate", "@vehicleStatus", "@imagePath", "@standardPackageRate", "@vehicleID" };
            object[] values = { _VIN, _vehicleTypeID, _manufacturer, _model, _seatingCapacity, _mileage, _gearbox, _torque,
                _horsepower, _trunkVolume, _color, _dailyRate, _weeklyRate, _monthlyRate, _overnightRate, _vehicleStatus, _imagePath,
                _standardPackageRate, ID};

            if (s_queryHandler.UpdateQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Vehicle details successfully updated", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to update vehicle details", "Operation failed");
            return false;
        }

        public static bool UpdateMileage(string ID, int mileage)
        {
            string query = "UPDATE vehicle SET mileage = @mileage WHERE vehicleID = @vehicleID";
            string[] parameters = { "@mileage", "@vehicleID" };
            object[] values = {mileage, ID};

            if (s_queryHandler.UpdateQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Vehicle mileage successfully updated", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to update vehicle milege", "Operation failed");
            return false;
        }

        public static bool UpdateAvailability(string ID, Availability availability)
        {
            string query = "UPDATE vehicle SET vehicleStatus = @vehicleStatus WHERE vehicleID = @vehicleID";
            string[] parameters = { "@vehicleStatus", "@vehicleID" };
            object[] values = {availability, ID};

            if (s_queryHandler.UpdateQueryHandler(query, parameters, values))
            {
                MessagePrinter.PrintToConsole("Vehicle availability successfully updated", "Operation successful");
                return true;
            }
            MessagePrinter.PrintToConsole("Failed to update vehicle availability", "Operation failed");
            return false;
        }
    }
}
