using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction(3, 4);
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
    }
}