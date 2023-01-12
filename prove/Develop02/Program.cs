using System;

class Program
{
    static void Main(string[] args)
    {
        StartingQu();
    }

    // Menu
    static void StartingQu()
    {
        Console.WriteLine("Please selcet one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("> ");
        int selection = Convert.ToInt32(Console.ReadLine());
        Menu(selection);
    }

    //Input Menu Logic
    static void Menu(int selection)
    {
            if (selection == 1)
            {
                Write();
            }
            else if (selection == 2)
            {
                Display();
            }
            else if (selection == 3)
            {
                Load();
            }
            else if (selection == 4)
            {
                Save();
            }
            else if (selection == 5)
            {
                Quit();
            }
            else
            {
                System.Console.WriteLine("\n\nThat was not a valied input");
                StartingQu();
            }
    }


    //Menu options
    static void Write()
    {
        Prompts prompts = new Prompts();
        prompts.Prompt();
        Console.ReadLine();
    }

    static void Display()
    {
        System.Console.WriteLine("display");
    }

    static void Load()
    {
        System.Console.WriteLine("load");
    }

    static void Save()
    {
        System.Console.WriteLine("save");
    }

    static void Quit()
    {
        System.Console.WriteLine("quit");
    }


}