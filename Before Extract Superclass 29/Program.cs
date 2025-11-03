using System;

namespace RefactoringExample
{
    // Hai lớp có nhiều phần giống nhau
    class Manager
    {
        public string Name;
        public double Salary;

        public Manager(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public void Work()
        {
            Console.WriteLine($"{Name} is managing the team.");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Salary: {Salary}");
        }
    }

    class Engineer
    {
        public string Name;
        public double Salary;

        public Engineer(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public void Work()
        {
            Console.WriteLine($"{Name} is developing software.");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Salary: {Salary}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager("Alice", 9000);
            Engineer e = new Engineer("Bob", 7000);

            m.ShowInfo();
            e.ShowInfo();

            m.Work();
            e.Work();
        }
    }
}