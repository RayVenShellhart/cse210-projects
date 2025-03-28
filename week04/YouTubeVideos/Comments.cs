using System.Reflection.Metadata;
using System.Runtime.InteropServices;

public class Comments
{

    public string _name;
    public string _comment;

    public void DisplayAll()
    {
        Console.WriteLine($"{_name}: {_comment}");
    }



}