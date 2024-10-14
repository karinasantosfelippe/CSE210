namespace Develop05;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = [];
    public ListingActivity()
    {
        _name = MenuOptions.Listing.ToString();
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _count = 0;
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        Console.Clear();
        _count = 0;
        Console.Write("Get ready... ");
        ShowSpinner(5);
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        // select a random prompt and display it
        GetRandomPrompt();
        // countdown to begin thinking about the prompt
        Console.Write("You may beging in: ");
        ShowCountDown(5);
        Console.WriteLine();
        // the user lists as many items as they can until they they reach the duration specified by the user at the beginning.
        GetListFromUser();
        Console.WriteLine($"You listed {_count} items!");
    }

    private void GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            _count++;
        }
    }

    private void GetRandomPrompt()
    {
        Random random = new();
        int index = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
    }
}