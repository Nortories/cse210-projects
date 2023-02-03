public class Verse
{
    List<string> _words = new List<string>();
    public Verse()
    {}
    public Verse(string verse)
    {
        string[] words = verse.Split(' ');
        foreach(var word in words)
        {
            _words.Add(word);
        }
    }
    public void HideWord()
    {
        Random rn = new Random();
        int numOfWords = _words.Count();
        int ranWord = rn.Next(0, numOfWords);

        bool hideAWord = false;
        while (hideAWord != true)
        {
            Word w = new Word(_words[ranWord]);
            hideAWord = w.HideWord();
        }
    }
}