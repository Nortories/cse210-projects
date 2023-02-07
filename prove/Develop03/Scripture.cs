public class Scripture
{
    //Attribute
    private List<Verse> _verses = new List<Verse>();

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
    }
}