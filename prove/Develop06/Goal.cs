namespace Develop06;

public abstract class Goal (string _name, string _description, int _points)
{
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetails() => $"{_name} - {_description}";
    public abstract string GetStringRepresentation();
}