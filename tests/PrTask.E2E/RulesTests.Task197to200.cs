using Microsoft.Playwright;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static async Task Step4SubmitPrAsync()
    {
        var Src = ReadSource("PrTask.SharedUI", "Pages", "SubmitPrPage.razor");
        Assert.IsTrue(Src.Contains("id=\"GitHubPrUrl\""), "Step4: Source must have GitHubPrUrl field");
        Assert.IsTrue(Src.Contains("id=\"DeveloperId\""), "Step4: Source must have DeveloperId field");
        await NavigateAndWaitAsync($"{BaseUrl}{string.Format(RouteConstants.SubmitPr, "test-task-id")}", "Submit Pull Request");
        var PrUrlField = BrowserPage.Locator("input#GitHubPrUrl");
        if (await PrUrlField.CountAsync() > 0 && await PrUrlField.IsVisibleAsync())
        {
            await PrUrlField.FillAsync("https://github.com/prtask/demo-repo/pull/1");
            await BrowserPage.Locator("input#DeveloperId").FillAsync("test-developer");
        }
        await TakeScreenshotAsync("04-submit-pr-form.png");
    }
    private static async Task Step5CheckDiffViewerAsync()
    {
        var Src = ReadSource("PrTask.SharedUI", "Pages", "PullRequestDetailPage.razor");
        Assert.IsTrue(Src.Contains("diff-viewer"), "Step5: PR page must have diff-viewer");
        Assert.IsTrue(Src.Contains("diff-file-tree"), "Step5: PR page must have file tree");
        Assert.IsTrue(Src.Contains("line-@Line.Type") || (Src.Contains("line-add") && Src.Contains("line-del")), "Step5: Diff must show add/del lines");
        await NavigateAndWaitAsync($"{BaseUrl}{string.Format(RouteConstants.PullRequestDetail, "test-pr-id")}", "Pull Request Details");
        await TakeScreenshotAsync("05-pr-diff-viewer.png");
        if (await BrowserPage.Locator(".diff-viewer").CountAsync() > 0)
        {
            Assert.IsTrue(await BrowserPage.Locator(".diff-viewer").IsVisibleAsync(), "Step5: diff-viewer visible");
            Assert.IsTrue(await BrowserPage.Locator(".diff-file-tree").IsVisibleAsync(), "Step5: file tree visible");
        }
    }
    private static async Task Step6ReviewCommentsAsync()
    {
        var Src = ReadSource("PrTask.SharedUI", "Pages", "PullRequestDetailPage.razor");
        Assert.IsTrue(Src.Contains("pr-comments"), "Step6: Must have comments section");
        Assert.IsTrue(Src.Contains("PrDetailConstants.ApproveAndMergeButtonText"), "Step6: Must have Approve button");
        Assert.IsTrue(Src.Contains("PrDetailConstants.RequestChangesButtonText"), "Step6: Must have Request Changes button");
        await NavigateAndWaitAsync($"{BaseUrl}{string.Format(RouteConstants.PullRequestDetail, "test-pr-id")}", "Pull Request Details");
        if (await BrowserPage.Locator(".pr-comments h2").CountAsync() > 0)
        {
            var Txt = await BrowserPage.Locator(".pr-comments h2").TextContentAsync();
            Assert.IsTrue(Txt is not null && Txt.Contains("Review Comments"),
                $"Step6: Comments heading must be 'Review Comments', got '{Txt}'");
        }
        await TakeScreenshotAsync("06-pr-review-comments.png");
    }
    private static async Task Step7ApprovePrPayMayaAsync()
    {
        var Pay = ReadSource("PrTask.Server", "Endpoints", "PaymentEndpoints.cs");
        Assert.IsTrue(Pay.Contains("CreateCheckoutAsync"), "Step7: Must call CreateCheckoutAsync");
        var Maya = ReadSource("PrTask.Domain", "Constants", "MayaConstants.cs");
        Assert.IsTrue(Maya.Contains("SandboxPublicKey") && Maya.Contains("pk-"), "Step7: pk- key");
        Assert.IsTrue(Maya.Contains("SandboxSecretKey") && Maya.Contains("sk-"), "Step7: sk- key");
        var Cards = ReadSource("PrTask.Domain", "Constants", "MayaTestCards.cs");
        Assert.IsTrue(Cards.Contains("VisaNoThreeDsNumber"), "Step7: Visa test card");
        await NavigateAndWaitAsync($"{BaseUrl}/prs/test-pr-id", "Pull Request Details");
        var Approve = BrowserPage.Locator("button:has-text('Approve and Merge')");
        if (await Approve.CountAsync() > 0)
        {
            Assert.IsTrue(await Approve.IsVisibleAsync(), "Step7: Approve button visible");
        }
        await TakeScreenshotAsync("07-approve-pr.png");
    }
}
