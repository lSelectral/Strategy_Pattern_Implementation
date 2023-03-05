using Strategy_Pattern_Implementation.Shared;

namespace Strategy_Pattern_Implementation.Interfaces;

public interface ITranslationStrategy
{
    /// <summary>
    /// Translate from one language to another
    /// </summary>
    /// <param name="textToTranslate">Source text to translate</param>
    /// <param name="sourceLanguage">Language of the input</param>
    /// <param name="targetLanguage">Target language to translate</param>
    string Translate(string textToTranslate, LanguageEnum sourceLanguage, LanguageEnum targetLanguage);

    /// <summary>
    /// Show remaining current cloud service tokens
    /// </summary>
    void ShowRemainingTokens();

    /// <summary>
    /// Show total translation count of current service
    /// </summary>
    void ShowTotalTranslationCount();

    /// <summary>
    /// Buy more tokens for current cloud service
    /// </summary>
    void BuyTokens(int amount);
}
