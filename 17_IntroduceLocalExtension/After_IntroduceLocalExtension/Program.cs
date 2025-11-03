using System;

namespace After_IntroduceLocalExtension
{
    class Program
    {
        static void Main()
        {
            MfDate today = new MfDate(new DateTime(2025, 10, 18));
            Console.WriteLine($"Today: {today}");

            DateTime tomorrow = today.NextDay();
            Console.WriteLine($"Tomorrow: {tomorrow.ToShortDateString()}");

            DateTime yesterday = today.PreviousDay();
            Console.WriteLine($"Yesterday: {yesterday.ToShortDateString()}");
        }
    }
}
