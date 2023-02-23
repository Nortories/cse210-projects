class Display
{
    public void DisplayMenu()
    {
        System.Console.WriteLine(@"
Menu Options.
1. Breathing Activity
2. Refection Activiy
3. Listing Activity
4. Quit
Select a choice from the menu: ");
    }

    public int DurationInput()
    {
        System.Console.WriteLine("How many seconds do you have for this activity?");
        
    int duration = Convert.ToInt32(Console.ReadLine());
        return duration;
    }
}