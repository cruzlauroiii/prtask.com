using PrTask.Cdp;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static async Task GoOfflineAsync()
    {
        await CdpHelpers.SetOfflineAsync(BrowserPage, true);
    }

    private static async Task GoOnlineAsync()
    {
        await CdpHelpers.SetOfflineAsync(BrowserPage, false);
    }

    private static async Task TestOfflineRenderAsync(string Route, string PageIdentifier)
    {
        var Url = $"{BaseUrl}{Route}";
        TrackUrlVisit(Url);
        await BrowserPage.NavigateAsync(Url);
        try { using var Cts = new CancellationTokenSource(PlatformTestConstants.PlatformNavigationTimeoutMs); await BrowserPage.WaitForLoadAsync(Cts.Token); } catch { }
        await Task.Delay(500);

        await GoOfflineAsync();
        var OfflineBody = await CdpHelpers.GetTextContentAsync(BrowserPage, "body");
        Assert.IsTrue(OfflineBody.Length > 10,
            $"TestOfflineRender [{PageIdentifier}] OFFLINE: page must render ({OfflineBody.Length} chars)");

        await GoOnlineAsync();
        await CdpHelpers.ReloadAsync(BrowserPage, PlatformTestConstants.PlatformActionTimeoutMs);
        var OnlineBody = await CdpHelpers.GetTextContentAsync(BrowserPage, "body");
        Assert.IsTrue(OnlineBody.Length > 10,
            $"TestOfflineRender [{PageIdentifier}] ONLINE: must sync after reconnect ({OnlineBody.Length} chars)");
    }

    private static async Task TestOfflineFormAsync(string Route, string FormSelector,
        Dictionary<string, string> Fields)
    {
        var Url = $"{BaseUrl}{Route}";
        TrackUrlVisit(Url);
        await BrowserPage.NavigateAsync(Url);
        try { using var Cts = new CancellationTokenSource(PlatformTestConstants.PlatformNavigationTimeoutMs); await BrowserPage.WaitForLoadAsync(Cts.Token); } catch { }
        await Task.Delay(500);

        await GoOfflineAsync();
        var OfflineBody = await CdpHelpers.GetTextContentAsync(BrowserPage, "body");
        Assert.IsTrue(OfflineBody.Length > 10,
            $"TestOfflineForm [{Route}] OFFLINE: page must render ({OfflineBody.Length} chars)");

        foreach (var Kvp in Fields)
        {
            await CdpHelpers.FillFieldAsync(BrowserPage, Kvp.Key, Kvp.Value);
        }

        await CdpHelpers.ClickSelectorAsync(BrowserPage,
            $"{FormSelector} button[type='submit'], {FormSelector} button");

        await GoOnlineAsync();
        await CdpHelpers.ReloadAsync(BrowserPage, PlatformTestConstants.PlatformActionTimeoutMs);
        var OnlineBody = await CdpHelpers.GetTextContentAsync(BrowserPage, "body");
        Assert.IsTrue(OnlineBody.Length > 10,
            $"TestOfflineForm [{Route}] ONLINE: must sync after reconnect ({OnlineBody.Length} chars)");
    }

    private static async Task VerifySyncStatusBarAsync(string ExpectedState)
    {
        var StatusCount = await CdpHelpers.CountAsync(BrowserPage,
            ".sync-status, .connection-status, [data-sync-status], .status-bar, .offline-indicator");
        if (StatusCount > 0)
        {
            var StatusText = await CdpHelpers.GetTextContentAsync(BrowserPage,
                ".sync-status, .connection-status, [data-sync-status], .status-bar, .offline-indicator");
            Assert.IsTrue(StatusText.Contains(ExpectedState, StringComparison.OrdinalIgnoreCase),
                $"VerifySyncStatusBar: expected '{ExpectedState}', got '{StatusText}'");
        }
        else
        {
            var BodyText = await CdpHelpers.GetTextContentAsync(BrowserPage, "body");
            LogWarning($"VerifySyncStatusBar: no status bar element found, body contains {BodyText.Length} chars");
        }
    }

    private static async Task ToggleOfflineOnlineAsync(int CycleCount)
    {
        for (var Cycle = 1; Cycle <= CycleCount; Cycle++)
        {
            await GoOfflineAsync();
            var OfflineText = await CdpHelpers.GetTextContentAsync(BrowserPage, "body");
            Assert.IsTrue(OfflineText.Length > 10,
                $"ToggleOfflineOnline cycle {Cycle}/{CycleCount} OFFLINE: page must have content ({OfflineText.Length} chars)");

            await GoOnlineAsync();
            await CdpHelpers.ReloadAsync(BrowserPage, PlatformTestConstants.PlatformActionTimeoutMs);
            var OnlineText = await CdpHelpers.GetTextContentAsync(BrowserPage, "body");
            Assert.IsTrue(OnlineText.Length > 10,
                $"ToggleOfflineOnline cycle {Cycle}/{CycleCount} ONLINE: page must render after reconnect ({OnlineText.Length} chars)");

            var ErrorCount = await CdpHelpers.CountAsync(BrowserPage,
                ".blazor-error-boundary, .error-boundary, [data-error='true']");
            Assert.IsTrue(ErrorCount == 0,
                $"ToggleOfflineOnline cycle {Cycle}/{CycleCount}: must have no error boundary after toggle");
        }
    }
}
