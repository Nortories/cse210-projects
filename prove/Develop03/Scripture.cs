public class Scripture
{
    bool veresHidden = false;

    //Attribute
    private List<Verse> _verses = new List<Verse>();
    private bool _isHidden;

    //Constructor
    public Scripture(List<string> verses)
    {
        foreach (string verse in verses)
        {
            Verse vObject = new Verse(verse);
            _verses.Add(vObject);
        }
    }
    public void DisplayCurrent()
    {
        foreach (Verse v in _verses)
        {
            v.DisplayCurrent();
            System.Console.WriteLine();
        }
    }

    public void Hide()
    {
        int maxRan = _verses.Count();
        Random rnd = new Random();
        int rndVerse = rnd.Next(0,maxRan);
        _verses[rndVerse].Hide();
        if (veresHidden == true)
            foreach (Verse v in _verses)
            {
                veresHidden = v.GetIfHidden();
                if (veresHidden == false)
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
        foreach (Verse v in _verses)
            {
                bool verseIsHidden = false;
                verseIsHidden = v.GetIfHidden();
                if (verseIsHidden == false)
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