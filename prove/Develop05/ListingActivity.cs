namespace Develop05;

public class ListingActivity : Activity
{
    public ListingActivity()
    {
        _name = MenuOptions.Listing.ToString();
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        Console.Clear();
        Console.Write("Get ready... ");
        ShowSpinner(5);
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.Write("You may beging in: ");
        ShowCountDown(5);
        Console.WriteLine();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            i++;
        }
        Console.WriteLine($"You listed {i} items!");
    }
}