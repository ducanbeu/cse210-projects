class ListingActivity : MedidationActivity
{
    private string[] _randomPrompts = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    ];

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void PerformActivity()
    {
        Random rand = new Random();
        string selectedPrompt = _randomPrompts[rand.Next(_randomPrompts.Length)];
        Console.WriteLine(selectedPrompt);
        Pause(5);

        Console.WriteLine("Start listing your thoughts. Press Enter after each item.");
        int itemCount = 0;
        int remainingTime = GetDuration();

        while (remainingTime > 0)
        {
            Console.WriteLine("Enter item: ");
            string _ = Console.ReadLine();
            itemCount++;
            remainingTime -= 5;
            Pause(5);
        }

        Console.WriteLine($"You listed {itemCount} items.");
    }
}