class Running : Activity
{
    private double _hmdistance;

    public Running(string hmdate, int hmminutes, double hmdistance) : base(hmdate, hmminutes)
    {
        _hmdistance = hmdistance;
    }

    public override double GetDistance()
    {
        return _hmdistance; 
    }
    public override double GetSpeed()
    {
        return (_hmdistance / GetMinutes()) * 60;
    }
    public override double GetPace()
    {
        return GetMinutes() / _hmdistance;
    }
}