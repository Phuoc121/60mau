using System;

public class ClientClass
{
    public static DateTime NextDay(DateTime date)
    {
        return new DateTime(date.Year, date.Month, date.Day + 1);
    }

    public static void Main()
    {
        DateTime today = new DateTime(2025, 10, 18);
        DateTime tomorrow = NextDay(today);

        Console.WriteLine($"Today: {today.ToShortDateString()}");
        Console.WriteLine($"Tomorrow: {tomorrow.ToShortDateString()}");
    }
}
