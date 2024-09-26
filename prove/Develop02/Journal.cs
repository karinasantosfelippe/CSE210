using System.IO;

namespace Develop02
{
    public class Journal
    {
        public List<Entry> _entries = [];

        public void AddEntry(Entry entry) => _entries.Add(entry);

        public void DisplayAllEntries()
        {
            foreach (Entry entry in _entries) // iterate the array with all entries and display one by one in the screen
            {
                Console.WriteLine("");
                entry.Display();
            }
        }

        public void SaveFile(string fileName)
        {
            // load the file to save the info
            using StreamWriter outputFile = new(fileName);
            foreach (Entry entry in _entries)
            { // write a formated line in the file for each entry in the array
                outputFile.WriteLine(value: $"{entry._date}, \"{entry._promptText}\", \"{entry._entryText}\"");
            }
        }

        public void LoadFromFile(string fileName)
        {
            try
            {
                // remove all the itens from the array to load the file
                _entries.Clear();

                // read each line and store in an array
                string[] lines = File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    // since each info is divided by the symbol ',', each line will be splited in 3 parts (different variables)
                    string[] parts = line.Split(",");

                    string loadedDate = parts[0]; // the first part is the date
                    string loadedPrompt = parts[1]; // the second parte is the prompt
                    string loadedEntry = parts[2]; // the last part is the user answer for the prompt

                    Entry entry = new()
                    { // for each info, remove the spaces at the begining and the quotation marks
                        _date = loadedDate.TrimStart().Replace("\"", ""),
                        _promptText = loadedPrompt.TrimStart().Replace("\"", ""),
                        _entryText = loadedEntry.TrimStart().Replace("\"", "")
                    };
                    // add the loaded entry to the array
                    _entries.Add(entry);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("\nFile not found!");
            }
        }
    }
}