using System;

// ✅ Tạo lớp ngoại lệ riêng
public class BalanceException : Exception
{
    public BalanceException(string message) : base(message) { }
}

public class Account
{
    private int balance;

    public Account(int initialBalance)
    {
        balance = initialBalance;
    }

    // ✅ Thay vì trả mã lỗi, ném Exception
    public void Withdraw(int amount)
    {
        if (amount > balance)
        {
            throw new BalanceException("Số tiền rút vượt quá số dư cho phép!");
        }
        balance -= amount;
    }

    public int GetBalance()
    {
        return balance;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Account acc = new Account(1000);

        try
        {
            acc.Withdraw(1500);
            Console.WriteLine("✅ Rút tiền thành công. Số dư còn lại: " + acc.GetBalance());
        }
        catch (BalanceException ex)
        {
            Console.WriteLine("❌ Lỗi: " + ex.Message);
        }
    }
}
