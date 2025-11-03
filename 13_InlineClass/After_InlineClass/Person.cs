using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_InlineClass
{
    public class Person
    {
        private string name;
        private string officeAreaCode;
        private string officeNumber;

        public Person(string name, string areaCode, string number)
        {
            this.name = name;
            this.officeAreaCode = areaCode;
            this.officeNumber = number;
        }

        public string GetName()
        {
            return name;
        }

        public string GetTelephoneNumber()
        {
            return "(" + officeAreaCode + ") " + officeNumber;
        }
    }
}
