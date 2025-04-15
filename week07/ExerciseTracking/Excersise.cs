public abstract class Excersise
{

    protected double _distance;
    protected double _minutes;

    public Excersise(double distance, double minutes)
    {
        _distance = distance;
        _minutes = minutes;
    }

    public abstract double Distance();

    public abstract double Speed();
    public abstract double Pace();

    public virtual string GetDate()
    {
        DateTime now = DateTime.Now;
        return now.ToString("dd MMMM yyyy");
    }

    public abstract string GetSummary();

}