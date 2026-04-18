using PrTask.Cdp;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static readonly string LangReloadLogPath = Path.Combine(SolutionRoot, "output", "lang-reload-debug.log");
    [TestMethod, TestCategory("Nav"), Timeout(300000)]
    [DisplayName("T77 Language reload — fresh context shows EN English on first load, reload, and new tab")]
    public async Task T77LangReloadAsync()
    {
        Directory.CreateDirectory(Path.GetDirectoryName(LangReloadLogPath)!);
        File.WriteAllText(LangReloadLogPath, $"=== T77 Language Reload — {DateTime.UtcNow:O} ===\n\n");
        var ReloadLauncher = new ChromeLauncher();
        var ReloadBrowser = await ReloadLauncher.LaunchAsync(new ChromeLaunchOptions { Headless = false });
        try
        {
            var FirstPage = await ReloadBrowser.NewPageAsync();
            await FirstPage.EnableConsoleAsync();
            await FirstPage.NavigateAsync(LiveSiteUrl);
            await Task.Delay(E2ENavConstants.BlazorWaitMs);
            await T77ScreenshotAsync(FirstPage, "01-first-load.png");

            var Options1 = await GetLanguageOptionsAsync(FirstPage);
            LangReloadLog($"First load options: [{string.Join(", ", Options1.Select(O => $"\"{O}\""))}]");
            var FirstOption1 = Options1.Count > 0 ? Options1[0] : "(none)";
            Assert.AreEqual(I18NConstants.LabelEnglish, FirstOption1,
                string.Format(E2ENavConstants.AssertFirstOptionEnglish, FirstOption1));
            Assert.IsFalse(
                Options1.Any(O => O.Contains(E2ENavConstants.IStringLocalizerKeyPattern, StringComparison.Ordinal)),
                E2ENavConstants.AssertNoLocalizerKeyNames);
            LangReloadLog("PASS: First load shows EN English");

            await CdpHelpers.ReloadAsync(FirstPage);
            await Task.Delay(E2ENavConstants.BlazorWaitMs);
            await T77ScreenshotAsync(FirstPage, "02-after-reload.png");

            var Options2 = await GetLanguageOptionsAsync(FirstPage);
            LangReloadLog($"After reload options: [{string.Join(", ", Options2.Select(O => $"\"{O}\""))}]");
            var FirstOption2 = Options2.Count > 0 ? Options2[0] : "(none)";
            Assert.AreEqual(I18NConstants.LabelEnglish, FirstOption2,
                string.Format(E2ENavConstants.AssertFirstOptionEnglish, FirstOption2));
            LangReloadLog("PASS: After reload still shows EN English");

            var ExpectedOptions = new[]
            {
                I18NConstants.LabelEnglish, I18NConstants.LabelChinese, I18NConstants.LabelSpanish,
                I18NConstants.LabelJapanese, I18NConstants.LabelGerman, I18NConstants.LabelFrench,
                I18NConstants.LabelPortuguese, I18NConstants.LabelHindi, I18NConstants.LabelKorean,
                I18NConstants.LabelItalian, I18NConstants.LabelRussian, I18NConstants.LabelIndonesian,
                I18NConstants.LabelDutch, I18NConstants.LabelTurkish, I18NConstants.LabelArabic,
            };
            Assert.AreEqual(ExpectedOptions.Length, Options2.Count,
                string.Format(E2ENavConstants.AssertLanguageOptionCount,
                    ExpectedOptions.Length, Options2.Count));
            for (var I = 0; I < ExpectedOptions.Length && I < Options2.Count; I++)
            {
                Assert.AreEqual(ExpectedOptions[I], Options2[I],
                    E2ENavConstants.AssertOptionsConsistentAfterReload);
            }
            LangReloadLog("PASS: All options match after reload");

            var SecondPage = await ReloadBrowser.NewPageAsync();
            await SecondPage.EnableConsoleAsync();
            await SecondPage.NavigateAsync(LiveSiteUrl);
            await Task.Delay(E2ENavConstants.BlazorWaitMs);
            await T77ScreenshotAsync(SecondPage, "03-new-tab.png");

            var Options3 = await GetLanguageOptionsAsync(SecondPage);
            LangReloadLog($"New tab options: [{string.Join(", ", Options3.Select(O => $"\"{O}\""))}]");
            var FirstOption3 = Options3.Count > 0 ? Options3[0] : "(none)";
            Assert.AreEqual(I18NConstants.LabelEnglish, FirstOption3,
                string.Format(E2ENavConstants.AssertFirstOptionEnglish, FirstOption3));
            LangReloadLog("PASS: New tab shows EN English");

            await ClosePageAsync(SecondPage);
            await ClosePageAsync(FirstPage);
            LangReloadLog("=== T77 PASSED ===");
        }
        finally
        {
            await ReloadBrowser.DisposeAsync();
            ReloadLauncher?.Dispose();
        }
    }
    private static async Task<IReadOnlyList<string>> GetLanguageOptionsAsync(CdpPage Page)
    {
        var SelectCount = await CdpHelpers.CountAsync(Page, E2ENavConstants.LanguageSelectCss);
        return SelectCount > 0
            ? await CdpHelpers.AllTextContentsAsync(Page, $"{E2ENavConstants.LanguageSelectCss} {E2ENavConstants.LanguageOptionCss}")
            : [];
    }
    private static void LangReloadLog(string Message)
    {
        File.AppendAllText(LangReloadLogPath, $"[{DateTime.UtcNow:HH:mm:ss.fff}] {Message}\n");
    }
    private static async Task T77ScreenshotAsync(CdpPage Page, string FileName)
    {
        Directory.CreateDirectory(ScreenshotDir);
        var Bytes = await Page.CaptureScreenshotAsync();
        await File.WriteAllBytesAsync(Path.Combine(ScreenshotDir, $"T77-{FileName}"), Bytes);
        LangReloadLog($"Screenshot: T77-{FileName}");
    }
}
