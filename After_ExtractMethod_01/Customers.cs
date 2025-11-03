using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_ExtractMethod_01
{
    public class Customers
    {
        private string name;
        private List<double> purchases = new List<double>();

        public Customers(string name)
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

        // Hàm in banner
        private void PrintBanner()
        {
            Console.WriteLine("**************************");
            Console.WriteLine("**** Customer Owes ******");
            Console.WriteLine("**************************");
        }

        // Hàm in chi tiết nợ
        private void PrintDetails()
        {
            Console.WriteLine("name: " + this.name);
            Console.WriteLine("amount: " + this.GetOutstanding());
        }

        // Hàm chính gọi banner + chi tiết
        public void PrintOwing()
        {
            this.PrintBanner();
            this.PrintDetails();
        }
    }
}
