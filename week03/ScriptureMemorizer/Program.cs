using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;


// for creativity this program allows for multiple scriptures.
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Random rand = new Random();
        int number = rand.Next(1, 3);

        if (number == 1)
        {
            Reference reference = new Reference("Genesis", 1, 20);
            Scripture scripture = new Scripture("And God created great whales, and every living creature that moveth, which the waters brought forth abundantly, after their kind, and every winged fowl after his kind: and God saw that it was good.");
            Console.Clear();
            reference.GetDisplayText();
            scripture.GetDisplayText();
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;

                if (!scripture.HideRandomWords())
                {
                    Console.WriteLine("\nCongratulations!!! You've memorized all of the words in this scripture.");
                    break;
                }
                Console.Clear();
                reference.GetDisplayText();
                scripture.GetDisplayText();
                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            }
        }

        if (number == 2)
        {
            Reference reference = new Reference("Genesis", 1, 1, 5);
            Scripture scripture = new Scripture("In the beginning God created the heaven and the earth. And the earth was without form, and void; and darkness was upon the face of the deep. And the Spirit of God moved upon the face of the waters. And God said, Let there be light; and there was light. And God saw the light, that it was good; God divided the light from the darkness. And God called the light Day, and the darkness he called Night. And the evening and the morning were the first day.");
            Console.Clear();
            reference.GetDisplayText();
            scripture.GetDisplayText();
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;

                if (!scripture.HideRandomWords())
                {
                    Console.WriteLine("\nCongratulations!!! You've memorized all of the words in this scripture.");
                    break;
                }
                Console.Clear();
                reference.GetDisplayText();
                scripture.GetDisplayText();
                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            }
        }

    }
}
    