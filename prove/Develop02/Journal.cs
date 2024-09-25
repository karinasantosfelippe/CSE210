using System.IO;

namespace Develop02
{
    public class Journal
    {
        List<Entry> _entries;

        public void AddEntry(Entry entry)
        {
        }

        public void DisplayAll()
        {

        }

        public void SaveFromFile(string file)
        {
            using (StreamWriter outputFile = new StreamWriter(AppConstants.JOURNAL_FILE))
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine("This will be the first line in the file.");

                // You can use the $ and include variables just like with Console.WriteLine
                string color = "Blue";
                outputFile.WriteLine($"My favorite color is {color}");
            }
        }

        public void LoadFromFile(string file)
        {

        }
    }
}