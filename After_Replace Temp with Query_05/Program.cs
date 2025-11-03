using System;

namespace After_Replace_Temp_with_Query_05
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== AFTER REFACTORING ===");
            Order order1 = new Order(5, 150);
            Order order2 = new Order(20, 60);

            order1.PrintInvoice();
            Console.WriteLine();
            order2.PrintInvoice();
        }
    }
}