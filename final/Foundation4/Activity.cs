class Activity
{
    private String _date;
    private decimal _minutes;
    private String _sport;

    public Activity(String date, decimal minutes, String sport)
    {
        _date = date;
        _minutes = minutes;
        _sport = sport;
    }

    public String GetDate()
    {
        return _date;
    }

    public decimal GetMinutes()
    {
        return _minutes;
    }

    public virtual decimal GetSpeed()
    {
        return 0;
    }

    public virtual decimal GetDistance()
    {
        return 0;
    }

    public virtual decimal GetPace()
    {
        return 0;
    }

    public void GetSummary()
    {
        Console.WriteLine(_date + " " + _sport + " (" + _minutes + "min)- Distance: " + Math.Round(GetDistance(), 2) + " km, Speed: " + Math.Round(GetSpeed(), 2) + " kph, Pace: " + Math.Round(GetPace(), 2) + " min per km");
    }
}