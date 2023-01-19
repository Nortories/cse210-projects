using System;

class Program
{

    
    static void Main(string[] args)
    {
      Start();
    }

    static void Start()
    {
        //Calls, sets and displays Menu from Display class
        Display display = new Display();
        int menuSelection = display.Menu();
        
        //Program logic for menuSelection
            /*Calls and writes random prompt from Entery class and
             then promts user input for entery*/ 
            if (menuSelection == 1)
            {
                Entery entery = new Entery();
                entery.Prompt();
                entery.Write();
        
            }
            /*Displays loaded file, if no file has been loaded CW error.*/
            else if (menuSelection == 2)
            {
                display.DisplayJournal();
            }
            /*Loads data file.*/
            else if (menuSelection == 3)
            {
                Data data = new Data();
                data.Load();
            }
            /*Save current entery to file, if no file found creates file.*/
            else if (menuSelection == 4)
            {
                {
                Data data = new Data();
                data.Save();
                }
            }
            /*Quit application*/
            else if (menuSelection == 5)
            {
                Environment.Exit(0);
            }
            /*Error handler*/
            else
            {
                System.Console.WriteLine("\n\nThat was not a valied input");
            }
        Start();
    }
}