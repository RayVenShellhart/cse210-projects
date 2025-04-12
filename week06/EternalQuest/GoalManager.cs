using System.Drawing;
using System.Formats.Asn1;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.IO;
using System.Linq;
using System.Text;

public class GoalManager
{
    private List<string> _goal = new List<string>();
    private int _score = 0;
    private string _level = "none";


    public void Start()
    {
        string menu = "0";

        do
        {
            Console.Clear();
            Console.WriteLine($"Your score is {_score}");
            Console.WriteLine($"Your score is {DisplayLevel()}");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("     1. Create Goal");
            Console.WriteLine("     2. List Goals");
            Console.WriteLine("     3. Save Goals(Load File First if Exists.)");
            Console.WriteLine("     4. Load Goals");
            Console.WriteLine("     5. Record Event");
            Console.WriteLine("     6. Quit");
            Console.Write(">");
            menu = Console.ReadLine();
            if (menu == "1")
            {
                CreateGoal();
            }
            else if (menu == "2")
            {
                DisplayPlayerInfo();
            }
            else if (menu == "3")
            {
                SaveGoals();
            }
            else if (menu == "4")
            {
                LoadGoal();
            }
            else if (menu == "5")
            {
                RecordEvent();
            }
            else if (menu == "6")
            {
                Console.WriteLine("Goodbye");
            }
            else
            {
                Console.WriteLine("Not applicable");
            }
        } while (menu != "6");

    }

    public string DisplayLevel()
    {
        if (_score < 500)
        {
            _level = "none";
        }
        else if (_score < 1000)
        {
            _level = "copper";
        }
        else if (_score < 10000)
        {
            _level = "bronze";
        }
        else if (_score < 50000)
        {
            _level = "silver";
        }
        else if (_score < 1000000)
        {
            _level = "Gold";
        }
        else if (_score >= 1000000)
        {
            _level = "PLATINUM";
        }
        return _level;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your score is {_score}\n");
        int count = 0;
        foreach (string line in _goal)
        {
            Console.WriteLine($"{count += 1}: {line}");

        }
        Console.WriteLine("Press enter to continue");
        Console.Write(">");
        Console.ReadLine();
    }

