using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("John Doe", 100, "Lecturing for lectures sake", "John will be giving a lecture on lecturing, prepare to be lectured", "1 April 2025", "5:00 AM", "1 Main St Provo UT");
        Reception reception = new Reception("john@mail.com", "John and Jane are getting married", "This isn't the wedding, this is the celebration afterwards", "1 May 2025", "8:00 PM", "2 Main St Provo UT");
        Outdoor outdoor = new Outdoor("Toasty Warm", "Games in the park", "Just like the title says, we'll be playing games; in the park", "1 June 2025", "1:00 PM ", "3 Main St Provo UT");

        Console.WriteLine("-----------------------");
        Console.WriteLine("Display Details: ");
        lecture.DisplayDetails();
        Console.WriteLine("Display Full Details: ");
        lecture.DisplayFullDetails();
        Console.WriteLine("Display Short Details: ");
        lecture.DisplayShortDescription();
        Console.WriteLine("-----------------------");

        Console.WriteLine("-----------------------");
        Console.WriteLine("Display Details: ");
        reception.DisplayDetails();
        Console.WriteLine("Display Full Details: ");
        reception.DisplayFullDetails();
        Console.WriteLine("Display Short Details: ");
        reception.DisplayShortDescription();
        Console.WriteLine("-----------------------");

        Console.WriteLine("-----------------------");
        Console.WriteLine("Display Details: ");
        outdoor.DisplayDetails();
        Console.WriteLine("Display Full Details: ");
        outdoor.DisplayFullDetails();
        Console.WriteLine("Display Short Details: ");
        outdoor.DisplayShortDescription();
        Console.WriteLine("-----------------------");
    }
}