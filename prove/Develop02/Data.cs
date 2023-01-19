public class Data
{
    //stores loaded file as List
    public static List<string> _loads;

    //Asks for file to be loaded then opens, reads and stores file.
    public void Load()
    {
        //Instantiate StreamReader.
        StreamReader read = null;

        //Gets fileName from user.
        System.Console.Write("What is the name of the file you would like to load\n >    ");
        string fileName = Console.ReadLine();

        //Check if File Exists in CD.
        if (File.Exists(fileName))
        {   //Open file and store it as var read in the Stream
            read = new StreamReader(File.OpenRead(fileName));
            List<string> list = new List<string>();
            //While not at the end of the file keep looping though all data.
            while(!read.EndOfStream)
            {   //parses through the file for CSV and adds each entery as a element to the list.
                var line = read.ReadLine();
                var jornaulEntery = line.Split(',');
                foreach (var entery in jornaulEntery)
                {
                    list.Add(entery);
                }
            }
            //closes file and stores list to static var.
            read.Close();
            _loads = list;
            System.Console.WriteLine($"\n File {fileName} loaded");

        }
        else if (!File.Exists(fileName))
        {
            System.Console.WriteLine($"\n No such file \n");
        }
    }

    //Gets newEntery and save it to a file.
    public void Save()
    {
        Entery enerty = new Entery();
        string text = Entery.newEntery;

        StreamWriter write = null;


        System.Console.Write("Where would you like to save your entery? \n > ");
        //Where to save the file
        string fileName = Console.ReadLine();

        /*checks if file exists and creates new file if not, otherwise
         appends newEntery to end of file*/
        if (!File.Exists(fileName))
        {
            write = new StreamWriter(File.OpenWrite(fileName));
            write.WriteLine(text);
            write.Close();
            System.Console.WriteLine($"\nCreated new file {fileName}");
        }
        else
        {
            File.AppendAllText(fileName, text);
            System.Console.WriteLine($"\nSaved new entery too {fileName}");
        }
        
    }
}