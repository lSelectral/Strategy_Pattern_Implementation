using Strategy_Pattern_Implementation.Interfaces;
using Strategy_Pattern_Implementation.Shared;

namespace Strategy_Pattern_Implementation.Strategies.Translators;

public class Yandex : ITranslationStrategy
{
    private long totalTranslationCount = 0;
    private long totalTokens = 1000;

    public void BuyTokens(int amount) => totalTokens += amount;
    public void ShowRemainingTokens() => Console.WriteLine("You have {0} remaining tokens", totalTokens.ToString());
    public void ShowTotalTranslationCount() => Console.WriteLine("You made total of {0} translations", totalTranslationCount.ToString());
    public string Translate(string textToTranslate, LanguageEnum sourceLanguage, LanguageEnum targetLanguage)
    {
        int requiredToken = textToTranslate.Length;

        if (totalTokens <= requiredToken)
            throw new ArgumentException($"You don't have required tokens. You need at least {requiredToken} token(s)");

        totalTranslationCount++;
        totalTokens -= requiredToken;
        return new string(textToTranslate.Reverse().ToArray());
    }
}
