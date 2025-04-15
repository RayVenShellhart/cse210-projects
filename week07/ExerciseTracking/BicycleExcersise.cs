public class BicycleExcersize : Excersise
{
    public BicycleExcersize(double minutes, double distance) : base(distance, minutes)
    {

    }

    public override double Speed()
    {
        return (_distance / _minutes) * 60;
    }

    public override double Pace()
    {
        return _minutes / _distance;
    }

    public override double Distance()
    {
        return 0.0;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({_minutes} min)- Distance {_distance.ToString(".0##")} miles, Speed {Speed().ToString(".0##")} mph, Pace {Pace().ToString(".0##")} min per mile.";
    }
}