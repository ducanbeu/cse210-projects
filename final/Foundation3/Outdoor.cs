class Outdoor : Event
{
    private String _forecast;
    public Outdoor(String forecast, String title, String description, String date, String time, String address) : base(title, description, date, time, address)
    {
        _forecast = forecast;
    }

    public void DisplayFullDetails()
    {
        DisplayDetails();
        Console.WriteLine("Current forecast: " + _forecast);
    }

    public void DisplayShortDescription()
    {
        Console.WriteLine("Outdoor gathering");
        Console.WriteLine(GetTitle());
        Console.WriteLine(GetDate());
    }
}