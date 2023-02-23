using System;

class Program
{
    static void Main(string[] args)
    {
        SelectAct();
    }

    public static void SelectAct()
    {
        System.Console.Clear();
        Display display = new Display();
        display.DisplayMenu();
        string userInput = Console.ReadLine();
        try{
        int input = Convert.ToInt16(userInput);
        if (input == 1)
        {
            BreathingAct breath = new BreathingAct(display.DurationInput());
            breath.Breath();
        }
        else if (input == 2)
        {
            RefectionAct refect = new RefectionAct(display.DurationInput());
            refect.Refect();
        }
        else if (input == 3)
        {
            ListingAct listAct = new ListingAct(display.DurationInput());
            listAct.List();
        }
        else if (input == 4)
        {
            Environment.Exit(0);
        }
        }
        catch
        {
            System.Console.WriteLine("Not a valid input please try again");
            Activity a = new Activity();
            a.Spinner(3);
            System.Console.Clear();
            SelectAct();
        }
    }
}