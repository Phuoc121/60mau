using System;

class Program
{
    static void Main()
    {
        // Dữ liệu đội bóng được lưu trong mảng
        string[] row = new string[2];
        row[0] = "Liverpool";  // Tên đội bóng
        row[1] = "15";         // Số trận thắng

        Console.WriteLine("Team: " + row[0]);
        Console.WriteLine("Wins: " + row[1]);
    }
}
