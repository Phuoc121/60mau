using System;
using System.Collections.Generic;

namespace After_Substitute_Algorithm_09
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== AFTER REFACTORING ===");

            Finder finder = new Finder();

            string[] people1 = { "Lisa", "Kent", "Bob" };
            string[] people2 = { "Sarah", "John" };
            string[] people3 = { "Tom", "Jerry" };

            Console.WriteLine(finder.FoundPerson(people1)); // Kent
            Console.WriteLine(finder.FoundPerson(people2)); // John
            Console.WriteLine(finder.FoundPerson(people3)); // ""
        }
    }
}