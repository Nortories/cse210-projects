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

    public bool Hide()
    {
        if(_isHidden == false)
        {
            _isHidden = true;
            return false;
        }
        else
        {
            return true;
        }
    }

    public bool GetIfHidden()
    {
        if (_isHidden == true)
            return true;
        else
        {
            return false;
        }
    }
}