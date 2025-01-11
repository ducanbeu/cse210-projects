using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string rawGrade = Console.ReadLine();

        int grade = int.Parse(rawGrade);

        string letter;
        if (grade > 89)
        {
            letter = "A";
        }
        else if (grade > 79)
        {
            letter = "B";
        }
        else if (grade > 69)
        {
            letter = "C";
        }
        else if (grade > 59)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You got a(n) {letter}");

        if (grade > 69)
        {
            Console.WriteLine("Congratulations!");
        }
        else
        {
            Console.WriteLine("You'll do better next time!");
        }
    }
}