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
        public string PackageID { get; set; }
        private string PackageName { get; set; }
        public int MaxKm { get; set; }
        public int MaxHour { get; set; }
        public double ExtraKmRate { get; set; }
        public double ExtraHourRate { get; set; }
        private double StandardRate { get; set; }
        private static QueryHandler queryHandler = new QueryHandler();

        public PackageType(string packageID, string packageName, int maxKm, int maxHour, double extraKmRate, double extraHourRate, double standardRate)
        {
            PackageID = packageID;
            PackageName = packageName;
            MaxKm = maxKm;
            MaxHour = maxHour;
            ExtraKmRate = extraKmRate;
            ExtraHourRate = extraHourRate;
            StandardRate = standardRate;
        }

        public static PackageType RegisterPackageType(string packageName, int maxKm, int maxHour, double extraKmRate, double extraHourRate, double standardRate)
        {
            string packageID = "";
            string query = "INSERT INTO PackageType VALUES (@packageID, @packageName, @maxKm, @maxHour, @extraKmRate, @extraHourRate, @standardRate)";
            string[] parameters = { "@packageID", "@packageName", "@maxKm", "@maxHour", "@extraKmRate", " @extraHourRate", "@standardRate" };
            object[] values = { packageID, packageName, maxKm, maxHour, extraKmRate, extraHourRate, standardRate };

            if (queryHandler.HandleInsertDeleteUpdateQuery(query, parameters, values))
            {
                MessageBox.Show("Package type details successfully registered", "Registration successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return new PackageType(packageID, packageName, maxKm, maxHour, extraKmRate, extraHourRate, standardRate);
            }
            MessageBox.Show("Failed to register package type information", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        public void UpdatePackageType(string packageName, int maxKm, int maxHour, double extraKmRate, double extraHourRate, double standardRate)
        {
            string query = "UPDATE PackageType SET packageName = @packageName, maxKm = @maxKm, maxHour = @maxHour, extraKmRate = @extraKmRate, " +
                "extraHourRate = @extraHourRate, standardRate = @standardRate WHERE packageID = @packageID";
            string[] parameters = { "@packageName", "@maxKm", "@maxHour", "@extraKmRate", " @extraHourRate", "@standardRate", "PackageID"};
            object[] values = { packageName, maxKm, maxHour, extraKmRate, extraHourRate, standardRate, PackageID };

            if (queryHandler.HandleInsertDeleteUpdateQuery(query, parameters, values))
            {
                MessageBox.Show("Package type details successfully updated", "Update successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Failed to update package type information", "Update failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void DeletePackageType()
        {
            string query = "DELETE FROM PackageType WHERE packageID = @packageID";

            string[] parameters = { "PackageID" };
            object[] values = { PackageID };

            if (queryHandler.HandleInsertDeleteUpdateQuery(query, parameters, values))
            {
                MessageBox.Show("Package type details successfully deleted", "Delete successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Failed to delete package type information", "Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
