using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(500, "03 Nov 2025", 60);
        Cycling cycling = new Cycling(20, "01 July 2025", 120);
        Swimming swimming = new Swimming(10, "10 Dec 2024", 100);

        running.GetSummary();
        cycling.GetSummary();
        swimming.GetSummary();
    }
}