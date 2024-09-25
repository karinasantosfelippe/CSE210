using Develop02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        Journal journal = new();
        PromptGenerator promptGenerator = new();

        int option = 0;

        do
        {
            // Presenting the menu options for the user
            Console.WriteLine("Please select one of the following choices");
            foreach (string choice in AppConstants.OPTIONS)
                Console.WriteLine(choice);
            Console.Write("What would you like to do? ");
            // Store the user option
            option = int.Parse(Console.ReadLine());

            // Preventing user from choosing an option that is not available
            if (option < 1 || option > AppConstants.OPTIONS.Count)
                Console.WriteLine("\nChoose a valid option!\n");
            else
            {
                // Write a new entry - Show the user a random prompt, and save their response, the prompt, and the date as an Entry.
                if (option == 1)
                {
                    Console.WriteLine(promptGenerator.GetRandomPrompt());
                    string answer = Console.ReadLine();
                }
            }

        } while (option != int.Parse(AppConstants.OPTIONS.Last().Substring(0, 1)));
    }
}