using System;

class Program
{
    Display display = new Display();
    void Main(string[] args)
    {
      Menu();
    }

    void Menu()
    {

        int selection = display.Menu();
        
            if (selection == 1)
            {
                Entery entery = new Entery();
                entery.Prompt();
                entery.Write();
            }
            else if (selection == 2)
            {
                display.DisplayJournal();
            }
            else if (selection == 3)
            {
                Data data = new Data();
                data.Load();
            }
            else if (selection == 4)
            {
                Data data = new Data();
                data.Save();
            }
            else if (selection == 5)
            {
                Quit();
            }
            else
            {
                System.Console.WriteLine("\n\nThat was not a valied input");
                Menu();
            }
    }
    static void Display()
    {
        System.Console.WriteLine("display");
    }
    static void Quit()
    {
        System.Console.WriteLine("quit");
    }
}