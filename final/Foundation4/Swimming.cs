class Swimming : Activity
{
    private int _hmlaps;

    public Swimming(string hmdate, int hmminutes, int hmlaps) : base(hmdate, hmminutes)
    {
        _hmlaps = hmlaps;
    }

    public override double GetDistance() { return _hmlaps * 50.0 / 1000.0 * 0.62; }
    public override double GetSpeed() { return (GetDistance() / GetMinutes()) * 60; }
    public override double GetPace() { return GetMinutes() / GetDistance(); }
}