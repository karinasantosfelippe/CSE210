using System.Diagnostics;

namespace Develop03
{
    public class Reference
    {
        private string _book;
        private int _chapter;
        private List<int> _verses;
        public Reference(string book, int chapter, List<int> verses)
        {
            _book = book;
            _chapter = chapter;
            _verses = verses;
        }
        public Reference(string book, int chapter, int verse)
        {
            _book = book;
            _chapter = chapter;
            _verses = [];
            _verses.Add(verse);
        }
        private bool IsSequelVerses()
        {
            for(int i = 1; i <_verses.Count; i++)
            {
                if (_verses[i] != _verses[i-1] + 1)
                    return false;
            }
            return true;
        }
        public string DisplayReference()
        {
            string refText = $"{_book} {_chapter}:{_verses[0]}";
            if (_verses.Count > 1)
                if (IsSequelVerses())
                    refText += $"-{_verses.Last()}";
                else
                    for (int i = 1; i < _verses.Count; i++)
                        refText += $",{_verses[i]}";

            return refText;
        }
    }
}