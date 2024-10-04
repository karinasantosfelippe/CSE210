namespace Develop03;

public class Scripture
{
    private readonly Reference _reference;
    private readonly List<Word> _words = [];

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public bool IsCompletelyHidden() => _words.All(word => word.IsHidden());

    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();
        Random random = new();
        int loopLimit = numberToHide;

        if (visibleWords.Count < numberToHide)
            loopLimit = visibleWords.Count;

        for (int i = 0; i < loopLimit; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords = _words.Where(word => !word.IsHidden()).ToList();
        }
    }

    public void ShowAllScriptureWords() => _words.ForEach(word => word.Show());

    public string GetDisplayText()
    {
        string scriptureText = "";
        foreach (Word word in _words)
            scriptureText += $"{word.GetDisplayText()} ";
        return $"{_reference.DisplayReference()} - {scriptureText}";
    }
}
