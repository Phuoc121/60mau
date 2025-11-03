class Customer
{
    public string Name { get; }
    public Currency Currency { get; }

    public Customer(string name, string currencyCode)
    {
        Name = name;
        Currency = new Currency(currencyCode);
    }
}