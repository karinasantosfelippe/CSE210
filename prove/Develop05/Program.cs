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
                if (userInput == (int)MenuOptions.breathing)
                {
                    Console.Clear();
                    Console.WriteLine("Breath!");
                    Console.ReadLine();
                }
                else if (userInput == (int)MenuOptions.reflecting)
                {
                    Console.Clear();
                    Console.WriteLine("Reflect!");
                    Console.ReadLine();
                }
                else if (userInput == (int)MenuOptions.listing)
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