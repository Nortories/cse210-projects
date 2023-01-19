class Display
{
    //Displays main Menu and returns int userinput.
    public int Menu()
        {
            Console.WriteLine("Please selcet one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.Write("5. Quit \n >    ");
            int selection = Convert.ToInt32(Console.ReadLine());
            int Menu = selection;
            return Menu;
        }

    //Checks if file was loaded then writes file to console.
    public void DisplayJournal()
        {
            List<string> list = new List<string>();
            list = Data._loads;
            if(list != null)
            {
                foreach (var entery in list)
                    {
                        System.Console.WriteLine(entery);
                    }
            }
            else
            {
                System.Console.WriteLine($"\n No data has been loaded this session\n First load file you would like to display.");
            }
        }
        
}