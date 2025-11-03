using System;

public class Product
{
    private double price;
    private double discount;

    public Product(double price, double discount)
    {
        this.price = price;
        this.discount = discount;
    }

    public double GetDiscount()
    {
        return discount;
    }

    // ✅ Không cần truyền discount, gọi trực tiếp bên trong
    public double GetFinalPrice()
    {
        return price - (price * GetDiscount());
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Product p = new Product(1000, 0.1);

        // Gọi trực tiếp, không cần truyền discount
        double finalPrice = p.GetFinalPrice();
        Console.WriteLine("Final Price: " + finalPrice);
    }
}
