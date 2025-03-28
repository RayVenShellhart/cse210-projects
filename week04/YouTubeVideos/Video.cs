using System.Security.Cryptography.X509Certificates;

public class Video
{
    private string _videoName;
    private string _videoAuthor;
    private int _videoLength;

    public List<Comments> _text = new List<Comments>();

    public Video(string name, string author, int length)
    {
        _videoAuthor = author;
        _videoLength = length;
        _videoName = name;
    }

    public void DisplayAll()
    {
        Console.WriteLine($"Video: {_videoName}, Author: {_videoAuthor}, Video length in seconds: {_videoLength}\n");
        Console.WriteLine($"There are {_text.Count()} comments in this video\n");
        foreach (Comments _comments in _text)
        {
            _comments.DisplayAll();
        }

    }
}