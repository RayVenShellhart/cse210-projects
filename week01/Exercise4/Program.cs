using System.Collections.Generic;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        // List<string> words = new List<string>();
        // words.Add("phone");
        // words.Add("keyboear");
        // words.Add("mouse");
        // Console.WriteLine(words.Count);
        // foreach (string word in words)
        // {
        //     Console.WriteLine(word);
        // }
        // for (int i = 0; i < words.Count; i++)
        // {
        //     Console.WriteLine(words[i]);
        // }

        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Give number: ");
        string givenumber = Console.ReadLine();
        int givennumber = int.Parse(givenumber);
        numbers.Add(givennumber);
        while (givennumber != 0)
        {
            
            Console.Write("Give number: ");
            givenumber = Console.ReadLine();
            givennumber = int.Parse(givenumber);
            if (givennumber != 0)
            {
                numbers.Add(givennumber);
            }
        }
        
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");
        int largest = numbers.Max();
        Console.WriteLine($"The largest number is {largest}");
        int smallestpositive = numbers.Where(x => x > 0).Min();
        Console.WriteLine($"The smallest number is {smallestpositive}");
        for (int i = 0; i < numbers.Count; i++)
        {
            numbers.Sort();
            Console.WriteLine(numbers[i]);
        }
    }
}