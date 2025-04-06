class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public Customer GetCustomer()
    {
        return _customer;
    }

    public List<Product> GetProducts()
    {
        return _products;
    }

    public int GetTotalCost()
    {
        int price = 0;
        if (!_customer.IsLocal())
        {
            price += 35;
        }
        foreach (var product in _products)
        {
            price += product.GetTotal();
        }
        return price;
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine("Products:");
        foreach (var product in _products)
        {
            Console.WriteLine("     Name: " + product.GetName());
            Console.WriteLine("     ID: " + product.GetID());
        }
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine(_customer.GetName());
        _customer.GetAddress().DisplayAddress();
    }
}