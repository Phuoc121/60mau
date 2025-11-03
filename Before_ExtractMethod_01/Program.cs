using System;
using System.Collections.Generic;

namespace Before_ExtractMethod_01
{

    class Program
    {
        static void Main()
        {
            // Tạo khách hàng
            Customer customer = new Customer("Alice");

            // Thêm các khoản nợ
            customer.AddPurchase(120.50);
            customer.AddPurchase(89.90);
            customer.AddPurchase(50.00);

            // In thông tin nợ
            customer.PrintOwing();

            Console.ReadKey();
        }
    }
}