using System.Threading.Tasks.Dataflow;

class ReflectionActivity : BaseActivity
{
    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on important memories that you may take for granted or not think about often enough.")
    {
    }


    List<string> prompts = new List<string>()
    {
        "What is the hardest thing you have ever done?",
        "What is your biggest accomplishment in the past three years?",
        "What is the biggest thing you are working towards right now?",
        "What is something you thought you would have accomplished by now but haven't?",
        "If you were dying today, what would be your message to everyone?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        return prompts[random.Next(prompts.Count)];
    }

    private void WriteWithCountdown(int seconds)
    {
        int top = Console.CursorTop;
        Console.WriteLine();

        DateTime stopTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < stopTime)
        {
            int left = Console.CursorLeft;
            int row = Console.CursorTop;

            Console.SetCursorPosition(0, top);
            Console.Write($"Record your thoughts... {(stopTime - DateTime.Now).Seconds + 1}  ");
            Console.WriteLine();
            Console.SetCursorPosition(left, row);

            if (Console.KeyAvailable)
            {
                Console.Write(Console.ReadKey(true).KeyChar);
            }

            Thread.Sleep(50);
        }
    }

    public void Run()

    {
        DisplayName();
        DisplayDescription();
        DateTime endTime = GetDuration();
        SpinnerMessage();

        while (DateTime.Now < endTime)
        {
            Console.Clear();
            Console.WriteLine(GetRandomPrompt());
            Console.WriteLine();
            WriteWithCountdown(20);
        }

        CompletionMessage();
        Thread.Sleep(3000);

    }



}

