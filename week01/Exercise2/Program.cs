using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        int A = 90;
        int B = 80;
        int C = 70;
        int D = 60;

        Console.Write("What is your Grade: ");
        string grade = Console.ReadLine();

        int g = int.Parse(grade);

        string letter = "";
        string symbol = "";

        int plusorminus = g % 10;

        if (g >= A)
        {
            letter = "A";
        }

        else if (g >= B)
        {
            letter = "B";
        }

        else if (g >= C)
        {
            letter = "C";
        }

        else if (g >= D)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        if (g <= 93 && g >= 70)
        {
            if (plusorminus >= 7)
            {
                symbol = "+";
            }

            else if (plusorminus <= 3)
            {
                symbol = "-";
            }

            else
            {
                symbol = "";
            }
        }

        if (g < C)
            {
                Console.WriteLine($"You got a {letter}{symbol}. You fail");
            }

            else if (g >= C)
            {
                Console.WriteLine($"You got a {letter}{symbol}. You pass");
            }
    }
}