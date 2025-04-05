using System.Diagnostics;
using System.Timers;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _answers = new List<string>();

    private string _activity = "Listing";
    private string _numberString;
    private int _number;
    private string _getAnswers;

    Stopwatch stopwatch = new Stopwatch();


    public void Run()
    {
        DisplayStartingMessage(_activity);
        _numberString = Console.ReadLine();
        _number = int.Parse(_numberString);
        System.Timers.Timer timer = new System.Timers.Timer(_number * 1000);
        timer.Elapsed += Finish;
        timer.AutoReset = false;
        timer.Enabled = true;
        Console.Clear();
        Console.WriteLine("Welcome to the Listing Activity");
        Console.WriteLine("\nThis activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.");
        ShowSpinner(15);
        Console.Clear();
        Console.WriteLine("Get ready");
        ShowSpinner(5);
        Console.Clear();
        GetRandomPrompt();
        stopwatch.Start();
        while (true)
        {
            Console.Write("Give an answer\n>");
            _getAnswers = Console.ReadLine();
            GetListFromUser(_getAnswers);
            if (stopwatch.ElapsedMilliseconds >= _number * 1000)
            {
                break;
            }
        }
        stopwatch.Stop();
        timer.Enabled = false;
        Console.Clear();
        _count = _answers.Count();
        Console.WriteLine($"You gave {_count} answers");
        DisplayEndingMessage(_activity, _number);

    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
    }

    public List<string> GetListFromUser(string answers)
    {
        _answers.Add(answers);
        return _answers;
    }

}