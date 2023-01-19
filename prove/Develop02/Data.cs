public class Data
{
    string _fileName;

    public void Load()
    {
        System.Console.WriteLine("What is the name of the file you would like to load");
        string _fileName = Console.ReadLine();
    }

    public void Save()
    {
        System.Console.WriteLine("Where would you like to save your entery? /n > ");

        //Where to save the file
        string save = Console.ReadLine();        
    }
}