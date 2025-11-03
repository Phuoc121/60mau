using System;

namespace After_InlineClass
{

    class Program
    {
        static void Main()
        {
            Person person = new Person("Alice", "04", "555-1234");
            Console.WriteLine(person.GetName() + " - " + person.GetTelephoneNumber());
        }
    }
}