using PrTask.Cdp;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static async Task AssertSeoContentAsync(string Url, string ExpectedH1, string? ExpectedTitle = null)
    {
        var JsDisabledPage = await CreateEmulatedPageAsync(DisableJs: true);
        try
        {
            await JsDisabledPage.NavigateAsync(Url);
            try { using var Cts = new CancellationTokenSource(30000); await JsDisabledPage.WaitForLoadAsync(Cts.Token); } catch { }
            var H1 = await CdpHelpers.GetTextContentAsync(JsDisabledPage, "h1");
            Assert.IsTrue(H1.Contains(ExpectedH1, StringComparison.OrdinalIgnoreCase),
                $"SEO: h1 on {Url} must contain '{ExpectedH1}', got '{H1}'");
            if (ExpectedTitle is not null)
            {
                var Title = await CdpHelpers.GetTitleAsync(JsDisabledPage);
                Assert.IsTrue(Title.Contains(ExpectedTitle, StringComparison.OrdinalIgnoreCase),
                    $"SEO: title on {Url} must contain '{ExpectedTitle}', got '{Title}'");
            }
        }
        finally
        {
            await ClosePageAsync(JsDisabledPage);
        }
    }

    private static async Task AssertPageNotBlankAsync(string Url)
    {
        var JsDisabledPage = await CreateEmulatedPageAsync(DisableJs: true);
        try
        {
            await JsDisabledPage.NavigateAsync(Url);
            try { using var Cts = new CancellationTokenSource(30000); await JsDisabledPage.WaitForLoadAsync(Cts.Token); } catch { }
            var BodyText = await CdpHelpers.GetTextContentAsync(JsDisabledPage, "body");
            Assert.IsTrue(BodyText.Trim().Length > 50,
                $"SEO: page {Url} must not be blank (JS disabled), got {BodyText.Trim().Length} chars");
        }
        finally
        {
            await ClosePageAsync(JsDisabledPage);
        }
    }

    private static async Task AssertMetaTagsAsync(string Url, string ExpectedTitle, string ExpectedDescription)
    {
        var JsDisabledPage = await CreateEmulatedPageAsync(DisableJs: true);
        try
        {
            await JsDisabledPage.NavigateAsync(Url);
            try { using var Cts = new CancellationTokenSource(30000); await JsDisabledPage.WaitForLoadAsync(Cts.Token); } catch { }
            var Title = await CdpHelpers.GetTitleAsync(JsDisabledPage);
            Assert.IsTrue(Title.Contains(ExpectedTitle, StringComparison.OrdinalIgnoreCase),
                $"SEO: <title> on {Url} must contain '{ExpectedTitle}', got '{Title}'");
            var MetaDesc = await CdpHelpers.GetAttributeAsync(JsDisabledPage, "meta[name='description']", "content");
            Assert.IsTrue(MetaDesc.Contains(ExpectedDescription, StringComparison.OrdinalIgnoreCase),
                $"SEO: <meta description> on {Url} must contain '{ExpectedDescription}', got '{MetaDesc}'");
        }
        finally
        {
            await ClosePageAsync(JsDisabledPage);
        }
    }
}
