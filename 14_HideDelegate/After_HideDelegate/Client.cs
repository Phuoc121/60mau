using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_HideDelegate
{
    class Client
    {
        static void Main()
        {
            Department department = new Department("Mr. Smith");
            Person person = new Person(department);

            // Client chỉ biết Person, không cần quan tâm đến Department
            Console.WriteLine("Manager: " + person.GetManager());
        }
    }
}
