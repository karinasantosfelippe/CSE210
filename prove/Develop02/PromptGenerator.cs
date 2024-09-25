namespace Develop02
{
    public class PromptGenerator
    {
        Random _randomGenerator = new();

        public string GetRandomPrompt()
        {
            int randomNumber = _randomGenerator.Next(0, AppConstants.PROMPTS.Count - 1);
            return AppConstants.PROMPTS[randomNumber];
        }
    }
}