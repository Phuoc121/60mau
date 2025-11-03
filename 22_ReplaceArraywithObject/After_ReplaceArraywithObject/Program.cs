using System;

namespace After_ReplaceArraywithObject
{

    class Program
    {
        static void Main()
        {
            // Thay vì dùng mảng, ta dùng đối tượng Performance
            Performance team = new Performance();
            team.Name = "Liverpool";
            team.Wins = 15;

            Console.WriteLine($"Team: {team.Name}");
            Console.WriteLine($"Wins: {team.Wins}");
        }
    }
}
