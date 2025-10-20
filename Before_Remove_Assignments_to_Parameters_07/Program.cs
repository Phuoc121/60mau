using System;

class DiscountCalculator
{
    public int Discount(int inputVal, int quantity)
    {
        if (quantity > 50)
        {
            inputVal -= 2;
        }

        // Có thể còn các bước khác
        return inputVal;
    }
}

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
