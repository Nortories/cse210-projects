using System;

class Program
{
    static List<string> reference = new List<string>{"Proverbs 3:5-6", "Deuteronomy 7:3-4", "Nephi 3:7"};
    static List<string> verses = new List<string>{};
    List<Scripture> scrp = new List<Scripture>();
    int _x = 0;

    Random rand = new Random();
    
    static void Main(string[] args)
    {
        Program p = new Program();
        p.SetRandomScrip();
        System.Console.Clear();
        System.Console.WriteLine(reference[p._x]);
        foreach (string verse in verses)
        {
            System.Console.WriteLine(verse);
        }
        p.CreateScripObject();
        p.PromtUser();
    }

    private void SetRandomScrip()
    {
        
        int randomScrp = rand.Next(0,3);
        _x = randomScrp;
        if (randomScrp == 0)
        {
            verses = new List<string>
            {"Trust in the Lord with all your heart and lean not on your own understanding",
            "in all your ways submit to him and he will make your paths straight"};
        }
        if (randomScrp == 1)
        {
            verses = new List<string>
            {@"Neither shalt thou make amarriages with them; thy daughter thou shalt not give 
unto his son, nor his daughter shalt thou take unto thy son.",
            @"For they will aturn away thy son from following me, that they may bserve other 
gods: so will the canger of the Lord be kindled against you, and destroy thee suddenly."};
        }
        if (randomScrp == 2)
        {
            verses = new List<string>
            {@"And it came to pass that I, Nephi, said unto my father: I awill go and do 
the things which the Lord hath commanded, for I know that the Lord giveth no 
commandments unto the children of men, save he shall prepare a way for them 
that they may accomplish the thing which he commandeth them."};
        }
    }

    private void PromtUser()
    {
        System.Console.Write($"Type enter to hide words, or quit to exit.\n>    ");
        string prompt = (Console.ReadLine()).ToLower();
        Random rnd = new Random();
        int numToHide = rnd.Next(1,5);
        if (prompt != "quit")
        {
            HideSomeStuff(numToHide);    
        }
        else
        {
            Environment.Exit(0);
        }
    }

    private void CreateScripObject()
    {
        Scripture scrp1 = new Scripture(verses);
        scrp.Add(scrp1);
    }
    private void HideSomeStuff(int numToHide)
    {
        bool isHidden = scrp[0].GetIfHidden();
        if (isHidden == true)
        {
            System.Console.Clear();
            System.Console.WriteLine(reference[_x]);
            scrp[0].DisplayCurrent();
            System.Console.WriteLine("Everything is hidden now");
            Environment.Exit(0);
        }
        else
        {
            foreach (var i in Enumerable.Range(0, numToHide))
            {
                scrp[0].Hide();
            }
            System.Console.Clear();
            System.Console.WriteLine(reference[_x]);
            scrp[0].DisplayCurrent();
            PromtUser();
        }
    }
}