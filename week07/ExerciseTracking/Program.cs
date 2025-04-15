using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> excersises = new List<string>();

        Console.Clear();
        SwimmingExcersise swimmingExcersise = new SwimmingExcersise(30, 10);
        excersises.Add(swimmingExcersise.GetSummary());
        // should be 96.7 for pace
        // 0.6214 for speed
        // 0.31 for miles

        RunningExcersise runningExcersise = new RunningExcersise(40, 30);
        runningExcersise.GetSummary();
        excersises.Add(runningExcersise.GetSummary());
        // should be about 1.33 minutes per mile
        // aprox 45 mph for speed

        BicycleExcersize bicycleExcersize = new BicycleExcersize(50, 20);
        excersises.Add(bicycleExcersize.GetSummary());
        // Should be about 2.5 minute per mile
        // about 24 mph for speed

        foreach (string item in excersises)
        {
            Console.WriteLine($"{item}\n");
        }
    }
}