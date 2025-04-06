class Lecture : Event
{
    private String _speaker;
    private int _capacity;
    public Lecture(String speaker, int capacity, String title, String description, String date, String time, String address) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void DisplayFullDetails()
    {
        DisplayDetails();
        Console.WriteLine("Speaker: " + _speaker);
        Console.WriteLine("Capacity: " + _capacity);
    }

    public void DisplayShortDescription()
    {
        Console.WriteLine("Lecture");
        Console.WriteLine(GetTitle());
        Console.WriteLine(GetDate());
    }
}