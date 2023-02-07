
public class Verse
{   
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
        _words[rndWord].Hide();
    }
}