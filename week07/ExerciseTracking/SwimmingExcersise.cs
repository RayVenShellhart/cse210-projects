public class SwimmingExcersise : Excersise
{
    private double _swimSpeed;
    public SwimmingExcersise(double minutes, double laps) : base(laps, minutes)
    {

    }

    public override double Distance()
    {
        return _distance * 50 / 1000 * 0.62;
    }

    public override double Speed()
    {
        _swimSpeed = Distance();
        return (_swimSpeed / _minutes) * 60;
    }

    public override double Pace()
    {
        return 60 / Speed();
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({_minutes} min)- Laps {_distance}, Distance {Distance().ToString(".0##")} miles, Speed {Speed().ToString(".0##")} mph, Pace {Pace().ToString(".0##")} min per mile.";
    }
}