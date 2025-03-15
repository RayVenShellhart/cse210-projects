using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

// For exceed requirements I addded an option to remove an entry. 
// It brings the list up in a numbered format and the coresponding number can be used to remove it
// used https://stackoverflow.com/questions/55984039/c-sharp-returning-a-random-string-from-a-list to help use random that i didn't know how to use
// used https://www.geeksforgeeks.org/c-sharp-how-to-remove-the-element-from-the-specified-index-of-the-list/ to help me understand RemoveAt
class Program
{
    static void Main(string[] args)
    {
        Journal info = new Journal();
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("6. Remove Item");
        Console.Write("Please enter action: ");
        string number = Console.ReadLine();
        Console.WriteLine("");
        int action = 0;
        action = int.Parse(number);

        while (action != 5)
        {
            if (action == 1)
            {
                info.AddEntry();
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.WriteLine("6. Remove Item");
                Console.Write("Please enter action: ");
                number = Console.ReadLine();
                Console.WriteLine("");
                action = int.Parse(number);
            }

            else if (action == 2)
            {
                info.DisplayAll();
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.WriteLine("6. Remove Item");
                Console.Write("Please enter action: ");
                number = Console.ReadLine();
                Console.WriteLine("");
                action = int.Parse(number);
            }

            else if (action == 3)
            {
                Console.Write("What file would you like to load from?\n>");
                string loadFile = Console.ReadLine();
                Console.WriteLine("");
                info.LoadFromFile(loadFile);
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.WriteLine("6. Remove Item");
                Console.Write("Please enter action: ");
                number = Console.ReadLine();
                Console.WriteLine("");
                action = int.Parse(number);
            }

            else if (action == 4)
            {
                Console.Write("What file would you like to save to?\n>");
                string filename = Console.ReadLine();
                info.SaveToFile(filename);
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.WriteLine("6. Remove Item");
                Console.Write("Please enter action: ");
                number = Console.ReadLine();
                Console.WriteLine("");
                action = int.Parse(number);
            }

            else if (action == 6)
            {
                info.ClearList();
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.WriteLine("6. Remove Item");
                Console.Write("Please enter action: ");
                number = Console.ReadLine();
                Console.WriteLine("");
                action = int.Parse(number);
            }

        }
    }
}

