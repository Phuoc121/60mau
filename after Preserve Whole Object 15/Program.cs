using System;

public class TemperatureRange
{
    public double Min { get; set; }
    public double Max { get; set; }

    public TemperatureRange(double min, double max)
    {
        Min = min;
        Max = max;
    }

    // ✅ Có thể thêm logic tiện ích trong class
    public bool IsInRange(double temp)
    {
        return temp >= Min && temp <= Max;
    }
}

public class Room
{
    private double currentTemperature;

    public Room(double currentTemperature)
    {
        this.currentTemperature = currentTemperature;
    }

    public double GetCurrentTemperature()
    {
        return currentTemperature;
    }
}

public class HeatingSystem
{
    // ✅ Thay vì truyền lẻ tẻ, ta truyền nguyên object
    public void Regulate(Room room, TemperatureRange range)
    {
        double currentTemp = room.GetCurrentTemperature();

        if (!range.IsInRange(currentTemp))
        {
            if (currentTemp < range.Min)
                Console.WriteLine("Turning on heater...");
            else
                Console.WriteLine("Turning off heater...");
        }
        else
        {
            Console.WriteLine("Temperature is optimal.");
        }
    }
}

public class Program
{
    static void Main(string[] args)
    {
        TemperatureRange range = new TemperatureRange(18, 24);
        Room room = new Room(20);

        HeatingSystem system = new HeatingSystem();
        system.Regulate(room, range);
    }
}