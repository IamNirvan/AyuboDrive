using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive
{
    class PackageType
    {
        private int PackageID;
        private string PackageName;
        private int MaxKm;
        private int MaxHour;
        private double ExtraKmRate;
        private double ExtraHourRate;
        private double StandardRate;
        private const string connectionString = @"Data Source=DESKTOP-0CECDCR;Initial Catalog=AyuboDriveV1;Integrated Security=True";

        public PackageType(int packageID, string packageName, int maxKm, int maxHour, double extraKmRate, double extraHourRate, double standardRate)
        {
            PackageID = packageID;
            PackageName = packageName;
            MaxKm = maxKm;
            MaxHour = maxHour;
            ExtraKmRate = extraKmRate;
            ExtraHourRate = extraHourRate;
            StandardRate = standardRate;
        }

        public bool RegisterPackageType()
        {
            string query = "INSERT INTO PackageType VALUES (@packageID, @packageName, @maxKm, @maxHour, @extraKmRate, @extraHourRate, @standardRate)";

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@packageID", PackageID);
                    sqlCommand.Parameters.AddWithValue("@packageName", PackageName);
                    sqlCommand.Parameters.AddWithValue("@maxKm", MaxKm);
                    sqlCommand.Parameters.AddWithValue("@maxHour", MaxHour);
                    sqlCommand.Parameters.AddWithValue("@extraKmRate", ExtraKmRate);
                    sqlCommand.Parameters.AddWithValue("@extraHourRate", ExtraHourRate);
                    sqlCommand.Parameters.AddWithValue("@standardRate", StandardRate);
                    sqlCommand.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e}", "An error occurred when regstering package type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool UpdatePackageType(int packageID, string packageName, int maxKm, int maxHour, double extraKmRate, double extraHourRate, double standardRate)
        {
            string query = "UPDATE PackageType SET packageName = @packageName, maxKm = @maxKm, maxHour = @maxHour, extraKmRate = @extraKmRate, " +
                "extraHourRate = @extraHourRate, standardRate = @standardRate WHERE packageID = @packageID";

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@packageID", packageID);
                    sqlCommand.Parameters.AddWithValue("@packageName", packageName);
                    sqlCommand.Parameters.AddWithValue("@maxKm", maxKm);
                    sqlCommand.Parameters.AddWithValue("@maxHour", maxHour);
                    sqlCommand.Parameters.AddWithValue("@extraKmRate", extraKmRate);
                    sqlCommand.Parameters.AddWithValue("@extraHourRate", extraHourRate);
                    sqlCommand.Parameters.AddWithValue("@standardRate", standardRate);
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

        public bool DeletePackageType(int packageID)
        {
            string query = "DELETE FROM PackageType WHERE packageID = @packageID";

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@packageID", packageID);
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
