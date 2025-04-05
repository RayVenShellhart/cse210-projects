// I made it so that it would tell you how many times you did an activity.
using System;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Which Activity would you like to do?");
        Console.WriteLine("     1. Breathing Activity");
        Console.WriteLine("     2. Listing Activity");
        Console.WriteLine("     3. Reflecting Activity");
        
        string keepGoing = "Y";
        int breathing = 0;
        int listing = 0;
        int reflecting = 0;

        do
        {
            Console.Write("\nEnter activity number>");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                breathing++;
            }
            else if (answer == "2")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                listing++;
            }
            else if (answer == "3")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
                reflecting++;
            }
            else
            {
                Console.WriteLine("Not valid");
            }
            Console.Clear();
            Console.Write("Keep going?(Y/N)\n>");
            keepGoing = Console.ReadLine();
        } while (keepGoing.ToUpper() != "N");
        Console.WriteLine($"You did The breathing activity {breathing} times, the listing activity {listing} time, and the reflecting activity {reflecting} times.");
    }
}