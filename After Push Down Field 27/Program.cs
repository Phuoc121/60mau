using System;

namespace RefactoringExample
{
    // Superclass
    class Unit
    {
        public virtual void Move()
        {
            Console.WriteLine("Unit is moving...");
        }
    }

    // Subclass 1
    class Soldier : Unit
    {
        public void Attack()
        {
            Console.WriteLine("Soldier attacking!");
        }
    }

    // Subclass 2
    class Tank : Unit
    {
        private int fuel; // ✅ Field moved down to subclass

        public void FireCannon()
        {
            Console.WriteLine("Tank firing cannon!");
        }

        public void Refuel(int amount)
        {
            fuel += amount;
            Console.WriteLine($"Tank refueled. Current fuel: {fuel}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Soldier soldier = new Soldier();
            Tank tank = new Tank();

            soldier.Attack();
            tank.Refuel(100);
            tank.FireCannon();
        }
    }
}
