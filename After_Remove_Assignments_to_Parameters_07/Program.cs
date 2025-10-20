using System;

namespace After_Remove_Assignments_to_Parameters_07
{
class Program
{
    static void Main()
    {
        Console.WriteLine("=== BEFORE REFACTORING ===");

        DiscountCalculator calc = new DiscountCalculator();
        int originalValue = 10;

        int result = calc.Discount(originalValue, 60);

        Console.WriteLine($"Original inputVal: {originalValue}"); // vẫn 10, nhưng logic gây nhầm lẫn
        Console.WriteLine($"Discounted value: {result}");
    }
}
}