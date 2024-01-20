public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {

    }

    public void AddPrompts()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What was the best part about today?");
        _prompts.Add("What was the worst part about today?");
        _prompts.Add("Tell about what you watched today");
        _prompts.Add("Who did you spend the most time with today?");
    }

    public string GetRandomPrompt()
    {
        // geneates a random number and stores it as index 
        Random random = new Random();

        int index = random.Next(1, _prompts.Count) - 1;
        string prompt = _prompts[index];

        return prompt;
    }
}