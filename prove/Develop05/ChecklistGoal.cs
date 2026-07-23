public class ChecklistGoal : Goal
{
    private int _hmamountCompleted;
    private int _hmtarget;
    private int _hmbonus;

    public ChecklistGoal(string hmname, string hmdescription, int hmpoints, int hmtarget, int hmbonus, int hmamountCompleted = 0) 
        : base(hmname, hmdescription, hmpoints)
    {
        _hmtarget = hmtarget;
        _hmbonus = hmbonus;
        _hmamountCompleted = hmamountCompleted;
    }

    public override void RecordEvent()
    {
        if (_hmamountCompleted < _hmtarget)
        {
            _hmamountCompleted++;
        }
    }

    public override bool Complete()
    {
        return _hmamountCompleted >= _hmtarget;
    }

    public override string GetDetailsString()
    {
        string hmcheckbox = Complete() ? "[X]" : "[ ]";
        return $"{hmcheckbox} {_hmshortName} ({_hmdescription}) -- Currently completed: {_hmamountCompleted}/{_hmtarget}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_hmshortName},{_hmdescription},{_hmpoints},{_hmbonus},{_hmtarget},{_hmamountCompleted}";
    }

    public int GetBonus()
    {
        return _hmbonus;
    }
}