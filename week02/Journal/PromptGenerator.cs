public class PromptGenerator
{
    public List<string> prompts = new List<string>
    {
        "What are three things I accomplished today?",
        "Who did I talk to the most?",
        "What was a challenge that I overcame?",
        "Who do I want to talk to tomorrow? Why?",
        "What did I eat for dinner?"
    };

    public Random randomGenerator = new Random();

    public string GetPrompt()
    {
        int index = randomGenerator.Next(prompts.Count);
        return prompts[index];
    }
}