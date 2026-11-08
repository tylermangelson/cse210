class ListingActivity : BaseActivity
{
    public ListingActivity() : base("Listing Activity", "This activity helps you list things to get things off your mind and notice things you usually wouldn't.")
    {
    }

    List<string> prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "What are things you're grateful for today?",
        "What are small things that made you smile this week?",
        "What are skills you'd like to learn?",
        "Who has taught you something important?",
        "What are favorite memories from your childhood?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        return prompts[random.Next(prompts.Count)];
    }

    private List<string> CollectItems(DateTime endTime)
    {
        List<string> items = new List<string>();
        string current = "";

        int timerRow = Console.CursorTop;
        Console.WriteLine();
        Console.Write("> ");

        while (DateTime.Now < endTime)
        {
            int left = Console.CursorLeft;
            int row = Console.CursorTop;
            int secondsLeft = (int)Math.Ceiling((endTime - DateTime.Now).TotalSeconds);

            Console.SetCursorPosition(0, timerRow);
            Console.Write($"Time left: {secondsLeft}   ");
            Console.SetCursorPosition(left, row);

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Enter)
                {
                    if (current != "") items.Add(current);
                    current = "";
                    Console.WriteLine();
                    Console.Write("> ");
                }
                else if (key.Key == ConsoleKey.Backspace)
                {
                    if (current.Length > 0)
                    {
                        current = current.Substring(0, current.Length - 1);
                        Console.Write("\b \b");
                    }
                }
                else
                {
                    current += key.KeyChar;
                    Console.Write(key.KeyChar);
                }
            }

            Thread.Sleep(50);
        }

        if (current != "") items.Add(current);
        return items;
    }

    public void Run()
    {
        DisplayName();
        DisplayDescription();
        DateTime endTime = GetDuration();
        SpinnerMessage();

        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();

        List<string> items = CollectItems(endTime);

        Console.WriteLine();
        Console.WriteLine($"You listed {items.Count} items!");
        Thread.Sleep(2000);

        CompletionMessage();
        Thread.Sleep(3000);
    }
    


}

