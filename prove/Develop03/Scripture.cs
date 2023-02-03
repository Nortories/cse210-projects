public class Scripture
{
    private string _referance;
    private List<string> _verses;

    public Scripture()
    {}
    public Scripture(string referance, List<string> verse)
    {
        _referance = referance;
        _verses = verse;
    }
    
    public bool AreHidden()
    {
        bool allAreHidden = false; //placeholder
        if(allAreHidden != true)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void HideWords()
    {
        {
        Random rn = new Random();
        int numOfVerses = _verses.Count();
        int ranVerse = rn.Next(0,numOfVerses);

        Verse v = new Verse(_verses[ranVerse]);
        v.HideWord();
        }
    }


}