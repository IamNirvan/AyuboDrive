using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyuboDrive.Engines
{
    public static class LongTourHireCalculator
    {
        private readonly static QueryHandler _queryHandler = new QueryHandler();

        public static decimal[] GetHireValue(string vehicleID, string driverID, string packageID, DateTime startDate, DateTime endDate, int endMileage)
        {
            decimal overnightCharge = 0m;
            decimal extraKmCharge = 0m;

            int duration = (endDate - startDate).Days;

            decimal baseCharge = GetVehicleStandardRate(vehicleID) + (GetDriverDailyRate(driverID) * duration);

            if(duration > 2)
            {
                int excessDuration = duration - 2;
                overnightCharge = (GetVehicleOvernightRate(vehicleID) + GetDriverOvernightRate(driverID)) * excessDuration; 
            }

            int distanceTravelled = endMileage - GetStartMileage(vehicleID);
            int maxKm = GetPackageMaxKm(packageID);

            if(distanceTravelled > maxKm)
            {
                int excessDistance = distanceTravelled - maxKm;
                extraKmCharge = excessDistance * GetPackageMaxKm(packageID);
            }

            return new decimal[] { baseCharge, overnightCharge, extraKmCharge};
        }

        private static int GetPackageMaxKm(string packageID)
        {
            return int.Parse(_queryHandler.SelectQueryHandler("SELECT maxKilometer from package WHERE packageID = '" + packageID + "'").Rows[0][0].ToString());
        }

        private static int GetStartMileage(string vehicleID)
        {
            return int.Parse(_queryHandler.SelectQueryHandler("SELECT mileage from vehicle WHERE vehicleID = '" + vehicleID + "'").Rows[0][0].ToString());
        }

        private static decimal GetVehicleStandardRate(string vehicleID)
        {
            return decimal.Parse(_queryHandler.SelectQueryHandler("SELECT standardPackageRate from vehicle WHERE vehicleID = '" + vehicleID + "'").Rows[0][0].ToString());
        }

        private static decimal GetDriverDailyRate(string driverID)
        {
            return decimal.Parse(_queryHandler.SelectQueryHandler("SELECT dailyRate from driver WHERE driverID = '" + driverID + "'").Rows[0][0].ToString());
        }

        private static decimal GetDriverOvernightRate(string driverID)
        {
            return decimal.Parse(_queryHandler.SelectQueryHandler("SELECT overnightRate from driver WHERE driverID = '" + driverID + "'").Rows[0][0].ToString());
        }

        private static decimal GetVehicleOvernightRate(string vehicleID)
        {
            return decimal.Parse(_queryHandler.SelectQueryHandler("SELECT overnightRate from vehicle WHERE vehicleID = '" + vehicleID + "'").Rows[0][0].ToString());
        }

    }
}
