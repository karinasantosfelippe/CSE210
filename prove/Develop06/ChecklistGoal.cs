namespace Develop06;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private readonly int _bonus;
    private readonly int _target;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points){
        _bonus = bonus;
        _target = target;
        _amountCompleted = 0;
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override int RecordEvent()
    {
        _amountCompleted++;

        if (Math.DivRem(_amountCompleted, _target).Remainder == 0)
            return _points + _bonus;

        return _points;
    }

    public override string GetStringRepresentation() => $"{_name};{_description};{_points};{_bonus};{_target};{_amountCompleted}";

    public override string GetDetails() => $"{_name} ({_description}) - Current completed: {_amountCompleted}/{_target}";
}