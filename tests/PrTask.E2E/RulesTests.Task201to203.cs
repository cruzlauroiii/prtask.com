using Microsoft.Playwright;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static async Task Step8PaymentHistoryAsync()
    {
        await NavigateAndWaitAsync($"{BaseUrl}{RouteConstants.ClientPayments}", "Payment History");
        Assert.IsTrue(await BrowserPage.Locator("input#PayerIdInput").IsVisibleAsync(),
            "Step8: PayerIdInput must be visible");
        Assert.IsTrue(await BrowserPage.Locator("button:has-text('Load Payments')").IsVisibleAsync(),
            "Step8: Load Payments button must be visible");
        await BrowserPage.Locator("input#PayerIdInput").FillAsync("test-developer");
        await BrowserPage.Locator("button:has-text('Load Payments')").ClickAsync();
        try
        {
            await BrowserPage.WaitForLoadStateAsync(LoadState.NetworkIdle,
                new PageWaitForLoadStateOptions { Timeout = 10000 });
        }
        catch (TimeoutException) { }
        await TakeScreenshotAsync("08-payment-history.png");
        var HasTable = await BrowserPage.Locator(".leaderboard-table").CountAsync() > 0;
        var HasEmpty = await BrowserPage.Locator(".empty-state").CountAsync() > 0;
        Assert.IsTrue(HasTable || HasEmpty, "Step8: Must show table or empty state after load");
    }
    private static async Task Step9WithdrawSettingsAsync()
    {
        await NavigateAndWaitAsync($"{BaseUrl}{RouteConstants.Settings}", "Settings");
        Assert.IsTrue(await BrowserPage.Locator("h2:has-text('Withdrawal Settings')").IsVisibleAsync(),
            "Step9: Withdrawal Settings heading visible");
        var Payout = BrowserPage.Locator("select#PayoutMethod");
        Assert.IsTrue(await Payout.IsVisibleAsync(), "Step9: PayoutMethod select visible");
        var Opts = await Payout.Locator("option").AllTextContentsAsync();
        Assert.IsTrue(Opts.Any(O => O.Contains("Bank")), "Step9: Bank option");
        Assert.IsTrue(Opts.Any(O => O.Contains("PayPal")), "Step9: PayPal option");
        Assert.IsTrue(await BrowserPage.Locator("input#PayoutDetails").IsVisibleAsync(),
            "Step9: PayoutDetails visible");
        Assert.IsTrue(await BrowserPage.Locator("button:has-text('Save Settings')").IsVisibleAsync(),
            "Step9: Save Settings button visible");
        await TakeScreenshotAsync("09-settings-withdrawal.png");
    }
    private static void Step10VerifyAllScreenshots()
    {
        var Files = new[]
        {
            "01-login-page.png", "02-create-task-form.png", "03-task-list.png",
            "04-submit-pr-form.png", "05-pr-diff-viewer.png", "06-pr-review-comments.png",
            "07-approve-pr.png", "08-payment-history.png", "09-settings-withdrawal.png"
        };
        foreach (var F in Files)
        {
            var P = Path.Combine(ScreenshotDir, F);
            Assert.IsTrue(File.Exists(P), $"Step10: {F} must exist");
            Assert.IsTrue(new FileInfo(P).Length > 10240, $"Step10: {F} must be > 10KB");
        }
    }
}
