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

    // ✅ Solution: thay biến tạm bằng hàm (Replace Temp with Query)
    private double Perimeter()
    {
        return 2 * (height + width);
    }

    private double Area()
    {
        return height * width;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Perimeter (chu vi): " + Perimeter());
        Console.WriteLine("Area (diện tích): " + Area());
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== AFTER REFACTORING ===");
        Rectangle rect = new Rectangle(5, 10);
        rect.PrintInfo();
    }
}
