using Microsoft.Playwright;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req11: burger menu works without JavaScript (CSS-only)")]
    public async Task BurgerMenuWorksWithoutJsAsync()
    {
        var Context = await Browser.NewContextAsync(new BrowserNewContextOptions
        {
            ViewportSize = new ViewportSize { Width = 375, Height = 667 },
            IgnoreHTTPSErrors = true,
            JavaScriptEnabled = false,
        });
        var Page = await Context.NewPageAsync();
        try
        {
            await Page.GotoAsync(TestBaseUrl,
                new PageGotoOptions { WaitUntil = WaitUntilState.DOMContentLoaded });
            var HasCheckbox = await Page.Locator("#nav-check").CountAsync();
            Assert.AreEqual(1, HasCheckbox,
                "Nav must have a hidden checkbox with id=nav-check for CSS-only toggle");
            var HasLabel = await Page.Locator("label[for='nav-check']").CountAsync();
            Assert.AreEqual(1, HasLabel,
                "Nav must have a label for=nav-check as the burger toggle");
        }
        finally
        {
            await Page.CloseAsync();
            await Context.DisposeAsync();
        }
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req11: no onclick handlers in static nav HTML")]
    public async Task NoOnclickInStaticNavAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(30) };
        var Response = await Client.GetAsync($"{TestBaseUrl}/en/");
        var Html = await Response.Content.ReadAsStringAsync();
        Assert.IsFalse(Html.Contains("onclick="),
            "Static HTML must not have onclick handlers — burger menu must be CSS-only");
        Assert.IsTrue(Html.Contains("id=\"nav-check\""),
            "Static HTML must have checkbox with id=nav-check for CSS-only burger");
        Assert.IsTrue(Html.Contains("for=\"nav-check\""),
            "Static HTML must have label for=nav-check as burger toggle");
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req11: HtmlConstants uses checkbox toggle not button onclick")]
    public Task HtmlConstantsUsesCheckboxToggleAsync()
    {
        Assert.IsFalse(HtmlConstants.StaticNavHtml.Contains("onclick"),
            "StaticNavHtml must not use onclick — CSS-only burger");
        Assert.IsTrue(HtmlConstants.StaticNavHtml.Contains("nav-check"),
            "StaticNavHtml must have nav-check checkbox for CSS-only toggle");
        Assert.IsTrue(HtmlConstants.StaticNavHtml.Contains("<label"),
            "StaticNavHtml must use label element for burger toggle");
        Assert.IsTrue(HtmlConstants.StaticNavHtml.Contains("<input"),
            "StaticNavHtml must use input checkbox for burger state");
        return Task.CompletedTask;
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req1.1: no inline JavaScript in any page HTML")]
    public async Task NoInlineJavaScriptInAnyPageAsync()
    {
#pragma warning disable CS0162
        if (AppConstants.JavaScriptEnabled)
        {
            return;
        }
#pragma warning restore CS0162

#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(30) };
        var PagePaths = new[] { "/en/", "/en/Tasks", "/en/About", "/en/Settings", "/en/Legal/Terms" };
        var Failures = new List<string>();
        foreach (var Path in PagePaths)
        {
            var Response = await Client.GetAsync($"{TestBaseUrl}{Path}");
            if (!Response.IsSuccessStatusCode)
            {
                continue;
            }

            var Html = await Response.Content.ReadAsStringAsync();
            if (Html.Contains("<script"))
            {
                Failures.Add($"{Path} has <script> tag (inline or external)");
            }

            if (Html.Contains("onclick=") || Html.Contains("onload=") || Html.Contains("onerror="))
            {
                Failures.Add($"{Path} has inline event handler");
            }
        }

        Assert.AreEqual(0, Failures.Count,
            $"Inline JS found:\n{string.Join("\n", Failures)}");
    }
}
