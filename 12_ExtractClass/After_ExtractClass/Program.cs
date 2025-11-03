using System;


namespace After_ExtractClass
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