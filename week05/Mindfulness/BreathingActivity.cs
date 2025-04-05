using System.Diagnostics;

public class BreathingActivity : Activity
{
    private int _number;
    private string _numberString;

    private string _activity = "Breathing";

    public void Run()
    {
        DisplayStartingMessage(_activity);
        _numberString = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Welcome to the Breathing Activity\n");
        Console.WriteLine("This activity will help you relax by walking your through \nbreathing in and out slowly. Clear your mind and focus on your breathing.\n");
        ShowSpinner(15);
        _number = int.Parse(_numberString);
        Console.Clear();
        Console.WriteLine("Get Ready\n");
        ShowSpinner(5);
        // 20%
        Console.Write("Breath in: ");
        double numberChange = _number * 0.2;
        ShowCountDown(numberChange);
        Console.WriteLine("\n");
        // 30%
        Console.Write("Breath out: ");
        numberChange = _number * 0.10;
        ShowCountDown(numberChange);
        Console.WriteLine("\n");
        // 60%
        Console.Write("Breath in: ");
        numberChange = _number * 0.3;
        ShowCountDown(numberChange);
        Console.WriteLine("\n");
        // 70%
        Console.Write("Breath out: ");
        numberChange = _number * 0.1;
        ShowCountDown(numberChange);
        Console.WriteLine("\n");
        // 90%
        Console.Write("Breath in: ");
        numberChange = _number * 0.2;
        ShowCountDown(numberChange);
        Console.WriteLine("\n");
        // 100%
        Console.Write("Breath out: ");
        numberChange = _number * 0.1;
        ShowCountDown(numberChange);
        DisplayEndingMessage(_activity, _number);
    }
}