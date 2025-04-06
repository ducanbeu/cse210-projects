class Cycling : Activity
{
    private decimal _speed;
    
    public Cycling(decimal speed, String date, decimal minutes) : base(date, minutes, "Cycling")
    {
        _speed = speed;
    }

    public override decimal GetDistance()
    {
        return _speed / 60 * GetMinutes();
    }

    public override decimal GetSpeed()
    {
        return _speed;
    }

    public override decimal GetPace()
    {
        return 60 / _speed;
    }
}