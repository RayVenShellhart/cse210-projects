using System.Diagnostics;
using System.Timers;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;



    public void DisplayStartingMessage(string name)
    {
        _name = name;
        Console.Clear();
        Console.WriteLine($"Let's Begin your {_name} session");
        Console.Write("How long, in seconds, would you like for your session? ");
    }

    public void DisplayEndingMessage(string activity, int time)
    {
        Console.Clear();
        Console.WriteLine("Congratulations you have finished your activity. Nice Job!");
        Thread.Sleep(5000);
        Console.WriteLine($"You did the {activity} activity for {time} seconds");
        Thread.Sleep(10000);
    }

    public void ShowSpinner(int seconds)
    {
        _duration = seconds;
        List<string> animations = new List<string>();
        animations.Add("—");
        animations.Add("\\");
        animations.Add("|");
        animations.Add("/");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animations[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animations.Count)
            {
                i = 0;
            }
        }

    }

    public void ShowCountDown(double seconds)
    {
        int convert = Convert.ToInt32(seconds);
        for (int i = convert; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void Finish(object source, ElapsedEventArgs e)
    {
        Console.WriteLine("");
    }
}