/*
Author: Karina Santos Felippe
Exceeding requirements: described in the README file > Exceeding Requirements section
*/

using Develop03;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "yes";
        while (userInput.ToLower() == "yes")
        {
            AppConstants.SCRIPTURES.ForEach(scripture => scripture.ShowAllScriptureWords());
            Random random = new();
            int index = random.Next(AppConstants.SCRIPTURES.Count);
            Scripture scripture = AppConstants.SCRIPTURES[index];

            while (!scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");

                userInput = Console.ReadLine();
                if (userInput.ToLower() == "quit")
                    break;

                scripture.HideRandomWords(3);

            }

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nDo you want to restart? (yes/no)");
            userInput = Console.ReadLine();
        }
    }
}