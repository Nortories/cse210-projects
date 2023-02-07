using System;

class Program
{
     static List<string> verses = new List<string>
        {
            "And it cam to pass",
            "Jesus Wept",
            "And there was anothe verse"
        };
        Scripture s = new Scripture(verses);

    static void Main(string[] args)
    {
        Program p = new Program();
        foreach (string verse in verses)
            System.Console.WriteLine(verse);
        p.PromtUser();

    }

    private void PromtUser()
    {
        System.Console.Write($"Type enter to hide words, or quit to exit.\n>    ");
        string prompt = (Console.ReadLine()).ToLower();
        Random rnd = new Random();
        int numToHide = rnd.Next(1,3);
        if (prompt != "quit")
        {
            HideSomeStuff(numToHide);    
        }
        else
        {
            Environment.Exit(0);
        }
    }

    private void HideSomeStuff(int numToHide)
    {
        bool isHidden = s.GetIfHidden();
        if (isHidden == true)
        {
            System.Console.Clear();
            s.DisplayCurrent();
            System.Console.WriteLine("Everything is hidden now");
            Environment.Exit(0);
        }
        else
        {
            foreach (var i in Enumerable.Range(0, numToHide))
            {
                s.Hide();
            }
            System.Console.Clear();
            s.DisplayCurrent();
            PromtUser();
        }
    }
}