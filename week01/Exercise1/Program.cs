using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise1 Project.");
        // Console.WriteLine("This is C#");

        // int number = 5;
        // Console.WriteLine(number);
        // number = 8;
        // Console.WriteLine(number);
        // number = number + 3;
        // Console.WriteLine(number);

        // string color = "blue";

        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();

        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");
    }
}