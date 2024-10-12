namespace Develop05;
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration = 1;

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
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
            if (i >= animationStrings.Count)
                i = 0;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}