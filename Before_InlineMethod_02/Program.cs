using System;
namespace Before_InlineMethod_02
{
    class Program
    {
        static void Main()
        {
            PizzaDelivery pizza1 = new PizzaDelivery(3);
            PizzaDelivery pizza2 = new PizzaDelivery(8);

            Console.WriteLine($"Pizza 1 rating: {pizza1.GetRating()}");
            Console.WriteLine($"Pizza 2 rating: {pizza2.GetRating()}");

            Console.ReadKey();
        }

    }
}