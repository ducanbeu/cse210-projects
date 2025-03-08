class Shape
{
    private String _color;

    public String GetColor()
    {
        return _color;
    }

    public void SetColor(String color)
    {
        _color = color;
    }

    public virtual Double GetArea()
    {
        return 0;
    }
}