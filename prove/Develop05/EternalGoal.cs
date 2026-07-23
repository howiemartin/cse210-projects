public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points)
    {
    }

    public override void RecordEvent(){}

    public override bool Complete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_hmshortName},{_hmdescription},{_hmpoints}";
    }
}