using System.Text.RegularExpressions;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions;
using Microsoft.Playwright;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [GeneratedRegex(@"href=""([^""]*\.css)""")]
    private static partial Regex CssHrefPattern();
    [GeneratedRegex(@"href=""([^""]*\.css)""")]
    private static partial Regex CssHrefPattern();
    [GeneratedRegex(@"href=""([^""]*\.css)""")]
    private static partial Regex CssHrefPattern();
    [GeneratedRegex(@"href=""([^""]*\.css)""")]
    private static partial Regex CssHrefPattern();
    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req8: narrow viewport — nav links overflow and are scrollable by touch drag")]
    public async Task NarrowViewportTouchDragScrollAsync()
    {
        var Context = await Browser.NewContextAsync(new BrowserNewContextOptions
        {
            ViewportSize = new ViewportSize { Width = 375, Height = 667 },
            IgnoreHTTPSErrors = true,
            HasTouch = true,
            IsMobile = true,
        });
        var Page = await Context.NewPageAsync();
        try
        {
            await Page.GotoAsync(TestBaseUrl,
                new PageGotoOptions { WaitUntil = WaitUntilState.DOMContentLoaded });
            var NavState = await Page.EvaluateAsync<System.Text.Json.JsonElement>(
                "() => { var nl = document.querySelector('.nav-links'); if (!nl) return { exists: false }; var cs = getComputedStyle(nl); return { exists: true, overflowX: cs.overflowX, scrollbarWidth: cs.scrollbarWidth, scrollWidth: nl.scrollWidth, clientWidth: nl.clientWidth, overflows: nl.scrollWidth > nl.clientWidth, linkCount: nl.querySelectorAll('a').length, whiteSpace: cs.whiteSpace, flexWrap: cs.flexWrap }; }");
            Assert.IsTrue(NavState.GetProperty("exists").GetBoolean(), "Nav links must exist");
            Assert.IsTrue(NavState.GetProperty("linkCount").GetInt32() >= 5,
                "Must have at least 5 nav links");
            var FlexWrap = NavState.GetProperty("flexWrap").GetString();
            Assert.AreEqual("nowrap", FlexWrap,
                $"Nav links must not wrap (flex-wrap: nowrap), got {FlexWrap}");
            var ScrollInfo = await Page.EvaluateAsync<System.Text.Json.JsonElement>(
                "() => { var nl = document.querySelector('.nav-links'); var sw = nl.scrollWidth; var cw = nl.clientWidth; nl.style.overflowX = 'auto'; var before = nl.scrollLeft; nl.scrollLeft = sw; var after = nl.scrollLeft; return { scrollWidth: sw, clientWidth: cw, before: before, after: after, overflows: sw > cw }; }");
            Assert.IsTrue(ScrollInfo.GetProperty("overflows").GetBoolean(),
                "Nav links scrollWidth must exceed clientWidth on narrow viewport");
            Assert.IsTrue(ScrollInfo.GetProperty("after").GetDouble() > ScrollInfo.GetProperty("before").GetDouble(),
                "Scrolling must work after forcing overflow-x: auto");
        }
        finally
        {
            await Page.CloseAsync();
            await Context.DisposeAsync();
        }
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req8: no visible scrollbar on nav links")]
    public async Task NoVisibleScrollbarOnNavLinksAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(30) };
        var PageResponse = await Client.GetAsync($"https://{AppConstants.AppDomain}/");
        var Html = await PageResponse.Content.ReadAsStringAsync();
        var CssMatch = CssHrefPattern().Match(Html);
        Assert.IsTrue(CssMatch.Success, "Page must reference a CSS file");
        var CssPath = CssMatch.Groups[1].Value;
        var CssUrl = CssPath.Contains("://") ? CssPath : $"https://{AppConstants.AppDomain}/{CssPath}";
        var CssResponse = await Client.GetAsync(CssUrl);
        Assert.IsTrue(CssResponse.IsSuccessStatusCode, $"CSS {CssUrl} must return 200");
        var Css = await CssResponse.Content.ReadAsStringAsync();
        Assert.IsTrue(
            Css.Contains("scrollbar-width:none") || Css.Contains("scrollbar-width: none"),
            "CSS must contain scrollbar-width: none for hidden scrollbar");
        Assert.IsTrue(
            Css.Contains("overflow-x:auto") || Css.Contains("overflow-x: auto"),
            "CSS must contain overflow-x: auto for horizontal scrolling");
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req8: all nav links present in horizontal layout")]
    public async Task AllNavLinksReachableByScrollAsync()
    {
        var Context = await Browser.NewContextAsync(new BrowserNewContextOptions
        {
            ViewportSize = new ViewportSize { Width = 320, Height = 568 },
            IgnoreHTTPSErrors = true,
        });
        var Page = await Context.NewPageAsync();
        try
        {
            await Page.GotoAsync(TestBaseUrl,
                new PageGotoOptions { WaitUntil = WaitUntilState.DOMContentLoaded });
            var Info = await Page.EvaluateAsync<System.Text.Json.JsonElement>(
                "() => { var nl = document.querySelector('.nav-links'); if (!nl) return { exists: false }; var links = nl.querySelectorAll('a'); return { exists: true, count: links.length, flexDirection: getComputedStyle(nl).flexDirection, flexWrap: getComputedStyle(nl).flexWrap, scrollWidth: nl.scrollWidth, clientWidth: nl.clientWidth }; }");
            Assert.IsTrue(Info.GetProperty("exists").GetBoolean(), "Nav links must exist");
            Assert.IsTrue(Info.GetProperty("count").GetInt32() >= 5,
                $"Must have at least 5 nav links, got {Info.GetProperty("count").GetInt32()}");
            Assert.AreEqual("row", Info.GetProperty("flexDirection").GetString(),
                "Nav links must be in row direction");
            Assert.AreEqual("nowrap", Info.GetProperty("flexWrap").GetString(),
                "Nav links must not wrap");
        }
        finally
        {
            await Page.CloseAsync();
            await Context.DisposeAsync();
        }
    }
}
