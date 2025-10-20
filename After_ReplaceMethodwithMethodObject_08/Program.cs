using System;

namespace After_ReplaceMethodwithMethodObject_08
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== AFTER REFACTORING ===");

            DiscountCalculator calc = new DiscountCalculator();
            int input = 10;
            int discounted = calc.Discount(input, 60);

            Console.WriteLine($"Original inputVal: {input}");     // 10
            Console.WriteLine($"Discounted value: {discounted}"); // 8
        }
    }
}
