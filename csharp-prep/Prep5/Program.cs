using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int inputNumber = PromptUserNumber();
        int squared = SquareNumber(inputNumber);
        DisplayResult(squared, name);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int input)
    {
        return input * input;
    }

    static void DisplayResult(int squared, string name)
    {
        Console.WriteLine($"{name}, the square of your number is {squared}");
    }
}