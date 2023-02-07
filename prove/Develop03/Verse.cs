
public class Verse
{   
    //globale var
    bool wordHidden = false;
    

    //Attributes
    //list of word objects
    private List<Word> _words = new List<Word>();
    private bool _isHidden;

    //contructor
    public Verse(string verse)
    {
        char[] delimiterChars = { ' ', '.', ':', '\t'};
        string[] words = verse.Split(delimiterChars);
        foreach (string wordtext in words)
        {
            Word w = new Word(wordtext);
            _words.Add(w);
        }
    }

    //Display Function
    public void DisplayCurrent()
    {
        foreach (Word w in _words)
        {
            w.DisplayCurrent();
            System.Console.Write(" ");
        }
    }

    public void Hide()
    {
        int maxRan = _words.Count();
        Random rnd = new Random();
        int rndWord = rnd.Next(0,maxRan);
        wordHidden = _words[rndWord].Hide();

        if (wordHidden == true)
            foreach (Word word in _words)
            {
                wordHidden = word.GetIfHidden();
                if (wordHidden == false)
                {
                    Hide();
                    break;
                }                
            }
    }
    public bool GetIfHidden()
    {
        SetIsHidden();
        if (_isHidden == true)
            return true;
        else
        {
            return false;
        }
    }
    private void SetIsHidden()
    {
        foreach (Word w in _words)
            {
                bool wordsAreHidden = false;
                wordsAreHidden = w.GetIfHidden();
                if (wordsAreHidden == false)
                {
                    _isHidden = false;
                    break;
                }
                else
                {
                    _isHidden = true;
                }
            }
    }
}