    public void CreateGoal()
    {
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("     1. Eternal Goal");
        Console.WriteLine("     2. Simple Goal");
        Console.WriteLine("     3. Checklist Goal");
        Console.WriteLine("     4. Quit");
        Console.Write(">");
        string goal = Console.ReadLine();
        if (goal == "1")
        {
            Console.WriteLine("What is the name of your goal?");
            Console.Write(">");
            string name = Console.ReadLine();
            Console.WriteLine("What is a description of your goal?");
            Console.Write(">");
            string description = Console.ReadLine();
            Console.WriteLine("How many points is the goal");
            Console.Write(">");
            string numberString = Console.ReadLine();
            int number = int.Parse(numberString);
            EternalGoal eternalGoal = new EternalGoal(name, description, number);
            _goal.Add(eternalGoal.GetStringRepresentation());

        }
        else if (goal == "2")
        {
            Console.WriteLine("What is the name of your goal?");
            Console.Write(">");
            string name = Console.ReadLine();
            Console.WriteLine("What is a description of your goal?");
            Console.Write(">");
            string description = Console.ReadLine();
            Console.WriteLine("How many points is the goal");
            Console.Write(">");
            string numberString = Console.ReadLine();
            int number = int.Parse(numberString);
            SimpleGoal simpleGoal = new SimpleGoal(name, description, number);
            _goal.Add(simpleGoal.GetStringRepresentation());
        }
        else if (goal == "3")
        {
            Console.WriteLine("What is the name of your goal?");
            Console.Write(">");
            string name = Console.ReadLine();
            Console.WriteLine("What is a description of your goal?");
            Console.Write(">");
            string description = Console.ReadLine();
            Console.WriteLine("How many points is the goal");
            Console.Write(">");
            string numberString = Console.ReadLine();
            int number = int.Parse(numberString);
            Console.WriteLine("What is the target amount to complete");
            Console.Write(">");
            string targetString = Console.ReadLine();
            int targetInt = int.Parse(targetString);
            Console.WriteLine("How many bonus points");
            Console.Write(">");
            string bonusString = Console.ReadLine();
            int bonusNumber = int.Parse(bonusString);
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, number, targetInt, bonusNumber);
            _goal.Add(checklistGoal.GetStringRepresentation());

        }
        else if (goal == "4")
        {
            Console.WriteLine("Goodbye");
        }
        else
        {
            Console.WriteLine("Not applicable");
        }
    }

    public void GetName()
    {
        int number = 0;
        foreach (string goal in _goal)
        {
            string[] parts = goal.Split(", ");
            string name = parts[2];
            Console.WriteLine($"{number += 1}: {name}");
        }
    }

    public void RecordEvent()
    {
        GetName();
        Console.Write("Which goal did you do?\n");
        string choose = Console.ReadLine();
        int chooseInt = int.Parse(choose);
        chooseInt--;
        string item = _goal[chooseInt];
        string[] parts = item.Split(", ");
        string completed = parts[0];
        if (completed == "[X]")
        {
            Console.WriteLine("Already Done");
            Thread.Sleep(8000);
        }
        else if (completed == "[ ]")
        {
            string typeOf = parts[1];
            string nameOf = parts[2];
            string descriptionOf = parts[3];
            string pointString = parts[4];
            if (typeOf == "Eternal Goal")
            {
                EternalGoal eternalGoal1 = new EternalGoal();
                if (eternalGoal1.IsComplete())
                {
                    int point = eternalGoal1.RecordEvent(pointString);
                    _score = _score + point;
                }
            }
            if (typeOf == "Simple Goal")
            {
                SimpleGoal simpleGoal1 = new SimpleGoal();
                if (simpleGoal1.IsComplete())
                {
                    int point = simpleGoal1.RecordEvent(pointString);
                    _score = _score + point;
                    string replace = $"[X], {typeOf}, {nameOf}, {descriptionOf}, {pointString}";
                    _goal.RemoveAt(chooseInt);
                    _goal.Add(replace);
                }
            }

            if (typeOf == "Checklist Goal")
            {
                string target = parts[5];
                string bonus = parts[6];
                string[] attempted = target.Split("/");
                string attempts = attempted[0];
                string targetInt = attempted[1];
                int attemptsInt = int.Parse(attempts);
                attemptsInt++;
                int IntTarget = int.Parse(targetInt);
                ChecklistGoal checklistGoal1 = new ChecklistGoal();
                if (attemptsInt == IntTarget)
                {
                    if (checklistGoal1.IsComplete())
                    {
                        int point = checklistGoal1.RecordEvent(pointString);
                        int bonusInt = int.Parse(bonus);
                        string replace = $"[X], {typeOf}, {nameOf}, {descriptionOf}, {pointString}, {attemptsInt}/{IntTarget}, {bonus}";
                        _score = _score + bonusInt + point;
                        _goal.RemoveAt(chooseInt);
                        _goal.Add(replace);
                    }
                }
                else
                {
                    int point = checklistGoal1.RecordEvent(pointString);
                    string replace = $"[ ], {typeOf}, {nameOf}, {descriptionOf}, {pointString}, {attemptsInt}/{IntTarget}, {bonus}";
                    _score = _score + point;
                    _goal.RemoveAt(chooseInt);
                    _goal.Add(replace);
                }
            }
        }
    }

    public void SaveGoals()
    {
        Console.WriteLine("What file do you want to save to?");
        Console.Write(">");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (string goal in _goal)
            {
                outputFile.WriteLine(goal);
            }
        }
    }

    public void LoadGoal()
    {
        Console.Clear();
        Console.WriteLine("What file would you like to load");
        Console.Write(">");
        string load = Console.ReadLine();



        foreach (string line in File.ReadAllLines(load).Skip(1))
        {
            string[] parts = line.Split(", ");
            string completed = parts[0];
            string typeOf = parts[1];
            string nameOf = parts[2];
            string descriptionOf = parts[3];
            string pointOf = parts[4];
            if (typeOf == "Checklist Goal")
            {
                string targetOf = parts[5];
                string bonusOf = parts[6];
                _goal.Add($"{completed}, {typeOf}, {nameOf}, {descriptionOf}, {pointOf}, {targetOf}, {bonusOf}");
            }
            else
            {
                _goal.Add($"{completed}, {typeOf}, {nameOf}, {descriptionOf}, {pointOf}");
            }
        }
        foreach (string line in File.ReadLines(load).Take(1))
        {
            string[] parts = line.Split(", ");
            string scoreString = parts[0];
            _score = _score + int.Parse(scoreString);
        }
    }
}