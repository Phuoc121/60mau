using System;

class Customer
{
    public string GetContact()
    {
        // Không có thông tin ngày => không thể xác định liên hệ phù hợp
        return "Contact information not time-specific.";
    }
}

class Program
{
    static void Main()
    {
        Customer customer = new Customer();
        Console.WriteLine(customer.GetContact());
    }
}