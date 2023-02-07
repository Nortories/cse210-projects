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
        System.Console.WriteLine($"How many words do you want to hind?");
        int numToHide = Int32.Parse(Console.ReadLine());
        if (prompt != "quit")
        {
            HideSomeStuff(numToHide);    
            s.DisplayCurrent();
        }
        else
        {
            Environment.Exit(0);
        }
    }

    private void HideSomeStuff(int numToHide)
    {
        foreach (var i in Enumerable.Range(0, numToHide))
        {
            s.Hide();
        }
    }
}