using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        // While loop
        // string response = "yes";
        // while (response == "yes")
        // {
        //     Console.Write("Do you want to continue? ");
        //     response = Console.ReadLine();
        // }

        // Do-while loops
        // string response;
        // do
        // {
        //     Console.Write("Do you want me to continue? ");
        //     response = Console.ReadLine();
        // } while (response == "yes");

        // for loop
        // for (int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // foreach loop
        // foreach (string color in colors)
        // {
        //     Console.WriteLine(color);
        // }

        // random
        // Random randomgenerator = new Random();
        // int number = randomgenerator.Next(1, 11);

        string playagain = "yes";
        do
        {
            int guess = -1;
            int guesses = 0;
            Random randomgenerator = new Random();
            int magic = randomgenerator.Next(1, 100);

            while (guess != magic)
            {
                Console.Write("What is your guess? ");
                string numberguess = Console.ReadLine();
                guess = int.Parse(numberguess);

                if (guess > magic)
                {
                    Console.WriteLine("Lower");
                    guesses++;
                }

                else if (guess < magic)
                {
                    Console.WriteLine("higher");
                    guesses++;
                }

                else
                {
                    Console.WriteLine("You win.");
                    guesses++;
                    Console.WriteLine($"You took {guesses} guesses.");
                    Console.Write("Would you like to play again? ");
                    playagain = Console.ReadLine();
                }


            }
        } while (playagain != "no");
        
        
    }
}