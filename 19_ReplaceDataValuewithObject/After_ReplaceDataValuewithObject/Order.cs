

class Order
{
    private Customer customer;

    public Order(string customerName)
    {
        customer = new Customer(customerName);
    }

    public Customer GetCustomer()
    {
        return customer;
    }

    public void SetCustomer(Customer newCustomer)
    {
        customer = newCustomer;
    }
}
