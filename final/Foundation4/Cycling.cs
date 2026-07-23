class Cycling : Activity
{
    private double _hmspeed;

    public Cycling(string hmdate, int hmminutes, double hmspeed) : base(hmdate, hmminutes)
    {
        _hmspeed = hmspeed;
    }

    public override double GetDistance() { return (_hmspeed * GetMinutes()) / 60; }
    public override double GetSpeed() { return _hmspeed; }
    public override double GetPace() { return 60 / _hmspeed; }
}