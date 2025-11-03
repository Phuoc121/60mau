using System;

namespace After_IntroduceForeignMethod
{

    class Program
    {
        static void Main()
        {
            Report report = new Report(new DateTime(2025, 10, 18));
            report.SendReport();
        }
    }
}