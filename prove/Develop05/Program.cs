using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = [
            new SimpleGoal(0, "Fill out FAFSA", 100),
            new EternalGoal(1, "Scripture study", 50),
            new ChecklistGoal(2, "Exercise", 25, 5, 200),
        ];

        Console.Write("Start by giving your pet a name: ");
        String name = Console.ReadLine();
        Console.Write("And what kind of animal is ", name, "?");
        String species = Console.ReadLine();

        Pet pet = new Pet(name, species);
        pet.GetMood();
        
        Console.WriteLine("Select the corresponding number to a goal you would like to mark complete");
        int x = 0;
        int points = 0;
        while (x < 1)
        {
            foreach (var goal in goals)
            {
                goal.DisplayStatus();
            }
            Console.WriteLine("Type exit to close the app.");

            string selection = Console.ReadLine();
            if (selection == "exit")
            {
                return;
            }
            else
            {
                goals[int.Parse(selection)].Complete();
                points += goals[int.Parse(selection)].GetPoints();
            }

            pet.SetMood(points);
            pet.GetMood();
        }
    }
}