using System;

class Program
{
    static void Main(string[] args)
    {
        bool incorrect = true;
        Random random = new();
        int magicNum = random.Next(101);
        Console.Write("What is your guess? ");
        string rawGuess = Console.ReadLine();
        int guess = int.Parse(rawGuess);

        while (incorrect == true)
        {
            if (guess > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                incorrect = false;
            }
        }
    }
}