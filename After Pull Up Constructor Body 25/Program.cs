using System;

public class Employee
{
    protected string Name;
    protected string Id;

    // ✅ Constructor của superclass chứa phần chung
    public Employee(string name, string id)
    {
        this.Name = name;
        this.Id = id;
    }
}

public class Manager : Employee
{
    private int Grade;

    // ✅ Gọi constructor của superclass để tránh lặp code
    public Manager(string name, string id, int grade)
        : base(name, id)
    {
        this.Grade = grade;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Manager: {Name}, ID: {Id}, Grade: {Grade}");
    }
}

public class Developer : Employee
{
    private string Language;

    // ✅ Gọi constructor superclass để tái sử dụng
    public Developer(string name, string id, string language)
        : base(name, id)
    {
        this.Language = language;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Developer: {Name}, ID: {Id}, Language: {Language}");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Manager m = new Manager("Alice", "M01", 5);
        Developer d = new Developer("Bob", "D01", "C#");

        m.ShowInfo();
        d.ShowInfo();
    }
}
