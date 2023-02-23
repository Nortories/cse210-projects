using System;

class Program
{
    static void Main(string[] args)
    {
        SelectAct();
    }

    public static void SelectAct()
    {
        Display display = new Display();
        display.DisplayMenu();
        int input = Convert.ToInt16(Console.ReadLine());
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

    }
}