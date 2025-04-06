 class Reception : Event
 {
    private String _email;
    public Reception(String email, String title, String description, String date, String time, String address) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public void DisplayFullDetails()
    {
        DisplayDetails();
        Console.WriteLine("RSVP @ " + _email);
    }

    public void DisplayShortDescription()
    {
        Console.WriteLine("Reception");
        Console.WriteLine(GetTitle());
        Console.WriteLine(GetDate());
    }
 }