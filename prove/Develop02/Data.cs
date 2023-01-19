public class Data
{
    public static List<string> _loads;
    public void Load()
    {
        StreamReader read = null;

        System.Console.Write("What is the name of the file you would like to load");
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
            }
            read.Close();
            _loads = list;
            System.Console.WriteLine($"\n File {fileName} loaded");

        }
        else if (!File.Exists(fileName))
        {
            System.Console.WriteLine($"\n No such file \n");
        }
    }

    public void Save()
    {
        Entery enerty = new Entery();
        string text = Entery.newEntery;

        StreamWriter write = null;


        System.Console.Write("Where would you like to save your entery? \n > ");
        //Where to save the file
        string fileName = Console.ReadLine();
        if (!File.Exists(fileName))
        {
            write = new StreamWriter(File.OpenWrite(fileName));
            write.WriteLine(text);
            write.Close();
            System.Console.WriteLine($"\nCreated new file {fileName}");
        }
        File.AppendAllText(fileName, text);
        System.Console.WriteLine($"\nSaved new entery too {fileName}");

    }
}