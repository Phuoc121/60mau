using System;

namespace CollapseHierarchy_Before
{
    // Lớp cha
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

    // Lớp con nhưng không thêm gì mới
    public class Engineer : Employee
    {
        public Engineer(string name) : base(name)
        {
        }
    }

    class Program
    {
        static void Main()
        {
            Engineer engineer = new Engineer("Alice");
            engineer.Work();
        }
    }
}
