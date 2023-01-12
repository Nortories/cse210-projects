using System;

class Program
{

    void Main(string[] args)
    {
        StartingQu();
    }

    // Menu
    void StartingQu()
    {
        Console.WriteLine("Please selcet one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit \n >");
        int selection = Convert.ToInt32(Console.ReadLine());
        Menu(selection);
    }

    //Input Menu Logic
    void Menu(int selection)
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
                Save(entery.Text());
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
        Entery entery = new Entery();
        entery.Text();

    }

    static void Display()
    {
        System.Console.WriteLine("display");
    }

    static string Load()
    {
        System.Console.WriteLine("What is the name of the file you would like to load");
        string fileName = Console.ReadLine();
        return fileName;
    }

    static void Save(string entery)
    {
        System.Console.WriteLine("Where would you like to save your entery? /n > ");

        //Where to save the file
        string save = Console.ReadLine();        
    }

    static void Quit()
    {
        System.Console.WriteLine("quit");
    }


}