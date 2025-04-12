public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal()
    {
        
    }
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent(string point);

    public abstract bool IsComplete();

    public abstract string GetStringRepresentation();
}