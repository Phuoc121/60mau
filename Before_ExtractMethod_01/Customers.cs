using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Before_ExtractMethod_01
{
    class Customer
    {
        private string name;
        private List<double> purchases = new List<double>();

        public Customer(string name)
        {
            this.name = name;
        }

        public void AddPurchase(double amount)
        {
            purchases.Add(amount);
        }

        // Tính tổng số tiền nợ (outstanding)
        public double GetOutstanding()
        {
            double total = 0;
            foreach (var amount in purchases)
            {
                total += amount;
            }
            return total;
        }

        // In tiêu đề
        private void PrintBanner()
        {
            Console.WriteLine("**************************");
            Console.WriteLine("**** Customer Owes ******");
            Console.WriteLine("**************************");
        }

        // PHIÊN BẢN TRƯỚC KHI REFACTOR
        public void PrintOwing()
        {
            this.PrintBanner();

            // Print details.
            Console.WriteLine("name: " + this.name);
            Console.WriteLine("amount: " + this.GetOutstanding());
        }
    }
}
