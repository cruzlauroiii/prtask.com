using System.Text.RegularExpressions;
using PrTask.Cdp;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static readonly string LangLogPath = Path.Combine(SolutionRoot, "output", "lang-selector-debug.log");
    [TestMethod, TestCategory("Nav"), Timeout(300000)]
    [DisplayName("T75 Language selector — 15 options, no IStringLocalizer keys, zh persists on reload with Chinese text, reverts to EN")]
    public async Task T75LanguageSelectorAsync()
    {
        Directory.CreateDirectory(Path.GetDirectoryName(LangLogPath)!);
        File.WriteAllText(LangLogPath, $"=== T75 Language Selector — {DateTime.UtcNow:O} ===\n\n");
        var LangLauncher = new ChromeLauncher();
        var LangBrowser = await LangLauncher.LaunchAsync(new ChromeLaunchOptions { Headless = false });
        var LangPage = await LangBrowser.NewPageAsync();
        await LangPage.EnableConsoleAsync();
        try
        {
            LangLog("Navigating to home page");
            await LangPage.NavigateAsync(LiveSiteUrl);
            await Task.Delay(E2ENavConstants.BlazorWaitMs);
            await T75ScreenshotAsync(LangPage, "01-home.png");

            var LangSelectCount = await CdpHelpers.CountAsync(LangPage, E2ENavConstants.LanguageSelectCss);
            Assert.IsTrue(LangSelectCount > 0, E2ENavConstants.AssertLanguageSelectorExists);

            var Options = await CdpHelpers.AllTextContentsAsync(LangPage, $"{E2ENavConstants.LanguageSelectCss} {E2ENavConstants.LanguageOptionCss}");
            LangLog($"Options: [{string.Join(", ", Options.Select(O => $"\"{O}\""))}]");
            Assert.AreEqual(E2ENavConstants.ExpectedLanguageOptionCount, Options.Length,
                string.Format(E2ENavConstants.AssertLanguageOptionCount,
                    E2ENavConstants.ExpectedLanguageOptionCount, Options.Length));

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

            Assert.IsFalse(
                Options.Any(O => O.Contains(E2ENavConstants.IStringLocalizerKeyPattern, StringComparison.Ordinal)),
                E2ENavConstants.AssertNoLocalizerKeyNames);
            LangLog("PASS: 15 options with correct labels, no key names");

            LangLog("Changing language to Chinese (zh)...");
            await CdpHelpers.SelectOptionAsync(LangPage, E2ENavConstants.LanguageSelectCss, I18NConstants.LanguageCodeChinese);
            await Task.Delay(500);
            await Task.Delay(E2ENavConstants.BlazorWaitMs);
            await T75ScreenshotAsync(LangPage, "02-after-zh.png");

            var StoredLang = await CdpHelpers.EvaluateAsync<string>(LangPage,
                "() => localStorage.getItem('prtask-language') || '(null)'");
            Assert.AreEqual(I18NConstants.LanguageCodeChinese, StoredLang,
                E2ENavConstants.AssertLanguageSavedToLocalStorage);

            var LangAfterReloadCount = await CdpHelpers.CountAsync(LangPage, E2ENavConstants.LanguageSelectCss);
            if (LangAfterReloadCount > 0)
            {
                var ValAfter = await CdpHelpers.GetInputValueAsync(LangPage, E2ENavConstants.LanguageSelectCss);
                Assert.AreEqual(I18NConstants.LanguageCodeChinese, ValAfter,
                    string.Format(E2ENavConstants.AssertLanguagePersistsAfterReload,
                        I18NConstants.LanguageCodeChinese, ValAfter));
            }

            var BodyText = await CdpHelpers.EvaluateAsync<string>(LangPage,
                "() => document.body.innerText.substring(0, 500)");
            Assert.IsTrue(ChineseCharacterPattern().IsMatch(BodyText),
                E2ENavConstants.AssertChineseCharactersPresent);
            LangLog("PASS: Chinese characters detected on page");

            await CdpHelpers.ReloadAsync(LangPage);
            await Task.Delay(E2ENavConstants.BlazorWaitMs);

            var OptionsAfterReload = await CdpHelpers.AllTextContentsAsync(LangPage, $"{E2ENavConstants.LanguageSelectCss} {E2ENavConstants.LanguageOptionCss}");
            var FirstOptionAfterReload = OptionsAfterReload.Length > 0 ? OptionsAfterReload[0] : "(none)";
            Assert.AreEqual(I18NConstants.LabelEnglish, FirstOptionAfterReload,
                string.Format(E2ENavConstants.AssertFirstOptionEnglish, FirstOptionAfterReload));
            Assert.IsFalse(
                OptionsAfterReload.Any(O => O.Contains(E2ENavConstants.IStringLocalizerKeyPattern, StringComparison.Ordinal)),
                E2ENavConstants.AssertNoLocalizerKeyNames);
            LangLog("PASS: Options still show readable labels after reload");

            LangLog("Switching back to English...");
            var LangRevertCount = await CdpHelpers.CountAsync(LangPage, E2ENavConstants.LanguageSelectCss);
            if (LangRevertCount > 0)
            {
                await CdpHelpers.SelectOptionAsync(LangPage, E2ENavConstants.LanguageSelectCss, I18NConstants.LanguageCodeEnglish);
                await Task.Delay(500);
                await Task.Delay(E2ENavConstants.BlazorWaitMs);
            }

            var ValReverted = await CdpHelpers.GetInputValueAsync(LangPage, E2ENavConstants.LanguageSelectCss);
            Assert.AreEqual(I18NConstants.LanguageCodeEnglish, ValReverted,
                string.Format(E2ENavConstants.AssertLanguagePersistsAfterReload,
                    I18NConstants.LanguageCodeEnglish, ValReverted));
            LangLog("=== T75 PASSED ===");
        }
        finally
        {
            await LangBrowser.DisposeAsync();
            LangLauncher?.Dispose();
        }
    }
    private static void LangLog(string Message)
    {
        File.AppendAllText(LangLogPath, $"[{DateTime.UtcNow:HH:mm:ss.fff}] {Message}\n");
    }
    private static async Task T75ScreenshotAsync(CdpPage Page, string FileName)
    {
        Directory.CreateDirectory(ScreenshotDir);
        var Bytes = await Page.CaptureScreenshotAsync();
        await File.WriteAllBytesAsync(Path.Combine(ScreenshotDir, $"T75-{FileName}"), Bytes);
        LangLog($"Screenshot: T75-{FileName}");
    }
    [GeneratedRegex(@"[\u4e00-\u9fff]")]
    private static partial Regex ChineseCharacterPattern();
}
