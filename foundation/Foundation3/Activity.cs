namespace Foundation3;

public abstract class Activity(DateTime _date, int duration)
{
    protected int _duration = duration; // in minutes

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public virtual string GetSummary() => $"{_date:dd MMMM yyyy} {GetType().Name} ({_duration} min) - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
}