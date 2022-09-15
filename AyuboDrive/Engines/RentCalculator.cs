using AyuboDrive.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyuboDrive.Engines
{
    class RentCalculator
    {
        private static QueryHandler _queryHandler = new QueryHandler();

        public static decimal GetRentValue(string vehicleID, DateTime rentedDate, DateTime returnedDate, string driverID)
        {
            int totalDays = (returnedDate - rentedDate).Days+1;
            int[] daysWeeksMonths = DayWeekMonthCalculator.GetDaysWeeksMonths(totalDays);
            decimal[] vehicleRates = GetVehicleRates(vehicleID);

            decimal rentValue = CalculateRentValue(daysWeeksMonths, vehicleRates);

            if (driverID != null)
            {
                rentValue += totalDays * GetDriverDailyRate();
            }
            return rentValue;
        }

        private static decimal CalculateRentValue(int[] daysWeeksMonths, decimal[] vehicleRates)
        {
            return (daysWeeksMonths[2] * vehicleRates[2]) +
                            (daysWeeksMonths[1] * vehicleRates[1]) +
                            (daysWeeksMonths[0] * vehicleRates[0]);
        }

        private static decimal[] GetVehicleRates(string vehicleID)
        {
            decimal[] result = new decimal[3];
            DataRow record = _queryHandler.SelectQueryHandler("SELECT dailyrate, weeklyRate, monthlyRate from vehicle WHERE vehicleID = '" 
                + vehicleID + "'").Rows[0];
            result[0] = decimal.Parse(record[0].ToString());
            result[1] = decimal.Parse(record[1].ToString());
            result[2] = decimal.Parse(record[2].ToString());
            return result;
        }

        private static decimal GetDriverDailyRate()
        {
            DataRow record = _queryHandler.SelectQueryHandler("SELECT dailyrate from driver").Rows[0];
            return decimal.Parse(record[0].ToString());
        }
    }
}
