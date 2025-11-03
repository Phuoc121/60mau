using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_IntroduceLocalExtension
{
    public class MfDate
    {
        private DateTime date;

        public MfDate(DateTime date)
        {
            this.date = date;
        }

        public DateTime NextDay()
        {
            return date.AddDays(1);
        }

        public DateTime PreviousDay()
        {
            return date.AddDays(-1);
        }

        public override string ToString()
        {
            return date.ToShortDateString();
        }
    }

}
