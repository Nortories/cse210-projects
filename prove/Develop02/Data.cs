public class Data
{
    public void Load()
    {
        StreamReader read = null;

        System.Console.WriteLine("What is the name of the file you would like to load");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            read = new StreamReader(File.OpenRead(fileName));
            List<string> list = new List<string>();
            while(!read.EndOfStream)
            {
                var line = read.ReadLine();
                var jornaulEntery = line.Split(',');
                foreach (var entery in jornaulEntery)
                {
                    list.Add(entery);
                }
                foreach (var entery in list)
                {
                    System.Console.WriteLine(entery);
                }
            }
        }
        else if (!File.Exists(fileName))
        {
            System.Console.WriteLine($"\n No such file \n");
        }
    }

    public void Save(string title, string datetime, string entery)
    {
        StreamWriter write = null;
        string text = ($"\n{title}\n{datetime}\n{entery}\n,");


        System.Console.WriteLine("Where would you like to save your entery? /n > ");
        //Where to save the file
        string fileName = Console.ReadLine();
        if (File.Exists(fileName))
        {
            write = new StreamWriter(File.OpenWrite(fileName));
            write.WriteLine(text);
        }
        write = new StreamWriter(File.OpenWrite(fileName));
        write.WriteLine(text);
    }
}