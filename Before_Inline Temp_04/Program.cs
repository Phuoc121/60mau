using System;

class Order
{
    private double unitPrice;
    private int quantity;

    public Order(double unitPrice, int quantity)
    {
        this.unitPrice = unitPrice;
        this.quantity = quantity;
    }

    public double BasePrice()
    {
        return unitPrice * quantity;
    }
}

class Program
{
    static bool HasDiscount(Order order)
    {
        double basePrice = order.BasePrice(); // biến tạm không cần thiết
        return basePrice > 1000;
    }

    static void Main()
    {
        Order order1 = new Order(50, 10);   // BasePrice = 500
        Order order2 = new Order(200, 6);   // BasePrice = 1200

        Console.WriteLine($"Order 1 has discount: {HasDiscount(order1)}");
        Console.WriteLine($"Order 2 has discount: {HasDiscount(order2)}");

        Console.ReadKey();
    }
}
