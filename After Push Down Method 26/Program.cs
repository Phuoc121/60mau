using System;

namespace RefactoringExample
{
    // Superclass
    class Unit
    {
        // No longer has GetFuel()
    }

    // Subclass 1
    class Soldier : Unit
    {
        public void Attack()
        {
            Console.WriteLine("Soldier attacking with rifle!");
        }
    }

    // Subclass 2
    class Tank : Unit
    {
        public void GetFuel()
        {
            Console.WriteLine("Tank checking fuel level...");
        }

        public void FireCannon()
        {
            Console.WriteLine("Tank firing cannon!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Soldier soldier = new Soldier();
            Tank tank = new Tank();

            soldier.Attack();
            tank.GetFuel();  // Only Tank has this method now
            tank.FireCannon();
        }
    }
}
