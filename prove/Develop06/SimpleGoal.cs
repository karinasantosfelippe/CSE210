namespace Develop06;

public class SimpleGoal(string _name, string _description, int _points) : Goal(_name, _description, _points)
{
    private bool _isComplete = false;

    public override bool IsComplete() => _isComplete;

    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }

    public override string GetStringRepresentation() => $"{_name};{_description};{_points};";
}