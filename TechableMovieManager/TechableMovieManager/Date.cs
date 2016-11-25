using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManager
{
    static class Date
    {
        public static DateTime dateAfter(int numOfDays)
        {
            return DateTime.Now.AddDays(numOfDays);
        }

        public static DateTime today()
        {
            return DateTime.Now;
        }

        public static int daysUntil(DateTime day)
        {
            return (int) today().Subtract(day).TotalDays;
        }
    }
}
