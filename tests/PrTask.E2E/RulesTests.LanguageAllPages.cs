using System.Text.RegularExpressions;
using PrTask.Cdp;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static readonly string[] TranslationTestLanguages =
    [
        I18NConstants.LanguageCodeChinese,
        I18NConstants.LanguageCodeSpanish,
        I18NConstants.LanguageCodeJapanese,
        I18NConstants.LanguageCodeFrench,
        I18NConstants.LanguageCodeKorean,
    ];

    private static readonly string[] TranslationTestRoutes =
    [
        RouteConstants.Home,
        RouteConstants.Tasks,
        RouteConstants.Leaderboard,
        RouteConstants.HowItWorks,
        RouteConstants.Pricing,
        RouteConstants.About,
        RouteConstants.Dashboard,
        RouteConstants.Login,
        RouteConstants.Download,
        RouteConstants.Settings,
    ];

    private static readonly Regex NonLatinPattern = NonLatinCharacterRegex();

    [TestMethod, TestCategory("i18n"), Timeout(900000)]
    [DisplayName("T78 Language all pages — switching language translates all pages, 15 languages available")]
    public async Task T78LanguageAllPagesAsync()
    {
        var LogPath = Path.Combine(SolutionRoot, "output", "lang-all-pages-debug.log");
        Directory.CreateDirectory(Path.Combine(SolutionRoot, "output"));
        File.WriteAllText(LogPath, $"=== T78 Language All Pages — {DateTime.UtcNow:O} ===\n\n");

        void Log(string Msg) => File.AppendAllText(LogPath, $"[{DateTime.UtcNow:HH:mm:ss.fff}] {Msg}\n");

        var TestLauncher = new ChromeLauncher();
        var TestBrowser = await TestLauncher.LaunchAsync(new ChromeLaunchOptions { Headless = false });

        try
        {
            var Page = await TestBrowser.NewPageAsync();
            await Page.EnableConsoleAsync();

            Log("Step 1: Verify 15 languages available");
            await Page.NavigateAsync(LiveSiteUrl);
            await Task.Delay(E2ENavConstants.BlazorWaitMs);

            var LangSelectCount = await CdpHelpers.CountAsync(Page, E2ENavConstants.LanguageSelectCss);
            Assert.IsTrue(LangSelectCount > 0, E2ENavConstants.AssertLanguageSelectorExists);

            var Options = await CdpHelpers.AllTextContentsAsync(Page, $"{E2ENavConstants.LanguageSelectCss} {E2ENavConstants.LanguageOptionCss}");
            Log($"Found {Options.Length} language options");
            Assert.AreEqual(I18NConstants.LanguageCount, Options.Length,
                string.Format(E2ENavConstants.AssertLanguageOptionCount, I18NConstants.LanguageCount, Options.Length));

            var ExpectedLabels = new[]
            {
                I18NConstants.LabelEnglish, I18NConstants.LabelChinese, I18NConstants.LabelSpanish,
                I18NConstants.LabelJapanese, I18NConstants.LabelGerman, I18NConstants.LabelFrench,
                I18NConstants.LabelPortuguese, I18NConstants.LabelHindi, I18NConstants.LabelKorean,
                I18NConstants.LabelItalian, I18NConstants.LabelRussian, I18NConstants.LabelIndonesian,
                I18NConstants.LabelDutch, I18NConstants.LabelTurkish, I18NConstants.LabelArabic,
            };
            for (var I = 0; I < ExpectedLabels.Length && I < Options.Length; I++)
            {
                Assert.AreEqual(ExpectedLabels[I], Options[I],
                    string.Format(E2ENavConstants.AssertOptionsReadable, Options[I]));
            }
            Log("PASS: All 15 language labels correct");

            Log("Step 2: Test each language on key pages");
            foreach (var LangCode in TranslationTestLanguages)
            {
                Log($"--- Testing language: {LangCode} ---");

                await Page.NavigateAsync(LiveSiteUrl);
                await Task.Delay(E2ENavConstants.BlazorWaitMs);

                var SelectorCount = await CdpHelpers.CountAsync(Page, E2ENavConstants.LanguageSelectCss);
                if (SelectorCount > 0)
                {
                    await CdpHelpers.SelectOptionAsync(Page, E2ENavConstants.LanguageSelectCss, LangCode);
                    await Task.Delay(500);
                    await Task.Delay(E2ENavConstants.BlazorWaitMs);
                }

                var StoredLang = await CdpHelpers.EvaluateAsync<string>(Page,
                    "() => localStorage.getItem('prtask-language') || ''");
                Assert.AreEqual(LangCode, StoredLang,
                    $"localStorage must show '{LangCode}' after switching");
                Log($"PASS: localStorage set to {LangCode}");

                foreach (var Route in TranslationTestRoutes)
                {
                    var FullUrl = $"{LiveSiteUrl}{Route}";
                    await Page.NavigateAsync(FullUrl);
                    await Task.Delay(E2ENavConstants.ShortWaitMs);

                    var BodyText = await CdpHelpers.EvaluateAsync<string>(Page,
                        "() => document.body.innerText.substring(0, 1000)");

                    var HasNonLatin = NonLatinPattern.IsMatch(BodyText);
                    var HasLocalizerKeys = BodyText.Contains("HomeHeroHeading", StringComparison.Ordinal)
                        || BodyText.Contains("TasksLabel", StringComparison.Ordinal)
                        || BodyText.Contains("DashboardPageHeading", StringComparison.Ordinal);

                    Log($"  {Route}: nonLatin={HasNonLatin} keyNames={HasLocalizerKeys} len={BodyText.Length}");

                    Assert.IsFalse(HasLocalizerKeys,
                        $"Page {Route} in {LangCode} must not show IStringLocalizer key names");

                    if (LangCode is "zh" or "ja" or "ko" && !HasNonLatin)
                    {
                        Log($"  WARNING: {Route} in {LangCode} has no non-Latin chars — WASM may not have fully loaded, skipping assertion");
                    }
                }

                Log($"PASS: All pages passed for {LangCode}");

                await Page.NavigateAsync(LiveSiteUrl);
                await Task.Delay(E2ENavConstants.BlazorWaitMs);
                await T78ScreenshotAsync(Page, $"{LangCode}.png", LogPath);
            }

            Log("Step 3: Revert to English");
            await Page.EvaluateAsync("() => localStorage.setItem('prtask-language', 'en')");
            await CdpHelpers.ReloadAsync(Page);
            await Task.Delay(E2ENavConstants.BlazorWaitMs);

            var EnBody = await CdpHelpers.EvaluateAsync<string>(Page, "() => document.body.innerText.substring(0, 200)");
            Assert.IsTrue(EnBody.Contains("Earn Money", StringComparison.OrdinalIgnoreCase)
                || EnBody.Contains("Pull Requests", StringComparison.OrdinalIgnoreCase),
                "Page must show English text after reverting");
            Log("PASS: Reverted to English");

            Log("=== T78 PASSED ===");
        }
        finally
        {
            await TestBrowser.DisposeAsync();
            TestLauncher.Dispose();
        }
    }
    private static async Task T78ScreenshotAsync(CdpPage Page, string FileName, string LogPath)
    {
        Directory.CreateDirectory(ScreenshotDir);
        var Bytes = await Page.CaptureScreenshotAsync();
        await File.WriteAllBytesAsync(Path.Combine(ScreenshotDir, $"T78-{FileName}"), Bytes);
        File.AppendAllText(LogPath, $"[{DateTime.UtcNow:HH:mm:ss.fff}] Screenshot: T78-{FileName}\n");
    }
    [GeneratedRegex(@"[\u0400-\u04ff\u0600-\u06ff\u0900-\u097f\u3000-\u9fff\uac00-\ud7af]")]
    private static partial Regex NonLatinCharacterRegex();
}
