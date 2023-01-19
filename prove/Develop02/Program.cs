using System;

class Program
{

    
    static void Main(string[] args)
    {
      Start();
    }

    static void Start()
    {
        Display display = new Display();

        int menuSelection = display.Menu();
        
            if (menuSelection == 1)
            {
                Entery entery = new Entery();
                entery.Prompt();
                entery.Write();
        
            }
            else if (menuSelection == 2)
            {
                display.DisplayJournal();
            }
            else if (menuSelection == 3)
            {
                Data data = new Data();
                data.Load();
            }
            else if (menuSelection == 4)
            {
                {
                Data data = new Data();
                data.Save();
                }
            }
            else if (menuSelection == 5)
            {
                Environment.Exit(0);
            }
            else
            {
                System.Console.WriteLine("\n\nThat was not a valied input");
            }
        Start();
    }
}