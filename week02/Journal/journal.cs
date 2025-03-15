using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<string> entries = new List<string>();

    public void AddEntry()
    {
        PromptGenerator prompts = new PromptGenerator();
        string randomPrompt = prompts.GetRandomPrompt();
        DateTime theCurrentDatetime = DateTime.Now;
        string dateText = theCurrentDatetime.ToShortDateString();
        Entry entryInfo = new Entry();
        entryInfo._date = dateText;
        entryInfo._promptText = randomPrompt;
        entryInfo.Display();
        Console.Write(">");
        string userPrompt = Console.ReadLine();
        entryInfo._userEntry = userPrompt;
        Console.WriteLine("");
        string text = entryInfo.Final();
        entries.Add(text);
    }

    public void DisplayAll()
    {
        foreach (string sentence in entries)
        {
            string removeStraightSlash = sentence.Replace("|", "");
            Console.WriteLine($"{removeStraightSlash}");
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (string sentence in entries)
            {
                string newSentence = sentence.Replace("\n", "");
                outputFile.WriteLine($"{newSentence}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string filename = file;
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string dateAndPrompt = parts[0];
            string userInput = parts[1];
            string format = $"{dateAndPrompt}\n{userInput}\n";
            entries.Add(format);
        }
    }


    public void ClearList()
    {
        int listCount = -1;
        foreach (string sentence in entries)
        {
            string removeStraightSlash = sentence.Replace("|", "");

            Console.WriteLine($"{listCount += 1}: {removeStraightSlash}");

        }
        Console.Write("\nChoose Which item to remove\n>");
        string number = Console.ReadLine();
        Console.WriteLine("");
        int numberRemoval = int.Parse(number);
        entries.RemoveAt(numberRemoval);
    }
}