namespace Develop02
{
    public static class AppConstants
    {
        public const string JOURNAL_FILE = "myFile.txt";
        
        public static readonly List<string> OPTIONS = [
            "1. Write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Quit" // REMIND: The 'QUIT' option must be the last option in this list!
        ];
        public static readonly List<string> PROMPTS =
        [
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "How did I see the hand of the Lord in my life today?",
            "What I wanted to do today but I couldn't?",
            "What were my expectations for this day or for tomorrow?"
        ];
    }
}