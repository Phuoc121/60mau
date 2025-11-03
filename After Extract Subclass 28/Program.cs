using System;

namespace RefactoringExample
{
    class JobItem
    {
        protected int unitPrice;
        protected int quantity;

        public JobItem(int unitPrice, int quantity)
        {
            this.unitPrice = unitPrice;
            this.quantity = quantity;
        }

        public virtual int GetTotalPrice()
        {
            return GetUnitPrice() * quantity;
        }

        public virtual int GetUnitPrice()
        {
            return unitPrice;
        }
    }

    // ✅ Subclass chỉ cho loại công việc có nhân viên (lao động)
    class LaborItem : JobItem
    {
        private Employee employee;

        public LaborItem(Employee employee, int quantity)
            : base(0, quantity) // Không có đơn giá cố định
        {
            this.employee = employee;
        }

        public override int GetUnitPrice()
        {
            return employee.GetRate();
        }

        public Employee GetEmployee()
        {
            return employee;
        }
    }

    class Employee
    {
        private int rate;
        public Employee(int rate)
        {
            this.rate = rate;
        }
        public int GetRate() => rate;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(50);

            JobItem material = new JobItem(30, 5);
            LaborItem labor = new LaborItem(e, 10);

            Console.WriteLine($"Material cost: {material.GetTotalPrice()}");
            Console.WriteLine($"Labor cost: {labor.GetTotalPrice()}");
        }
    }
}
