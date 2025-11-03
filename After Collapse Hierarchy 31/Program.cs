using System;

namespace CollapseHierarchy_After
{
    public class Employee
    {
        public string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }

        public void Work()
        {
            Console.WriteLine($"{Name} is working.");
        }
    }

    class Program
    {
        static void Main()
        {
            // Không còn lớp Engineer — dùng Employee trực tiếp
            Employee employee = new Employee("Alice");
            employee.Work();
        }
    }
}
