using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive
{
    class VehicleType
    {
        public string VehicleTypeID { get; set; }
        private double VehicleOvernightRate { get; set; }
        private string VehicleTypeName { get; set; }
        private double DriverOvernightRate { get; set; }
        private double DriverDailyRate { get; set; }
        private string ImagePath { get; set; }
        private static QueryHandler queryHandler = new QueryHandler();

        public VehicleType(string vehicleTypeId, string vehicleTypeName, double vehicleOvernightRate, double driverOvernightRate, double driverDailyRate, 
            string imagePath)
        {
            VehicleTypeID = vehicleTypeId;
            VehicleTypeName = vehicleTypeName;
            VehicleOvernightRate = vehicleOvernightRate;
            DriverOvernightRate = driverOvernightRate;
            DriverDailyRate = driverDailyRate;
            ImagePath = imagePath;
        }

        public static VehicleType RegisterVehicleType(string vehicleTypeName, double vehicleOvernightRate, double driverOvernightRate, double driverDailyRate,
            string imagePath)
        {
            string vehicleTypeID = "";
            string query = "INSERT INTO VehicleType VALUES(@customerID, @firstName, @lastName, @contactNumber)";
            string[] parameters = { "@customerID", "@firstName", "@lastName", "@contactNumber" };
            object[] values = { vehicleTypeID, vehicleOvernightRate, driverOvernightRate, driverDailyRate, imagePath };

            if (queryHandler.HandleInsertDeleteUpdateQuery(query, parameters, values))
            {
                MessageBox.Show($"Vehicle type details successfully registereds", "Registration successful", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                return new VehicleType(vehicleTypeID, vehicleTypeName, vehicleOvernightRate, driverOvernightRate, driverDailyRate, imagePath);
            }
            MessageBox.Show("Vehicle type registration failed", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        public void UpdateVehicleType(string vehicleTypeName, double vehicleOvernightRate, double driverOvernightRate, double driverDailyRate,
            string imagePath)
        {
            string query = "INSERT INTO VehicleType VALUES(@customerID, @firstName, @lastName, @contactNumber)";
            string[] parameters = { "@customerID", "@firstName", "@lastName", "@contactNumber" };
            object[] values = { vehicleOvernightRate, driverOvernightRate, driverDailyRate, imagePath };

            if (queryHandler.HandleInsertDeleteUpdateQuery(query, parameters, values))
            {
                MessageBox.Show($"Vehicle type details successfully updated", "Update successful", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Failed to update vehicle type", "Update failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void DeleteVehicleType()
        {
            string query = "DELETE FROM VehicleType WHERE vehicleTypeID = @vehicleTypeID";
            string[] parameters = { "customerID" };
            object[] values = { VehicleTypeID };

            if (queryHandler.HandleInsertDeleteUpdateQuery(query, parameters, values))
            {
                MessageBox.Show($"Vehicle type details successfully deleted", "Delete successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Failed to delete vehicle type details", "Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
