class Address
{
    private String _street;
    private String _city;
    private String _state;
    private String _country;

    public Address(String street, String city, String state, String country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsLocal()
    {
        return _country == "USA";
    }

    public void DisplayAddress()
    {
        Console.WriteLine(_street);
        Console.WriteLine(_city + ", " + _state);
        Console.WriteLine(_country);
    }
}