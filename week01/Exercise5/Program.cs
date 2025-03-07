using System;
using System.Globalization;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string username = PromptUsername();
        int numberRequest = PromptUserNumber();

        int squarednumber = SquareNumber(numberRequest);

        DisplayResults(username, squarednumber);


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to program.");
        }

        static string PromptUsername()
        {
            Console.Write("Please enter name: ");
            string username = Console.ReadLine();

            return username;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter favorite number: ");
            string numbers = Console.ReadLine();
            int number = int.Parse(numbers);

            return number;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;

            return square;
        }

        static void DisplayResults(string username, int squarednumber)
        {
            Console.WriteLine($"{username}, the square of your number is {squarednumber}.");
        }


    }
}