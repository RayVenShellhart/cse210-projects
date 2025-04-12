public class EternalGoal : Goal
{

    public EternalGoal()
    {
        
    }
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override int RecordEvent(string point)
    {
        int points = int.Parse(point);
        return points;
    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        return $"[ ], Eternal Goal, {_shortName}, {_description}, {_points}";
    }
}