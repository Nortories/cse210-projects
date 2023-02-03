public class Word
{
    private string _wordText;
    private bool _isHidden;

    public Word()
    {}
    public Word(string word)
    {
        _wordText = word;
    }

    public bool HideWord()
    {
        if (_isHidden != true)
        {
            for (int i = 0; i < (_wordText.Count()); i++)
            {
            System.Console.Write("_");
            }
            _isHidden = true;
            return true;
        }
        else
        {
            return false;
        }
    }
}