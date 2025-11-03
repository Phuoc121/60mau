class Order
{
    private string customer;

    public Order(string customer)
    {
        this.customer = customer;
    }

    public string GetCustomer()
    {
        return customer;
    }

    public void SetCustomer(string newCustomer)
    {
        customer = newCustomer;
    }
}
