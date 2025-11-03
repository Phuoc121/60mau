using System;

namespace ExtractInterface_After
{
    // Bước 1: Tạo interface chứa phần chung
    public interface IVehicle
    {
        void Start();
        void Stop();
    }

    // Bước 2: Các lớp implement interface này
    public class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car started");
        }

        public void Stop()
        {
            Console.WriteLine("Car stopped");
        }
    }

    public class Motorcycle : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Motorcycle started");
        }

        public void Stop()
        {
            Console.WriteLine("Motorcycle stopped");
        }
    }

    // Bước 3: Dùng interface thay vì dùng cụ thể class
    class Program
    {
        static void Main()
        {
            IVehicle vehicle1 = new Car();
            IVehicle vehicle2 = new Motorcycle();

            vehicle1.Start();
            vehicle1.Stop();

            vehicle2.Start();
            vehicle2.Stop();
        }
    }
}