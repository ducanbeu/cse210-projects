class Circle : Shape
{
    private Double _radius;
    public Circle(Double radius)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}