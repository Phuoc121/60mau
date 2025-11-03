using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_Replace_Temp_with_Query_05
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

        private double BasePrice()
        {
            return quantity * itemPrice;
        }

        public double CalculateTotal()
        {
            if (BasePrice() > 1000)
            {
                return BasePrice() * 0.95;  // giảm 5%
            }
            else
            {
                return BasePrice() * 0.98;  // giảm 2%
            }
        }

        public void PrintInvoice()
        {
            Console.WriteLine($"Số lượng: {quantity}");
            Console.WriteLine($"Giá gốc: {BasePrice()}");
            Console.WriteLine($"Tổng thanh toán: {CalculateTotal()}");
        }
    }
}
