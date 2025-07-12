public class PromptGenerator
{
    // Supplies random prompts whenever needed.
    public List<string> _prompts;
    public string GetRandomPrompt()
    {
        // we add random prompts
        _prompts = new List<string>
        {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What would you have liked to do diferent today?",
        "Who do I have to thank today to and why?",
        "Did I have a personal own moment? What did I do for me today?",
        "What was the best meal you ate today?"
        };
        // we create the a random to receive one of the prompts.
        Random getRandom = new Random();
        // doing an index for a new to access to prompts.
        // getRandom.Next, generate a random selection.
        // we use Count to know how many elements we have into _prompts.
        int index = getRandom.Next(_prompts.Count);
        // Returning the list with the index, we obtain the random selection of prompts.
        return _prompts[index];
    }
}