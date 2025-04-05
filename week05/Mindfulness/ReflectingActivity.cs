using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http.Headers;

public class ReflectingActivity : Activity
{
    private string _numberString;
    private int _number;
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private string _activity = "Reflecting";

    Stopwatch stopwatch = new Stopwatch();


    public void Run()
    {
        DisplayStartingMessage(_activity);
        _numberString = Console.ReadLine();
        _number = int.Parse(_numberString);
        System.Timers.Timer timer = new System.Timers.Timer(_number*1000);
        timer.Elapsed += Finish;
        timer.AutoReset = false;
        timer.Enabled = true;
        Console.Clear();
        Console.WriteLine("Welcome to the Reflecting Activity");
        Console.WriteLine("\nThis activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.");
        ShowSpinner(15);
        Console.Clear();
        Console.WriteLine("Get ready");
        ShowSpinner(5);
        Console.Clear();
        DisplayPrompt();
        stopwatch.Start();
        foreach (string item in _questions)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(7);
            Console.WriteLine(" ");
            if (stopwatch.ElapsedMilliseconds >= _number * 1000)
            {
                break;
            }
        }
        stopwatch.Stop();
        timer.Enabled = false;
        DisplayEndingMessage(_activity, _number);

    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestion()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}