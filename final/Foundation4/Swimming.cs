class Swimming : Activity
{
    private decimal _laps;

    public Swimming(decimal laps, String date, decimal minutes) : base(date, minutes, "Swimming")
    {
        _laps = laps;
    }

    public override decimal GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override decimal GetSpeed()
    {
        return _laps * 50 / 1000 / GetMinutes() * 60;
    }

    public override decimal GetPace()
    {
        return 60 / _laps * 50 / 1000 / GetMinutes() * 60;
    }
}