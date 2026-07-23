using System;

public abstract class Goal
{
    protected string _hmshortName;
    protected string _hmdescription;
    protected int _hmpoints;

    public Goal(string hmshortName, string hmdescription, int hmpoints)
    {
        _hmshortName = hmshortName;
        _hmdescription = hmdescription;
        _hmpoints = hmpoints;
    }

    public abstract void RecordEvent();
    public abstract bool Complete();
    public abstract string GetStringRepresentation();

    public virtual string GetDetailsString()
    {
        string checkbox = Complete() ? "[X]" : "[ ]";
        return $"{checkbox} {_hmshortName} ({_hmdescription})";
    }

    public int GetPoints()
    {
        return _hmpoints;
    }
}