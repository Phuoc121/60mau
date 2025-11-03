using System;

// ✅ Lớp cha có field chung
public class Unit
{
    protected int health;

    public Unit(int health)
    {
        this.health = health;
    }

    public void ShowHealth()
    {
        Console.WriteLine("Health: " + health);
    }
}

// Các lớp con không còn chứa field trùng lặp
public class Soldier : Unit
{
    public Soldier() : base(100) { }
}

public class Tank : Unit
{
    public Tank() : base(300) { }
}

public class Program
{
    static void Main(string[] args)
    {
        Soldier soldier = new Soldier();
        Tank tank = new Tank();

        Console.Write("Soldier "); soldier.ShowHealth();
        Console.Write("Tank "); tank.ShowHealth();
    }
}
