using System;

public class Department
{
    private string manager;

    public Department(string manager)
    {
        this.manager = manager;
    }

    public string GetManager()
    {
        return manager;
    }
}

public class Person
{
    private Department department;

    public Person(Department department)
    {
        this.department = department;
    }

    public Department GetDepartment()
    {
        return department;
    }
}

class Client
{
    static void Main()
    {
        Department department = new Department("Mr. Smith");
        Person person = new Person(department);

        // Client phải biết cả Department để gọi manager
        Console.WriteLine("Manager: " + person.GetDepartment().GetManager());
    }
}
