using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_ExtractClass
{
    public class TelephoneNumber
    {
        private string officeAreaCode;
        private string officeNumber;

        public TelephoneNumber(string areaCode, string number)
        {
            officeAreaCode = areaCode;
            officeNumber = number;
        }

        public string GetTelephoneNumber()
        {
            return "(" + officeAreaCode + ") " + officeNumber;
        }
    }

}
