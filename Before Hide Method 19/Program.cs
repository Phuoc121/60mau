using System;

public class Account
{
    private double balance;

    public Account(double balance)
    {
        this.balance = balance;
    }

    // ❌ Phương thức này chỉ dùng nội bộ, nhưng được public
    public void RecalculateInterest()
    {
        double interest = CalculateInterest();
        balance += interest;
    }

    // ❌ Nên là private, vì chỉ được gọi trong nội bộ lớp
    public double CalculateInterest()
    {
        return balance * 0.05;
    }

    public double GetBalance()
    {
        return balance;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Account acc = new Account(1000);

        // Gọi được cả phương thức nội bộ — không nên
        acc.CalculateInterest();

        acc.RecalculateInterest();
        Console.WriteLine("Balance: " + acc.GetBalance());
    }
}
