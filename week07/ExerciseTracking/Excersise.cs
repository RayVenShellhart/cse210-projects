public abstract class Excersise
{

    protected double _distance;
    protected double _minutes;

    public Excersise(double distance, double minutes)
    {
        _distance = distance;
        _minutes = minutes;
    }

    public virtual double DistanceSwam()
    {
        return _distance * 50 / 1000 * 0.62;
    }

    public virtual double Speed()
    {
        return (_distance / _minutes) * 60;
    }

    public virtual double Pace()
    {
        return _minutes / _distance;
    }

    public virtual string GetDate()
    {
        DateTime now = DateTime.Now;
        return now.ToString("dd MMMM yyyy");
    }

    public abstract string GetSummary();

}