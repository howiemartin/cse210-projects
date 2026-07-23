public class SimpleGoal : Goal
{
    private bool _hmcomplete;

    public SimpleGoal(string hmname, string hmdescription, int hmpoints, bool hmcomplete = false) 
        : base(hmname, hmdescription, hmpoints)
    {
        _hmcomplete = hmcomplete;
    }

    public override void RecordEvent()
    {
        _hmcomplete = true;
    }

    public override bool Complete()
    {
        return _hmcomplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_hmshortName},{_hmdescription},{_hmpoints},{_hmcomplete}";
    }
}