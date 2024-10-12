namespace Develop05;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = MenuOptions.Breathing.ToString();
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
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