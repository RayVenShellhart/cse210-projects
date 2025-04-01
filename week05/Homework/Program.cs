using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Sam", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Robert", "Fractions", "7.3", "8-9");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssingment a3 = new WritingAssingment("mary", "history", "World war II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInfo());
    }
}