using System;
using System.Collections.Generic;
class Prompt
{
    List<string> Prompts = new List<string>
    {
        "What is something that someone did today that you don't want to forget?",
        "Write a letter to someone you're thinking about.",
        "What is something you learned today.",
        "What's something you weren't perfect at today that you want to do better tomorrow?",
        "What are you grateful for today?",
        "How did you see the Lord's hand today?",

    };
    Random rand = new Random();

    public string GetRandomPrompt()
{
    int randomIndex = rand.Next(Prompts.Count);
    return Prompts[randomIndex];

}
    

}

