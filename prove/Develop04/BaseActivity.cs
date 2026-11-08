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
        Console.Clear();
        Console.WriteLine(_name);
        
    }

    public void DisplayDescription()
    {
        Console.WriteLine(_description);
    }

    public DateTime GetDuration()
    {
        Console.WriteLine("How long do you want your session to be?");
        Console.WriteLine(" ");
        Console.Write("Seconds: ");
        _duration = int.Parse(Console.ReadLine());
        DateTime startTime = DateTime.Now;
        _endTime = startTime.AddSeconds(_duration);
        return _endTime;

    }

    public void SpinnerMessage()
    {
        List<string> spinner = new List<string> {"-", "\\", "|", "/"};

        Console.CursorVisible = false;

        Console.Clear();

        Console.Write("Getting ready ");
        for (int i = 0; i < 5; i++)
        {
            foreach (string character in spinner)
            {
                Console.Write(character);
                Thread.Sleep(200);
                Console.Write("\b \b");
                
        
            }
        }

        Console.Clear();

        Console.CursorVisible = true;
    }

    public void CountDownMessage(string message, int duration)
    {

        Console.Write(message);
        for (int i = duration; i > 0; i--)
        {
            string text = i.ToString();
            Console.Write(text);
            Thread.Sleep(1000);
            for (int j = 0; j < text.Length; j++)
            {
                Console.Write("\b \b");
            }
             
        }

    }

    public void CompletionMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Well done! You have completed the {_name}.");
    }

}