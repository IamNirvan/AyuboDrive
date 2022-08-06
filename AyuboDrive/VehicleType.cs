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
        public int VehicleTypeID { get; }
        private double VehicleOvernightRate { get; }
        private string VehicleTypeName;
        private double DriverOvernightRate { get; }
        private double DriverDailyRate { get; }
        private const string connectionString = @"Data Source=DESKTOP-0CECDCR;Initial Catalog=AyuboDriveV1;Integrated Security=True";


        public VehicleType(int vehicleTypeId, string vehicleTypeName, double vehicleOvernightRate, double driverOvernightRate, double driverDailyRate)
        {
            VehicleTypeID = vehicleTypeId;
            VehicleTypeName = vehicleTypeName;
            VehicleOvernightRate = vehicleOvernightRate;
            DriverOvernightRate = driverOvernightRate;
            DriverDailyRate = driverDailyRate;
        }

        public bool RegisterVehicleType()
        {
            string query = "INSERT INTO VehicleType VALUES(@vehicleTypeID, @vehicleTypeName, @vehicleOvernightRate, " +
                "@driverOvernightRate, @driverDailyRate)";

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@vehicleTypeID", VehicleTypeID);
                    sqlCommand.Parameters.AddWithValue("@vehicleTypeName", VehicleTypeName);
                    sqlCommand.Parameters.AddWithValue("@vehicleOvernightRate", VehicleOvernightRate);
                    sqlCommand.Parameters.AddWithValue("@driverOvernightRate", DriverOvernightRate);
                    sqlCommand.Parameters.AddWithValue("@driverDailyRate", DriverDailyRate);
                    sqlCommand.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e}", "An error occurred when registering the vehicle type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool UpdateVehicleType(int vehicleTypeID, string vehicleTypeName, double vehicleOvernightRate, double driverOvernightRate, double driverDailyRate)
        {
            string query = "UPDATE VehicleType SET vehicleTypeName = @vehicleTypeName, vehicleOvernightRate = @vehicleOvernightRate, " +
                "driverDailyRate = @driverDailyRate, driverOvernightRate = @driverOvernightRate WHERE vehicleTypeID = @vehicleTypeID";

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@vehicleTypeID", vehicleTypeID);
                    sqlCommand.Parameters.AddWithValue("@vehicleTypeName", vehicleTypeName);
                    sqlCommand.Parameters.AddWithValue("@vehicleOvernightRate", vehicleOvernightRate);
                    sqlCommand.Parameters.AddWithValue("@driverOvernightRate", driverOvernightRate);
                    sqlCommand.Parameters.AddWithValue("@driverDailyRate", driverDailyRate);
                    sqlCommand.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e}", "An error occurred when updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool DeleteVehicleType(int vehicleTypeID)
        {
            string query = "DELETE FROM VehicleType WHERE vehicleTypeID = @vehicleTypeID";

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@vehicleTypeID", vehicleTypeID);
                    sqlCommand.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e}", "An error occurred when deleting", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
