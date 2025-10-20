using System;

class Finder
{
    // ❌ Problem: nhiều câu điều kiện trùng lặp
    public string FoundPerson(string[] people)
    {
        for (int i = 0; i < people.Length; i++)
        {
            if (people[i] == "Don")
            {
                return "Don";
            }
            if (people[i] == "John")
            {
                return "John";
            }
            if (people[i] == "Kent")
            {
                return "Kent";
            }
        }
        return "";
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== BEFORE REFACTORING ===");

        Finder finder = new Finder();

        string[] people1 = { "Lisa", "Kent", "Bob" };
        string[] people2 = { "Sarah", "John" };
        string[] people3 = { "Tom", "Jerry" };

        Console.WriteLine(finder.FoundPerson(people1)); // Kent
        Console.WriteLine(finder.FoundPerson(people2)); // John
        Console.WriteLine(finder.FoundPerson(people3)); // ""
    }
}
