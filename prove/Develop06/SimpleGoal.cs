namespace Develop06;

public class SimpleGoal(string _name, string _description, int _points) : Goal(_name, _description, _points)
{
    private bool _isComplete = false;

    public override bool IsComplete() => _isComplete;

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }
}