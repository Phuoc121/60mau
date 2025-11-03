using System;

public class DateRange
{
    public DateTime Start { get; }
    public DateTime End { get; }

    public DateRange(DateTime start, DateTime end)
    {
        Start = start;
        End = end;
    }

    public override string ToString()
    {
        return $"{Start.ToShortDateString()} - {End.ToShortDateString()}";
    }
}

public class Order
{
    // ✅ Thay nhóm tham số lặp lại bằng một đối tượng chung (DateRange)
    public void CreateReport(DateRange range)
    {
        Console.WriteLine($"Creating report for: {range}");
    }

    public double CalculateRevenue(DateRange range)
    {
        Console.WriteLine($"Calculating revenue for: {range}");
        return 5000.0; // ví dụ minh họa
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Order order = new Order();
        DateRange january = new DateRange(new DateTime(2025, 1, 1), new DateTime(2025, 1, 31));

        order.CreateReport(january);
        order.CalculateRevenue(january);
    }
}