class BaseActivity
{
    private string _name;
    private string _description;
    private int _duration;
    private DateTime _endTime;

    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;

    }

    public void DisplayName()
    {
        Console.WriteLine(_name);
    }

    public void DisplayDescription()
    {
        Console.WriteLine(_description);
    }

    public DateTime GetDuration()
    {
        Console.WriteLine("How long do you want your session to be?");
        _duration = int.Parse(Console.ReadLine());
        DateTime startTime = DateTime.Now;
        _endTime = startTime.AddSeconds(_duration);
        return _endTime;

    }

    public void CountDownMessage(string message, int duration)
    {
        Console.WriteLine(message);
        for (int i = duration; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b"); 
        }
        
    }

    public void SpinnerMessage()
    {
        List<string> spinner = new List<string> {"-", "\\", "|", "/"};

        for (int i = 0; i < 3; i++)
        {
            foreach (string character in spinner)
            {
                Console.Write(character);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
    }
}