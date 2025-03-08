class Square : Shape
{
    private Double _side;

    public Square(Double side) 
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * 2;
    }
}