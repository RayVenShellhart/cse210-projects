public class MathAssignment : Assignment
{
    private string _textbooksection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbooksection, string problems) : base(studentName, topic)
    {
        _textbooksection = textbooksection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbooksection} Problems {_problems}";
    }
}