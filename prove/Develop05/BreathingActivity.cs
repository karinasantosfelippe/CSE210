namespace Develop05;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "description here.";
    }

    public void Run()
    {
        Console.Clear();
        Console.Write("Get ready... ");
        ShowCountDown(5);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("\nBreath in... ");
            ShowCountDown(5);
            Console.Write("\nNow breath out... ");
            ShowCountDown(6);
            Console.WriteLine();
        }
    }
}