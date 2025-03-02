class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome! Congratulations on choosing to be mindful today.\n");
        bool continueActivities = true;

        while (!continueActivities)
        {
            Console.WriteLine("Please choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            MedidationActivity activity = null;
            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    continueActivities = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    continue;
            }

            if (activity != null)
            {
                activity.StartActivity();
            }
        }
    }
}
