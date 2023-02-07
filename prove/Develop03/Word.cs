public class Word
{
    private string _wordText;
    private bool _isHidden;

    public Word()
    {}
    public Word(string wordtext, bool isHidden = false)
    {
        _isHidden = isHidden;
        _wordText = wordtext;
    }

    public void DisplayCurrent()
    {
        int manyBlanks = _wordText.Count();

        if (_isHidden != true)
            System.Console.Write($"{_wordText}");
        else if (_isHidden == true)
            foreach (char blanks in _wordText)
            System.Console.Write("_");

    }

    public void Hide()
    {
        _isHidden = true;
    }
}