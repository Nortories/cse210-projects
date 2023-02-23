class Activity
{
    private string _startMSG;
    private string _name;
    private string _discription;
    protected int _duration;
    private string _endMSG;

    public Activity()
    {}
    public Activity(int duration, string name, string discription)
    {
        _duration = duration;
        _name = name;
        _discription = discription;
        _startMSG = $"Welcome to {_name}";
        _endMSG = $"You have completed {_duration} seconds of {_name} great job!";
    }

    public void OpenActivity()
    {
        System.Console.WriteLine(_startMSG);
        System.Console.WriteLine(_discription);
    }

    public void EndActivity()
    {
        System.Console.Clear();
        System.Console.WriteLine(_endMSG);
    }

///<summary>
/// Pause the program for 'int duration' in seconds
///</summary>
    public void pause(int duration)
    {
        Thread.Sleep(duration*1000);
    }
/// <summary>
/// Spinning text animation, that last the 'int duration' in secondd
/// </summary>
    public void Spinner(int duration)
    {
        double doubleduration = duration;
        DateTime futureTime = DateTime.Now.AddSeconds(doubleduration);
        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b"); // Erase the + character
            Console.Write("\\"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b"); // Erase the + character
            Console.Write("|"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b"); // Erase the + character
            Console.Write("/"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b"); // Erase the + character
            currentTime = DateTime.Now;
        }
    }

///<summary>
/// Countdown number animation of 'duration'
///</summary>
    public void CountDownTimer(double duration)
    {
        string clear = "\b";
        if (duration >= 10)
            clear = "\b\b";
        else if (duration >=100)
            clear = "\b\b\b";
        else
            clear = "\b";

        while (duration != 0)
        {
            System.Console.Write(duration);
            pause(1);
            duration = (duration - 1);
            System.Console.Write($"{clear}");
        }
    }
}