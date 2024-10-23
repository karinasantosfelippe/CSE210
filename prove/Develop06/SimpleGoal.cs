namespace Develop06;

public class SimpleGoal : Goal
{
    private bool _isComplete;
    private readonly string _name;
    private readonly string _description;
    private readonly int _points;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    public override bool IsComplete() => _isComplete;

    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }

    public override string GetStringRepresentation() => $"{GetType().Name};{_name};{_description};{_points};{_isComplete}";
}