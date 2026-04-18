namespace PrTask.Domain.Constants;
public static class E2ENavConstants
{
    public const string LanguageSelectCss = "select.language-select";
    public const string LanguageOptionCss = "option";
    public const int ExpectedLanguageOptionCount = 15;
    public const string ClearCacheBtnTitleCss = ".nav-links a[title*=\"Refresh\"], .nav-links a[title*=\"refresh\"]";
    public const string NavActionButtonsCss = ".nav-links a.nav-refresh";
    public const string ClearCacheFunctionName = "prtaskClearCache";
    public const string ChineseCharacterPattern = @"[\u4e00-\u9fff]";
    public const string IStringLocalizerKeyPattern = "LanguageEnglish";
    public const int BlazorWaitMs = 8000;
    public const int ShortWaitMs = 3000;
    public const int NavigationTimeoutMs = 30000;
    public const string AssertLanguageSelectorExists = "Language selector must exist on page";
    public const string AssertLanguageOptionCount = "Language selector must have {0} options, got {1}";
    public const string AssertNoLocalizerKeyNames = "Language options must not contain IStringLocalizer key names like 'LanguageEnglish'";
    public const string AssertLanguageSavedToLocalStorage = "Language code must be saved to localStorage after change";
    public const string AssertLanguagePersistsAfterReload = "Language selector must show '{0}' after reload, got '{1}'";
    public const string AssertChineseCharactersPresent = "Page must contain Chinese characters after switching to zh";
    public const string AssertOptionsReadable = "Language option '{0}' must show readable label, not key name";
    public const string AssertClearCacheFunctionExists = "prtaskClearCache JS function must be defined on window";
    public const string AssertServiceWorkerRegistered = "Service Worker must be registered";
    public const string AssertNoQueryParamsAfterClear = "URL must not contain cache-busting query params after clear cache";
    public const string AssertPageLoadedAfterClear = "Page must be functional after cache clear (body length > {0})";
    public const string AssertFirstOptionEnglish = "First option must be 'EN English', got '{0}'";
    public const string AssertOptionsConsistentAfterReload = "All language options must match expected labels after reload";
    public const int MinBodyLengthAfterClear = 50;
}
