using System;

namespace ExtractInterface_Before
{
    class Car
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

    class Motorcycle
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

    class Program
    {
        static void Main()
        {
            Car car = new Car();
            car.Start();
            car.Stop();

            Motorcycle moto = new Motorcycle();
            moto.Start();
            moto.Stop();
        }
    }
}