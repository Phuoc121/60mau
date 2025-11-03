public class Customer
{
    public string Id { get; }
    public string Name { get; }

    public Customer(string id, string name)
    {
        Id = id;
        Name = name;
    }

    // Hai khách hàng được xem là bằng nhau nếu có cùng Id và Name
    public override bool Equals(object? obj)
    {
        if (obj is not Customer other) return false;
        return Id == other.Id && Name == other.Name;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Name);
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

