using System;

public class Employee
{
    private string name;
    private string position;
    private double salary;

    // 🔒 Constructor private để ngăn gọi trực tiếp
    private Employee(string name, string position)
    {
        this.name = name;
        this.position = position;
    }

    // ✅ Factory Method thay thế constructor
    public static Employee Create(string name, string position)
    {
        Employee employee = new Employee(name, position);

        // Xử lý logic phức tạp ở đây
        if (position == "Manager")
            employee.salary = 5000;
        else if (position == "Developer")
            employee.salary = 3000;
        else
            employee.salary = 2000;

        Console.WriteLine("Employee created using factory method!");
        return employee;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {name}, Position: {position}, Salary: {salary}");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        // ✅ Gọi thông qua Factory Method
        Employee e1 = Employee.Create("Alice", "Manager");
        e1.ShowInfo();

        Employee e2 = Employee.Create("Bob", "Developer");
        e2.ShowInfo();
    }
}
