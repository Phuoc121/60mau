using System;

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

    public string GetTelephoneNumber()
    {
        return "(" + officeAreaCode + ") " + officeNumber;
    }

    public string GetName()
    {
        return name;
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person("Alice", "04", "555-1234");
        Console.WriteLine(person.GetName() + " - " + person.GetTelephoneNumber());
    }
}
