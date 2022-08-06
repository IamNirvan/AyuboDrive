using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive
{
    class Hire
    {
        private int BookingID;
        private DateTime StartDate;
        private DateTime EndDate;
        private double TotalCost;
        private string HireType;
        private VehicleType BookingVehicleType;
        private Customer BookingCustomer;
        private PackageType BookingPackageType;
        private const string connectionString = @"Data Source=DESKTOP-0CECDCR;Initial Catalog=AyuboDriveV1;Integrated Security=True";


        public Hire(int bookingID, DateTime startDate, DateTime endDate, double totalCost, string hireType, VehicleType bookingVehicleType, 
            Customer bookingCustomer, PackageType bookingPackageType)
        {
            BookingID = bookingID;
            StartDate = startDate;
            EndDate = endDate;
            TotalCost = totalCost;
            HireType = hireType;
            BookingVehicleType = bookingVehicleType;
            BookingCustomer = bookingCustomer;
            BookingPackageType = bookingPackageType;
        }

        public bool RegisterHire()
        {
            string query = "INSERT INTO HireBookings VALUES (@hireBookingID, @customerID, @packageID, @vehicleTypeID, @hireType, @startDate, @endDate, @bookingStatus, @totaCost)";

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@hireBookingID", BookingID);
                    sqlCommand.Parameters.AddWithValue("@customerID", BookingCustomer.CustomerID);
                    sqlCommand.Parameters.AddWithValue("@packageID", BookingPackageType.PackageID);
                    sqlCommand.Parameters.AddWithValue("@vehicleTypeID", BookingVehicleType.VehicleTypeID);
                    sqlCommand.Parameters.AddWithValue("@hireType", HireType);
                    sqlCommand.Parameters.AddWithValue("@startDate", StartDate);
                    sqlCommand.Parameters.AddWithValue("@endDate", EndDate);
                    sqlCommand.Parameters.AddWithValue("@bookingStatus", "active");
                    sqlCommand.Parameters.AddWithValue("@totaCost", 0);
                    sqlCommand.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e}", "An error occurred when regstering hire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool UpdateHire(int bookingID, DateTime startDate, DateTime endDate, string bookingStatus, double totalCost, string hireType, VehicleType bookingVehicleType,
            Customer bookingCustomer, PackageType bookingPackageType)
        {
            string query = "UPDATE HireBookings SET customerID = @customerID, packageID = @packageID, vehicleTypeID = @vehicleTypeID, " +
                "hireType = @hireType, startDate = @startDate, endDate = @endDate, bookingStatus = @bookingStatus, totalCost = @totaCost" +
                "WHERE hireBookingID = @hireBookingID";

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@hireBookingID", bookingID);
                    sqlCommand.Parameters.AddWithValue("@customerID", bookingCustomer.CustomerID);
                    sqlCommand.Parameters.AddWithValue("@packageID", bookingPackageType.PackageID);
                    sqlCommand.Parameters.AddWithValue("@vehicleTypeID", bookingVehicleType.VehicleTypeID);
                    sqlCommand.Parameters.AddWithValue("@hireType", hireType);
                    sqlCommand.Parameters.AddWithValue("@startDate", startDate);
                    sqlCommand.Parameters.AddWithValue("@endDate", endDate);
                    sqlCommand.Parameters.AddWithValue("@bookingStatus", bookingStatus);
                    sqlCommand.Parameters.AddWithValue("@totaCost", totalCost);
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

        public bool DeleteHire(int bookingID)
        {
            string query = "DELETE FROM HireBookings WHERE hireBookingID = @hireBookingID";

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@hireBookingID", bookingID);
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
