using System;

public class Entry
{

    public string _date;
    public string _promptText;

    public string _userEntry;

    public void Display()
    {
        Console.WriteLine($"{_date}: {_promptText}");

    }

    public string Final()
    {
        string here = $"{_date}: {_promptText} \n|>{_userEntry}\n";
        return here;
    }


}