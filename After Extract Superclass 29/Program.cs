using System;

namespace RefactoringExample
{
    // ✅ Tạo lớp cha Employee chứa phần chung
    class Employee
    {
        public string Name;
        public double Salary;

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Salary: {Salary}");
        }

        // Có thể thêm phương thức ảo nếu lớp con cần override
        public virtual void Work()
        {
            Console.WriteLine($"{Name} is working...");
        }
    }

    // ✅ Lớp con kế thừa Employee và chỉ giữ phần riêng
    class Manager : Employee
    {
        public Manager(string name, double salary) : base(name, salary) { }

        public override void Work()
        {
            Console.WriteLine($"{Name} is managing the team.");
        }
    }

    class Engineer : Employee
    {
        public Engineer(string name, double salary) : base(name, salary) { }

        public override void Work()
        {
            Console.WriteLine($"{Name} is developing software.");
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
