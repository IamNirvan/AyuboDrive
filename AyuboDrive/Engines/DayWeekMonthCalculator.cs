using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyuboDrive.Utility
{
    static class DayWeekMonthCalculator
    {
        public static int[] GetDaysWeeksMonths(int days)
        {
            int months = 0;
            int weeks = 0;

            while(days >= 7)
            {
                days -= 7;
                weeks++;

                if(weeks == 4)
                {
                    months++;
                    weeks = 0;
                }
            }
            return new int[] {days, weeks, months};
        }
    }
}
