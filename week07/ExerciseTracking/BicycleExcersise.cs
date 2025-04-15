public class BicycleExcersize : Excersise
{
    public BicycleExcersize(double minutes, double distance) : base(distance, minutes)
    {

    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({_minutes} min)- Distance {_distance.ToString(".0##")} miles, Speed {Speed().ToString(".0##")} mph, Pace {Pace().ToString(".0##")} min per mile.";
    }
}