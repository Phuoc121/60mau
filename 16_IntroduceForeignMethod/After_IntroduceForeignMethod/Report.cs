using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_IntroduceForeignMethod
{
    public class Report
    {
        private DateTime previousEnd;

        public Report(DateTime previousEnd)
        {
            this.previousEnd = previousEnd;
        }

        public void SendReport()
        {
            DateTime newStart = NextDay(previousEnd);
            Console.WriteLine($"Sending report starting from {newStart.ToShortDateString()}...");
        }

        private static DateTime NextDay(DateTime date)
        {
            return date.AddDays(1);
        }
    }
}
