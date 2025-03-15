using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What challenges did you face today, and how did you overcome them?",
        "What is one thing you would like to change about yourself?",
        "What is a skill you'd like to learn?",
        "Did something happen today?",
        "If I had one thing I could do over today, what would it be?",
        "How did I see the hand of the Lord in my life today?",
        "What are you grateful for today? ",
        "What are some small moments of joy you experienced today? "
    };
    
    

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}

