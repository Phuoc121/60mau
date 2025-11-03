using System;

// Lớp cha có chứa phương thức chung
public class Unit
{
    protected int health;

    // ✅ Phương thức được "kéo lên" lớp cha
    public int GetHealth()
    {
        return health;
    }
}

public class Soldier : Unit
{
    // Không cần định nghĩa lại GetHealth()
}

public class Tank : Unit
{
    // Không cần định nghĩa lại GetHealth()
}

public class Program
{
    static void Main(string[] args)
    {
        Soldier soldier = new Soldier();
        Tank tank = new Tank();

        Console.WriteLine("Soldier Health: " + soldier.GetHealth());
        Console.WriteLine("Tank Health: " + tank.GetHealth());
    }
}
