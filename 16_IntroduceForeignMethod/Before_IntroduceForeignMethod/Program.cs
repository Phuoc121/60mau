using System;

public class Report
{
    private DateTime previousEnd;

    public Report(DateTime previousEnd)
    {
        this.previousEnd = previousEnd;
    }

    public void SendReport()
    {
        // Tính toán ngày kế tiếp trực tiếp trong hàm chính
        DateTime nextDay = new DateTime(
            previousEnd.Year,
            previousEnd.Month,
            previousEnd.Day + 1
        );

        Console.WriteLine($"Sending report starting from {nextDay.ToShortDateString()}...");
    }
}

class Program
{
    static void Main()
    {
        Report report = new Report(new DateTime(2025, 10, 18));
        report.SendReport();
    }
}
