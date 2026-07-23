abstract class Activity
{
    private string _hmdate;
    private int _hmminutes;

    public Activity(string hmdate, int hmminutes)
    {
        _hmdate = hmdate;
        _hmminutes = hmminutes;
    }

    public int GetMinutes() { return _hmminutes; }
    public string GetDate() { return _hmdate; }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        string hmdistanceStr = GetDistance().ToString("0.0");
        string hmspeedStr = GetSpeed().ToString("0.0");
        string hmpaceStr = GetPace().ToString("0.0");
        return $"{_hmdate} {GetType().Name} ({_hmminutes} min) - Distance: {hmdistanceStr} miles, Speed: {hmspeedStr} mph, Pace: {hmpaceStr} min per mile";
    }
}