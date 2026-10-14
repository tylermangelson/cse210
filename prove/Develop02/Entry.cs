using System;

// to do:
// save entries in a list?


class Entry
{
    public string _date;
    public string _prompt;
    public string _response;
    public void DisplayEntry()
    {
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_prompt}");
        Console.WriteLine($"{_response}");
    }

    public Entry()
    {
        _date = "";
        _prompt = "";
        _response = "";
    }

    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public void CreateEntry()
    {
        Prompt prompt = new Prompt();
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
        _prompt = prompt.GetRandomPrompt();

        Console.Write($"{_prompt}");
        _response = Console.ReadLine();
    }

    public override string ToString()
    {
        string outputString;
        outputString = $"{_date}#{_prompt}#{_response}";
        return outputString;

    }

    
}