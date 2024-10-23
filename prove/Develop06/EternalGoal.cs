namespace Develop06;

public class EternalGoal(string _name, string _description, int _points) : Goal(_name, _description, _points)
{
    public override bool IsComplete() => false;

    public override int RecordEvent() => _points;

    public override string GetStringRepresentation() => $"{_name};{_description};{_points}";
}