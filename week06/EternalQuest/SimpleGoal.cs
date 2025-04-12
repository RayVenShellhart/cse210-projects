public class SimpleGoal : Goal
{
    private bool _isComplete;


    public SimpleGoal()
    {

    }
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override int RecordEvent(string point)
    {
        int points = int.Parse(point);
        return points;
    }

    public override bool IsComplete()
    {
        _isComplete = true;
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"[ ], Simple Goal, {_shortName}, {_description}, {_points}";
    }
}