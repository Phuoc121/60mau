class Currency
{
    public string Code { get; private set; }

    public Currency(string code)
    {
        Code = code;
    }
}

class Customer
{
    public string Name { get; private set; }
    public Currency Currency { get; private set; }

    public Customer(string name, Currency currency)
    {
        Name = name;
        Currency = currency;
    }
}
