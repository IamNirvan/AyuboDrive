using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyuboDrive.Engines
{
    public static class DayTourHireCalculator
    {
        private readonly static QueryHandler _queryHandler = new QueryHandler();

        public static decimal[] GetHireValue(string vehicleID, string driverID, string packageID, DateTime startTime, DateTime endTime, int endMileage)
        {
            decimal waitingCharge = 0m;
            decimal extraKmCharge = 0m;

            int durationHours = (endTime - startTime).Hours;
            int durationDays = (endTime - startTime).Days;

            decimal baseCharge = GetVehicleStadardRate(vehicleID) + (GetDriverDailyRate(driverID) * durationDays);
            int maxDuration = GetPackageMaxHour(packageID);

            if (durationHours > maxDuration)
            {
                int excessDuration = durationHours - maxDuration;
                waitingCharge = excessDuration * GetPackageHourRate(packageID);
            }

            int maxKm = GetPackageMaxKm(packageID);
            int distanceTravelled = (endMileage - GetVehicleStartMileage(vehicleID));

            if (distanceTravelled > maxKm)
            {
                int excessDistance = distanceTravelled - maxKm;
                extraKmCharge = excessDistance * GetPackageKmRate(packageID);
            }
            
            return new decimal[] { baseCharge, waitingCharge, extraKmCharge};
        }

        private static int GetPackageMaxHour(string packageID)
        {
            return int.Parse(_queryHandler.SelectQueryHandler("SELECT maxHour from package WHERE packageID = '" + packageID +"'").Rows[0][0].ToString());
        }

        private static decimal GetDriverDailyRate(string driverID)
        {
            return decimal.Parse(_queryHandler.SelectQueryHandler("SELECT dailyRate from driver WHERE driverID = '" + driverID + "'").Rows[0][0].ToString());
        }

        private static int GetPackageMaxKm(string packageID)
        {
            return int.Parse(_queryHandler.SelectQueryHandler("SELECT maxKilometer from package WHERE packageID = '" + packageID +"'").Rows[0][0].ToString());
        }

        private static int GetVehicleStartMileage(string vehicleID)
        {
            return int.Parse(_queryHandler.SelectQueryHandler("SELECT mileage from vehicle WHERE vehicleID = '" + vehicleID +"'").Rows[0][0].ToString());
        }

        private static decimal GetPackageHourRate(string packageID)
        {
            return decimal.Parse(_queryHandler.SelectQueryHandler("SELECT extraHourRate from package WHERE packageID = '" + packageID +"'").Rows[0][0].ToString());
        }

        private static decimal GetPackageKmRate(string packageID)
        {
            return decimal.Parse(_queryHandler.SelectQueryHandler("SELECT extraKilometerRate from package WHERE packageID = '" + packageID +"'").Rows[0][0].ToString());
        }

        private static decimal GetVehicleStadardRate(string vehicleID)
        {
            return decimal.Parse(_queryHandler.SelectQueryHandler("SELECT standardPackageRate from vehicle WHERE vehicleID = '" + vehicleID + "'").Rows[0][0].ToString());
        }
    }
}
