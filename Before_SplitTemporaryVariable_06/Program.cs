using System;

class Rectangle
{
    private double height;
    private double width;

    public Rectangle(double height, double width)
    {
        this.height = height;
        this.width = width;
    }

    // ❌ Problem: Dùng biến tạm temp nhiều lần, mã không rõ ràng
    public void PrintInfo()
    {
        double temp = 2 * (height + width);
        Console.WriteLine("Perimeter (chu vi): " + temp);

        temp = height * width;
        Console.WriteLine("Area (diện tích): " + temp);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== BEFORE REFACTORING ===");
        Rectangle rect = new Rectangle(5, 10);
        rect.PrintInfo();
    }
}
