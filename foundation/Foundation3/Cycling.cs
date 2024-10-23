namespace Foundation3;

public class Cycling(DateTime date, int duration, double _speed) : Activity(date, duration)
{

    public override double GetDistance() => GetSpeed() / 60 * _duration;

    public override double GetSpeed() => _speed;

    public override double GetPace()
    {
        double result;
        try
        {
            result = 60 / _speed;
        }
        catch
        {
            return 0;
        }
        return result;
    }
}