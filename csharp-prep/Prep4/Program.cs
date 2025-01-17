using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        bool incomplete = true;
        List<int> inputs = new List<int> {};
        while (incomplete == true)
        {
            Console.Write("Enter number: ");
            string rawInput = Console.ReadLine();
            int input = int.Parse(rawInput);
            if (input == 0)
            {
                Console.WriteLine($"The sum is: {inputs.Sum()}");
                Console.WriteLine($"The average is: {inputs.Sum()/inputs.Count}");
                Console.WriteLine($"The largest number is: {inputs.Max()}");
                incomplete = false;
            }
            else 
            {
                inputs.Add(input);
            }
        }
    }
}