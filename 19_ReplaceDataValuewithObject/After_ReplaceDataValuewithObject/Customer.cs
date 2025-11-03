class Customer
{
    public string Name { get; private set; }

    public Customer(string name)
    {
        Name = name;
    }

    // Hành vi riêng của khách hàng có thể thêm ở đây
    public override string ToString()
    {
        return Name;
    }
}