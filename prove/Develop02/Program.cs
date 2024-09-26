/*
Exceeding requirements: described in the README file > Exceeding Requirements section
*/

using Develop02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        Journal journal = new();
        PromptGenerator promptGenerator = new();

        int option = 0;

        while (option != int.Parse(AppConstants.OPTIONS.Last()[..1])) // while the option is different from the number for 'quit' (which is the last menu option). The syntax presented is the same then '[string].Substring(0, 1)'.
        {
            // Presenting the menu options for the user
            Console.WriteLine("\nPlease select one of the following choices");
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
                // Write a new entry - Show the user a random prompt, and store their response, the prompt, and the date as an Entry.
                if (option == 1)
                {
                    // select and display a prompt randomly
                    string randomPrompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(randomPrompt);
                    // store the user answer for the prompt
                    string promptAnswer = Console.ReadLine();
                    // store the entry with all necessary info to the entries array
                    Entry entry = new()
                    {
                        _date = DateTime.Now.ToShortDateString(), // store the actual date as a string
                        _promptText = randomPrompt, // store the prompt generated randomly
                        _entryText = promptAnswer // store the user answer for the prompt
                    };
                    journal.AddEntry(entry);
                }
                // Display the journal - Iterate through all entries in the journal and display them to the screen.
                else if (option == 2)
                {
                    if (journal._entries.Count > 0)
                        journal.DisplayAllEntries();
                    else
                        Console.WriteLine("\nThere is no entry to display.");
                }
                // Load the journal from a file - Prompt the user for a filename and then load the journal (a complete list of entries) from that file.
                else if (option == 3)
                {
                    // the load function clear the entries array, so it is a caution to ask the user if there is no unsaved information before any load
                    if (journal._entries.Count > 0) // a way to check this is verify if the array already have any entry
                    {
                        Console.WriteLine("Caution! \nWhen you load a file, any unsaved information may be lost.");

                        Console.WriteLine("Do you want to load it anyway? (yes/no)");
                        string answer = Console.ReadLine();
                        if (answer != "yes")
                            continue;
                    }
                    Console.WriteLine("What is the file name? ");
                    string fileName = Console.ReadLine();

                    journal.LoadFromFile(fileName);
                }
                // Save the journal to a file - Prompt the user for a filename and then save the current journal (the complete list of entries) to that file location
                else if (option == 4)
                {
                    Console.WriteLine("What is the file name? ");
                    string fileName = Console.ReadLine();

                    journal.SaveFile(fileName);
                }
            }

        }
    }
}