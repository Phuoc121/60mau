using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Before_Replace_Temp_with_Query_05
{
    class Order
    {
        private int quantity;
        private double itemPrice;

        public Order(int quantity, double itemPrice)
        {
            this.quantity = quantity;
            this.itemPrice = itemPrice;
        }

        public double CalculateTotal()
        {
            double basePrice = quantity * itemPrice;

            if (basePrice > 1000)
            {
                return basePrice * 0.95;  // giảm 5%
            }
            else
            {
                return basePrice * 0.98;  // giảm 2%
            }
        }

        public void PrintInvoice()
        {
            Console.WriteLine($"Số lượng: {quantity}");
            Console.WriteLine($"Giá gốc: {quantity * itemPrice}");
            Console.WriteLine($"Tổng thanh toán: {CalculateTotal()}");
        }
    }
}
