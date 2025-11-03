using System;

class Customer
{
    public string GetContact(DateTime date)
    {
        // Bây giờ có thể trả về thông tin liên hệ dựa trên ngày
        if (date.DayOfWeek == DayOfWeek.Sunday)
            return "Contact closed on Sunday.";
        else
            return "Contact available on " + date.ToShortDateString();
    }
}

class Program
{
    static void Main()
    {
        Customer customer = new Customer();
        Console.WriteLine(customer.GetContact(DateTime.Now));
    }
}