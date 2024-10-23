namespace Foundation3;

public class Running(DateTime date, int duration, double _distance) : Activity(date, duration)
{

    public override double GetDistance() => _distance;

    public override double GetSpeed()
    {
        return (_distance / _duration) * 60;
    }

    public override double GetPace() => _duration / _distance; // min per mile
}