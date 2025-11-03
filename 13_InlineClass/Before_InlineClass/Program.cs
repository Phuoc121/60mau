using System;

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

class Program
{
    static void Main()
    {
        Person person = new Person("Alice", "04", "555-1234");
        Console.WriteLine(person.GetName() + " - " + person.GetTelephoneNumber());
    }
}
