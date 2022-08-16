using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive
{
    class HireBooking
    {

        private string BookingID { get; set; }
        private string BookingVehicleTypeID { get; set; }
        private string BookingCustomerID { get; set; }
        public string BookingPackageTypeID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        private int Duration { get; set; }
        private double TotalCost { get; set; }
        private string HireType { get; set; }
        private string BookingStatus { get; set; }
        private decimal BaseHireCharge { get; set; }
        private decimal ExtraKmCharge { get; set; }

        private const string CONNECTION_STRING = @"Data Source=DESKTOP-0CECDCR;Initial Catalog=AyuboDriveV1;Integrated Security=True";

        public HireBooking(string bookingID, DateTime startDate, DateTime endDate, double totalCost, string hireType, 
            string bookingVehicleType, string bookingCustomer, string bookingPackageType, string bookingStatus,
            decimal baseHireCharge, decimal extraKmCharge)
        {
            BookingID = bookingID;
            StartDate = startDate;
            EndDate = endDate;
            TotalCost = totalCost;
            HireType = hireType;
            BookingVehicleTypeID = bookingVehicleType;
            BookingCustomerID = bookingCustomer;
            BookingPackageTypeID = bookingPackageType;
            BookingStatus = bookingStatus;
            BaseHireCharge = baseHireCharge;
            ExtraKmCharge = extraKmCharge;
        }

        // TDOD: Modify the queries
        public bool RegisterHire()
        {
            string query = "INSERT INTO HireBookings VALUES (@hireBookingID, @customerID, @packageID, @vehicleTypeID, @hireType, " +
                "@startDate, @endDate, @bookingStatus, @totalCost, @baseHireCharge, @extraKmCharge, @excessKm)";

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(CONNECTION_STRING))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@hireBookingID", BookingID);
                    sqlCommand.Parameters.AddWithValue("@customerID", BookingCustomerID);
                    sqlCommand.Parameters.AddWithValue("@packageID", BookingPackageTypeID);
                    sqlCommand.Parameters.AddWithValue("@vehicleTypeID", BookingVehicleTypeID);
                    sqlCommand.Parameters.AddWithValue("@hireType", HireType);
                    sqlCommand.Parameters.AddWithValue("@startDate", StartDate);
                    sqlCommand.Parameters.AddWithValue("@endDate", EndDate);
                    sqlCommand.Parameters.AddWithValue("@bookingStatus", BookingStatus);
                    sqlCommand.Parameters.AddWithValue("@totalCost", TotalCost);
                    sqlCommand.Parameters.AddWithValue("@baseHireCharge", BaseHireCharge);
                    sqlCommand.Parameters.AddWithValue("@extraKmCharge", ExtraKmCharge);
                    //sqlCommand.Parameters.AddWithValue("@excessKm", ExcessKm);
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
                "hireType = @hireType, startDate = @startDate, endDate = @endDate, bookingStatus = @bookingStatus, totalCost = @totaCost," +
                "baseHireCharge = @baseHireCharge, extraKmCharge = @extraKmCharge, excessKmCharge = @excessKm WHERE hireBookingID = @hireBookingID";

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(CONNECTION_STRING))
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
                    sqlCommand.Parameters.AddWithValue("@baseHireCharge", BaseHireCharge);
                    sqlCommand.Parameters.AddWithValue("@extraKmCharge", ExtraKmCharge);
                    //sqlCommand.Parameters.AddWithValue("@excessKm", ExcessKm);
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
                using (SqlConnection sqlConnection = new SqlConnection(CONNECTION_STRING))
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

        public bool CloseBooking()
        {
            string query = "UPDATE HireBookings SET bookingStatus = @bookingStatus WHERE hireBookingID = @hireBookingID";

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(CONNECTION_STRING))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@hireBookingID", BookingID);
                    sqlCommand.Parameters.AddWithValue("@bookingStatus", "Inactive");
                    sqlCommand.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e}", "An error occurred when updating the booking status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool OpenBooking()
        {
            string query = "UPDATE HireBookings SET bookingStatus = @bookingStatus WHERE hireBookingID = @hireBookingID";

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(CONNECTION_STRING))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@hireBookingID", BookingID);
                    sqlCommand.Parameters.AddWithValue("@bookingStatus", "Active");
                    sqlCommand.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e}", "An error occurred when updating the booking status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public virtual decimal GetHireValue() { return 0; }
    }
}
