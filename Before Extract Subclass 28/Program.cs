using System;

namespace RefactoringExample
{
    // Lớp JobItem: có cả công việc thuê nhân viên và công việc bình thường
    class JobItem
    {
        protected int unitPrice;
        protected int quantity;
        protected bool isLabor;
        protected Employee employee;

        public JobItem(int unitPrice, int quantity, bool isLabor, Employee employee)
        {
            this.unitPrice = unitPrice;
            this.quantity = quantity;
            this.isLabor = isLabor;
            this.employee = employee;
        }

        public virtual int GetTotalPrice()
        {
            return GetUnitPrice() * quantity;
        }

        public virtual int GetUnitPrice()
        {
            if (isLabor)
                return employee.GetRate();
            else
                return unitPrice;
        }

        public Employee GetEmployee()
        {
            return employee;
        }
    }

    class Employee
    {
        private int rate;
        public Employee(int rate) { this.rate = rate; }
        public int GetRate() => rate;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(50);
            JobItem item1 = new JobItem(30, 5, false, null); // vật liệu
            JobItem item2 = new JobItem(0, 10, true, e);     // lao động

            Console.WriteLine($"Material cost: {item1.GetTotalPrice()}");
            Console.WriteLine($"Labor cost: {item2.GetTotalPrice()}");
        }
    }
}
