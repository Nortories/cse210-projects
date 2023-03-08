using System;

class Program
{
    //Globale vars

    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();

        DisplayMenu();
        string choice = System.Console.ReadLine(); //Logic
            switch (choice)
            {
                case "1":
                    CreateGoal(goals);
                    break;
                case "2":
                    ListGoal();
                    break;
                case "3":
                    SaveGoal();
                    break;
                case "4":
                    LoadGoal();
                    break;
                case "5":
                    RecordGoal();
                    break;
                case "6":
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
    }

    static void DisplayMenu() //Menu
    {
        System.Console.WriteLine("1. Create New Goal");
        System.Console.WriteLine("2. List Goals");
        System.Console.WriteLine("3. Save Goals");
        System.Console.WriteLine("4. Load Goals");
        System.Console.WriteLine("5. Record Event");
        System.Console.WriteLine("6. Quit");
        System.Console.WriteLine("Select a choice from the menu >    ");
    }

    static List<Goal> CreateGoal(List<Goal> goals)
    {
        System.Console.WriteLine("1. Simple Goal");
        System.Console.WriteLine("2. Eternal Goal");
        System.Console.WriteLine("3. Checklist Goal");
        System.Console.WriteLine("Witch goal type would you like to make? >    ");
        string choice = System.Console.ReadLine();

        System.Console.Write("What is the name of your goal? >    ");
        string name = System.Console.ReadLine();

        System.Console.Write("Give a discription >    ");
        string discription = System.Console.ReadLine();

        System.Console.Write("Set the points for the goal >    ");
        int value = Convert.ToInt32(System.Console.ReadLine());

            switch(choice)    //Logic
            {
                case "1":
                    SimpleGoal simpleGoal = new SimpleGoal(name, discription, value);
                    goals.Add(simpleGoal);
                    break;
                case "2":
                //eternal goal
                    break;
                case "3":
                //Check list goal
                    break;
                    
            }
        return goals;
    }

    static void ListGoal()
    {

    }

    static void SaveGoal()
    {

    }

    static void LoadGoal()
    {

    }

    static void RecordGoal()
    {

    }
}