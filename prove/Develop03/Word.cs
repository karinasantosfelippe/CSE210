namespace Develop03;

public class Word
{
    private string _text;
    private bool _IsHidden;

    public Word(string text){
        _text = text;
        _IsHidden = false;
    }

    public void Hide() => _IsHidden = true;

    public void Show() => _IsHidden = false;

    public bool IsHidden() => _IsHidden;

    public string GetDisplayText(){
        if(_IsHidden){
            string hiddenText = "";
            foreach(char letter in _text)
                hiddenText += "_";
            return hiddenText;
        }
        return _text;
    }
}