/*
Author: Karina Santos Felippe
*/
namespace Develop05;
class Program
{
    static void Main(string[] args)
    {
        MenuSystem menu = new();
        int userInput;

        do
        {
            menu.DisplayMenuSystem();
            // prevent user to enter an invalid option
            try
            {
                userInput = int.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                continue;
            }

            // breathing activity
            if (userInput == (int)MenuOptions.Breathing)
            {
                BreathingActivity activity = new();
                activity.DisplayStartingMessage();
                activity.Run();
                activity.DisplayEndingMessage();
                activity.ShowSpinner(8);
            }
            else if (userInput == (int)MenuOptions.Reflecting)
            {
                Console.Clear();
                Console.WriteLine("Reflect!");
                Console.ReadLine();
            }
            else if (userInput == (int)MenuOptions.Listing)
            {
                Console.Clear();
                ListingActivity activity = new();
                activity.DisplayStartingMessage();
                activity.Run();
                activity.DisplayEndingMessage();
                activity.ShowSpinner(8);
            }
            else if (userInput == (int)MenuOptions.Quit)
                break;
        } while (true);
    }
}