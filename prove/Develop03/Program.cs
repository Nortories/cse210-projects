using System;

class Program
{
    static void Main(string[] args)
    {
     
    string scripture = ("I, Nephi, having been aborn |of goodly parents");
    string referance = ("1Nephi: 1:1");

    DisplayScripture();

    void DisplayScripture()
    {
        System.Console.WriteLine($"{referance}    {scripture}");
        System.Console.WriteLine("Enter to hide words, or Type Quit to Exit");
         string userInput = (Console.ReadLine()).ToLower();
         if(userInput != "quit" )
         {
            HideWords();
         }
         else
         {
            Environment.Exit(0);
         }
    }

    void HideWords()
    {
        List<string> verseList = new List<string>();
        string[] verses = scripture.Split('|');
        foreach(var verse in verses)
        {
            System.Console.WriteLine(verse);
            verseList.Add(verse);
        }

        Scripture s = new Scripture(referance, verseList);

        System.Console.WriteLine("How many words would you like to hide");
        int wordsToHide = Convert.ToInt16(System.Console.ReadLine());
        //check if all words are hidden
        bool allAreHidden = s.AreHidden();
        if (allAreHidden == true)
            Environment.Exit(0);
        else
        {
            for (int i = 0; i < wordsToHide; i++ )
            s.HideWords();
        }
    }
    }
}