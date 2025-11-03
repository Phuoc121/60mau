using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_ExtractClass
{
    public class Person
    {
        private string name;
        private TelephoneNumber telephoneNumber;

        public Person(string name, string areaCode, string number)
        {
            this.name = name;
            this.telephoneNumber = new TelephoneNumber(areaCode, number);
        }

        public string GetName()
        {
            return name;
        }

        public string GetTelephoneNumber()
        {
            return telephoneNumber.GetTelephoneNumber();
        }
    }
}
