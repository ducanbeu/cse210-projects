class Running : Activity
{
    private decimal _distance;

    public Running(decimal distance, String date, decimal minutes) : base(date, minutes, "Running")
    {
        _distance = distance;
    }

    public override decimal GetDistance()
    {
        return _distance;
    }

    public override decimal GetSpeed()
    {
        return (_distance / GetMinutes()) * 60;
    }

    public override decimal GetPace()
    {
        return GetMinutes() / _distance;
    }
}