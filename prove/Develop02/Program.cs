using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person you interacted with today?",
            "What was the best part of your day?",
            "How did you see the hand of the Lord in your life today?",
            "If you had one thing you could do over today, what would it be?",
            "What is an aspect of the day that you want to remember 10 years from now?",
            "Describe a goal that you accomplished today.",
        };
        Random random = new Random();

        Console.WriteLine("Welcome to your journal!");
        while (1==1)
        {
            Console.WriteLine("Select the number for what you would like to do");
            Console.WriteLine("Don't worry about saving or loading. We've got that handled for you.");
            Console.WriteLine("1. Write an entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Delete journal entry");
            Console.WriteLine("4. Quit");

            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    int promptIndex = random.Next(prompts.Count);
                    string prompt = prompts[promptIndex];
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();
                    Entry entry = new Entry(prompt, response);
                    journal.AddEntry(entry.OutputEntry());
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    journal.DisplayEntries();
                    Console.WriteLine("Select the number for the entry you would like to remove: ");
                    string id  = Console.ReadLine();
                    journal.DeleteEntry(int.Parse(id));
                    break;
                case "4":
                    journal.CloseJournal();
                    return;
                default:
                    Console.WriteLine("That's an invalid input. Make sure to enter the number corresponding with what you would like to do");
                    break;
            }
        }
        
    }
}