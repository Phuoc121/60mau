
public class Customer
{
    public string Id { get; }
    public string Name { get; }

    public Customer(string id, string name)
    {
        Id = id;
        Name = name;
    }
}

public class Order
{
    public int OrderId { get; }
    public Customer Customer { get; }

    public Order(int orderId, Customer customer)
    {
        OrderId = orderId;
        Customer = customer;
    }
}

