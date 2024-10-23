namespace Foundation3;

public class Swimming(DateTime date, int duration, int _laps) : Activity(date, duration)
{

    public override double GetDistance() => _laps * 50 / 1000 * 0.62; // in miles

    public override double GetSpeed() => GetDistance() / _duration * 60; // in mph

    public override double GetPace() => _duration / GetDistance(); // min per mile

}