using Strategy_Pattern_Implementation.Interfaces;
using Strategy_Pattern_Implementation.Shared;

namespace Strategy_Pattern_Implementation;

public class TranslationContext
{
    #region CTOR
    private ITranslationStrategy _translationStrategy;

    public TranslationContext() { }

    public TranslationContext(ITranslationStrategy translationStrategy)
    {
        _translationStrategy = translationStrategy;
    }
    #endregion

    // Allow external strategy setting
    public void SetStrategy(ITranslationStrategy translationStrategy) => _translationStrategy = translationStrategy;

    public void RunTranslation(string text)
    {
        if (_translationStrategy == null)
            throw new ArgumentNullException("Translation strategy is not set");

        _translationStrategy.Translate("Hello, World!", LanguageEnum.English, LanguageEnum.Spanish);
    }

    public void BuyTokens(int amount) => _translationStrategy.BuyTokens(amount);
}
