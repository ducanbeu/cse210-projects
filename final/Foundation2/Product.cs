class Product
{
    private String _name;
    private int _id;
    private int _price;
    private int _quantity;

    public Product(String name, int id, int price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public String GetName()
    {
        return _name;
    }

    public int GetID()
    {
        return _id;
    }

    public int GetTotal()
    {
        return _price * _quantity;
    }
}