using System;

namespace ReplaceInheritanceWithDelegation_After
{
    // Class Logger giữ nguyên
    class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[LOG]: {message}");
        }

        public void ClearLogs()
        {
            Console.WriteLine("Logs cleared!");
        }
    }

    // Printer KHÔNG còn kế thừa Logger
    class Printer
    {
        private readonly Logger _logger = new Logger(); // ✅ Composition

        public void Print(string text)
        {
            Console.WriteLine($"Printing: {text}");
            _logger.Log("Printed successfully."); // ✅ Delegation
        }
    }

    class Program
    {
        static void Main()
        {
            Printer printer = new Printer();
            printer.Print("Invoice #1001");
        }
    }
}

