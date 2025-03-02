abstract class MedidationActivity
{
    private int _duration;
    private string _name;
    private string _description;

    public MedidationActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} activity!");
        Console.WriteLine(_description);
        Console.WriteLine("Please enter the duration for this activity in seconds: ");
        _duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Pause(3);

        PerformActivity();

        Console.WriteLine("Good job! You've completed the activity.");
        Console.WriteLine($"Duration: {_duration} seconds.");
        Pause(3);
    }

    public void Pause(int seconds)
    {
        
        for (int i = 0; i < seconds; i++)
        {
            string progress = new string('.', seconds-i);
            Console.Write(progress);
            Thread.Sleep(1000);
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', progress.Length));
            Console.SetCursorPosition(0, Console.CursorTop);
        }
        Console.WriteLine();
    }

    public int GetDuration()
    {
        return _duration;
    }

    public abstract void PerformActivity();
}
