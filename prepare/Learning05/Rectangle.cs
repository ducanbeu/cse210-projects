class Rectangle : Shape 
{
    private Double _width;
    private Double _length;
    public Rectangle(Double width, Double length)
    {
        _width = width;
        _length = length;
    }

    public override double GetArea()
    {
        return _width * _length;
    }
}