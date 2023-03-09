using System;
using System.ComponentModel;

class Program
{
    //Globale vars
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();

        bool runProgram = true;
        while(runProgram)
        {
            System.Console.WriteLine($"\nYou have {DisplayPoints(goals)} points \n");
            DisplayMenu();
            string choice = System.Console.ReadLine(); //Logic
                switch (choice)
                {
                    case "1":
                        CreateGoal(goals);
                        break;
                    case "2":
                        ListGoal(goals);
                        break;
                    case "3":
                        SaveGoal(goals);
                        break;
                    case "4":
                        LoadGoal(goals);
                        break;
                    case "5":
                        RecordEvent(goals);
                        break;
                    case "6":
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
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

    static void CreateGoal(List<Goal> goals)
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

            switch(choice) //Logic
            {
                case "1":
                    SimpleGoal simpleGoal = new SimpleGoal(name, discription, value);
                    goals.Add(simpleGoal);
                    break;
                case "2":
                //eternal goal
                    EternalGoal eternalGoal = new EternalGoal(name, discription, value);
                    goals.Add(eternalGoal);
                    break;
                case "3":
                //Check list goal
                    break;                   
            }
    }

    static void ListGoal(List<Goal> goals)
    {
        System.Console.WriteLine("Checked | Name | Discreption | Points | Did | Goal");
        foreach (Goal g in goals)
        {
            switch(TypeDescriptor.GetClassName(g))
            {
                case "SimpleGoal":
                    string simpString = g.DisplayGoal();
                    System.Console.WriteLine(simpString);
                    break;
                case "EternalGoal":
                    string EternalString = g.DisplayGoal();
                    System.Console.WriteLine($"{EternalString} | {g.GetCount()}");
                    break;
            }
        }
    }

    static void SaveGoal(List<Goal> goals)
    {
       string filename = ("goal_data.txt");

       using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal g in goals)
            {
                string goalString = g.DisplayGoal();
                outputFile.WriteLine($"{g} |{goalString}");
            }
        }
    }

    static void LoadGoal(List<Goal> goals)
    {
        goals.Clear();
        string filename = "goal_data.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string type = parts[0];

            switch(type)
            {
                //this is for simpleGoals only
                case "SimpleGoal ":
                    string isComplete = parts[1];
                    string name = parts[2];
                    string discription = parts[3];
                    int value = Convert.ToInt32(parts[4]);
                    SimpleGoal simpleGoal = new SimpleGoal(name, discription, value);
                    if (isComplete == ("[X] "))
                    simpleGoal.SetTrue();
                    goals.Add(simpleGoal);
                    break;

                case "EternalGoal":
                    //load eternal goal from txt
                    break;

                case "ChecklistGoal":
                    //load ChecklistGoal from txt
                    break;
            }
        }
    }

    static void RecordEvent(List<Goal> goals)
    {
        int counter = 1;
        foreach (Goal g in goals)
        {
            string goalString = g.DisplayGoal();
            System.Console.WriteLine($"{counter}. {goalString}");
            counter++;
        }
        System.Console.WriteLine("Witch Goal did you complete? >    ");
        int choice = Convert.ToInt16(System.Console.ReadLine());

        Goal updateGoal = goals[choice-1];
        updateGoal.SetTrue();
    }

    static int DisplayPoints(List<Goal> goals)
    {
        int points = 0;
        foreach (Goal g in goals)
        {
            points = points + g.GetPoints();        
        }
        return points;
    }
}