namespace Develop05;
public class Activity(string _name, string _description)
{
    private int _duration = 0;

    public void SetDuration(int duration) => _duration = duration;
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like for your session? ");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = ["|", "/", "-", "\\", "|", "/", "-", "\\"];
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(animationStrings[i]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
            if(i >= animationStrings.Count)
                i = 0;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
}