class Pet 
{
    private String _name;
    private String _species;
    private String _mood;

    public Pet(String name, String species)
    {
        _name = name;
        _species = species;
        _mood = "Hungry";
        Console.WriteLine("Welcome! Your goal is to keep your pet ", _species, ", ", _name, " alive. You do this by completing your goals! In order to keep ", _name, " alive, you'll need to keep them fed daily--completing your daily goals is how you feed them. Giving them more food makes them happier, so keep them nice and full by accomplishing all of you goals for each day!");
    }

    public void GetMood()
    {
        Console.WriteLine(_name, " is ", _mood);
    }

    public void SetMood(int points)
    {
        if (points > 100)
        {
            _mood = "Full and happy";
        }
        else if (points > 200)
        {
            _mood = "Starting to trust you";
        }
        else if (points > 300)
        {
            _mood = "Your best friend";
        }
        else
        {
            _mood = "Hungry";
        }
    }
}