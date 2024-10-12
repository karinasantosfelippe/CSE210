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
            try
            {
                userInput = int.Parse(Console.ReadLine());
                if (userInput == (int)MenuOptions.Breathing)
                {
                    BreathingActivity activity = new();
                    activity.DisplayStartingMessage();
                    int duration = int.Parse(Console.ReadLine());
                    activity.SetDuration(duration);
                    activity.Run();
                    activity.DisplayEndingMessage();
                    activity.ShowSpinner(10);
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
                    Console.WriteLine("Listen!");
                    Console.ReadLine();
                }
                else if (userInput == (int)MenuOptions.Quit)
                    break;
            }
            catch (System.Exception)
            {
                continue;
            }
        } while (true);
    }
}