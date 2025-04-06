class Customer
{
    private String _name;
    private Address _address;

    public Customer(String name, Address address)
    {
        _name = name;
        _address = address;
    }

    public String GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public bool IsLocal()
    {
        return _address.IsLocal();
    }
}