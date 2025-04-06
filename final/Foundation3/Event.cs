class Event
{
    private String _title;
    private String _description;
    private String _date;
    private String _time;
    private String _address;

    public Event(String title, String description, String date, String time, String address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public String GetTitle()
    {
        return _title;
    }

    public String GetDescription()
    {
        return _description;
    }

    public String GetDate()
    {
        return _date;
    }

    public String GetTime()
    {
        return _time;
    }

    public String GetAddress()
    {
        return _address;
    }

    public void DisplayDetails()
    {
        Console.WriteLine(_title);
        Console.WriteLine(_description);
        Console.WriteLine(_date);
        Console.WriteLine(_time);
        Console.WriteLine(_address);
    }
}