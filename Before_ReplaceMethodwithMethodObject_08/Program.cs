using System;

class DiscountCalculator
{
    public int Discount(int inputVal, int quantity)
    {
        if (quantity > 50)
        {
            inputVal -= 2;
        }

        return inputVal;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== BEFORE REFACTORING ===");

        DiscountCalculator calc = new DiscountCalculator();
        int input = 10;
        int discounted = calc.Discount(input, 60);

        Console.WriteLine($"Original inputVal: {input}");     // vẫn 10
        Console.WriteLine($"Discounted value: {discounted}"); // 8
    }
}
