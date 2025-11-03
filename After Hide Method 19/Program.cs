using System;

public class Account
{
    private double balance;

    public Account(double balance)
    {
        this.balance = balance;
    }

    // ✅ Vẫn public vì được gọi từ bên ngoài
    public void RecalculateInterest()
    {
        double interest = CalculateInterest();
        balance += interest;
    }

    // ✅ Ẩn đi, chỉ dùng trong nội bộ lớp
    private double CalculateInterest()
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

        // ❌ acc.CalculateInterest(); // Giờ bị ẩn, không thể gọi bên ngoài

        acc.RecalculateInterest();
        Console.WriteLine("Balance: " + acc.GetBalance());
    }
}
