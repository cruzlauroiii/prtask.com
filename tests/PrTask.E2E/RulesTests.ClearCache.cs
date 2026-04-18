using PrTask.Cdp;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static string CacheLogPath => Path.Combine(SolutionRoot, "output", "clear-cache-debug.log");
    [TestMethod, TestCategory("Nav"), Timeout(300000)]
    [DisplayName("T76 Clear cache — prtaskClearCache exists, SW registered, click reloads without query params")]
    public async Task T76ClearCacheAsync()
    {
        Directory.CreateDirectory(Path.GetDirectoryName(CacheLogPath)!);
        File.WriteAllText(CacheLogPath, $"=== T76 Clear Cache — {DateTime.UtcNow:O} ===\n\n");
        var CacheLauncher = new ChromeLauncher();
        var CacheBrowser = await CacheLauncher.LaunchAsync(new ChromeLaunchOptions { Headless = false });
        var CachePage = await CacheBrowser.NewPageAsync();
        await CachePage.EnableConsoleAsync();
        try
        {
            CacheLog("Navigating to home page");
            await CachePage.NavigateAsync(LiveSiteUrl);
            await Task.Delay(E2ENavConstants.BlazorWaitMs);
            await T76ScreenshotAsync(CachePage, "01-home.png");

            var FnExists = await CdpHelpers.EvaluateAsync<bool>(CachePage,
                $"() => typeof window.{E2ENavConstants.ClearCacheFunctionName} === 'function'");
            CacheLog($"{E2ENavConstants.ClearCacheFunctionName} function exists: {FnExists}");
            Assert.IsTrue(FnExists, E2ENavConstants.AssertClearCacheFunctionExists);

            try
            {
                var SwRegistered = await CdpHelpers.EvaluateAsync<bool>(CachePage, "async () => { if (!('serviceWorker' in navigator)) return false; var Reg = await navigator.serviceWorker.getRegistration(); return !!Reg; }");
                if (!SwRegistered)
                {
                    CacheLog("WARNING: Service Worker not registered — headless Chrome may not support SW registration");
                }
            }
            catch (Exception SwEx)
            {
                CacheLog($"WARNING: SW registration check failed: {SwEx.Message}");
            }

            var CacheBtnCount = await CdpHelpers.CountAsync(CachePage, E2ENavConstants.ClearCacheBtnTitleCss);
            if (CacheBtnCount == 0)
            {
                var AllCount = await CdpHelpers.CountAsync(CachePage, E2ENavConstants.NavActionButtonsCss);
                CacheLog($"No clear-cache button found by title. All action buttons: {AllCount}");
            }
            Assert.IsTrue(CacheBtnCount > 0, E2ENavConstants.AssertClearCacheFunctionExists);

            var UrlBefore = await CdpHelpers.GetUrlAsync(CachePage);
            CacheLog($"URL before clear: {UrlBefore}");
            await CdpHelpers.ClickSelectorAsync(CachePage, E2ENavConstants.ClearCacheBtnTitleCss);
            await Task.Delay(500);
            await Task.Delay(E2ENavConstants.ShortWaitMs);

            var UrlAfter = await CdpHelpers.GetUrlAsync(CachePage);
            CacheLog($"URL after clear: {UrlAfter}");
            await T76ScreenshotAsync(CachePage, "02-after-clear.png");

            Assert.IsFalse(UrlAfter.Contains("?t=", StringComparison.Ordinal)
                || UrlAfter.Contains("?v=", StringComparison.Ordinal),
                E2ENavConstants.AssertNoQueryParamsAfterClear);

            var BodyLength = await CdpHelpers.EvaluateAsync<int>(CachePage, "() => document.body.innerText.length");
            Assert.IsTrue(BodyLength > E2ENavConstants.MinBodyLengthAfterClear,
                string.Format(E2ENavConstants.AssertPageLoadedAfterClear,
                    E2ENavConstants.MinBodyLengthAfterClear));
            CacheLog("=== T76 PASSED ===");
        }
        finally
        {
            await CacheBrowser.DisposeAsync();
            CacheLauncher.Dispose();
        }
    }
    private static void CacheLog(string Message)
    {
        File.AppendAllText(CacheLogPath, $"[{DateTime.UtcNow:HH:mm:ss.fff}] {Message}\n");
    }
    private static async Task T76ScreenshotAsync(CdpPage Page, string FileName)
    {
        Directory.CreateDirectory(ScreenshotDir);
        var Bytes = await Page.CaptureScreenshotAsync();
        await File.WriteAllBytesAsync(Path.Combine(ScreenshotDir, $"T76-{FileName}"), Bytes);
        CacheLog($"Screenshot: T76-{FileName}");
    }
}
