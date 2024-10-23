namespace Develop06;

public abstract class Goal(string name, string description, int points)
{
    protected string _name = name;
    protected string _description = description;
    protected int _points = points;

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetails() => $"{_name} ({_description})";
    public abstract string GetStringRepresentation();
}