using System;

public class Order
{
    // ❌ Nhiều phương thức có cùng nhóm tham số lặp lại (startDate, endDate)
    public void CreateReport(DateTime startDate, DateTime endDate)
    {
        Console.WriteLine($"Creating report from {startDate.ToShortDateString()} to {endDate.ToShortDateString()}");
    }

    public double CalculateRevenue(DateTime startDate, DateTime endDate)
    {
        Console.WriteLine($"Calculating revenue from {startDate.ToShortDateString()} to {endDate.ToShortDateString()}");
        return 5000.0; // ví dụ minh họa
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Order order = new Order();
        DateTime start = new DateTime(2025, 1, 1);
        DateTime end = new DateTime(2025, 1, 31);

        order.CreateReport(start, end);
        order.CalculateRevenue(start, end);
    }
}
