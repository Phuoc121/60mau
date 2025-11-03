using System;

public class Order
{
    private double amount;

    public Order(double amount)
    {
        this.amount = amount;
    }

    // ✅ Thay vì truyền tham số, tạo phương thức rõ nghĩa riêng biệt
    public void ProcessNormalOrder()
    {
        Console.WriteLine("Processing normal order: " + amount);
    }

    public void ProcessExpressOrder()
    {
        Console.WriteLine("Processing express order: " + amount);
    }

    public void ProcessInternationalOrder()
    {
        Console.WriteLine("Processing international order: " + amount);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Order o1 = new Order(500);
        o1.ProcessNormalOrder();

        Order o2 = new Order(800);
        o2.ProcessExpressOrder();

        Order o3 = new Order(1200);
        o3.ProcessInternationalOrder();
    }
}