public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal()
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
        return $"[ ], Checklist Goal, {_shortName}, {_description}, {_points}, {_amountCompleted}/{_target}, {_bonus}";
    }
}