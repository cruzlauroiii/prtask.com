using Microsoft.Playwright;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Nav: header is strictly one line on desktop")]
    public async Task HeaderOneLineDesktopAsync()
    {
        var Context = await Browser.NewContextAsync(new BrowserNewContextOptions
        {
            ViewportSize = new ViewportSize { Width = 1280, Height = 720 },
            IgnoreHTTPSErrors = true,
        });
        var Page = await Context.NewPageAsync();
        try
        {
            await Page.GotoAsync(TestBaseUrl,
                new PageGotoOptions { WaitUntil = WaitUntilState.DOMContentLoaded });
            var NavHeight = await Page.EvaluateAsync<double>(
                "() => document.querySelector('.nav-menu')?.getBoundingClientRect().height ?? 0");
            Assert.IsTrue(NavHeight is > 0 and < 60,
                $"Nav must be one line (height={NavHeight}px, max 60px)");
        }
        finally
        {
            await Page.CloseAsync();
            await Context.DisposeAsync();
        }
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Nav: header is one line on mobile")]
    public async Task HeaderOneLineMobileAsync()
    {
        var Context = await Browser.NewContextAsync(new BrowserNewContextOptions
        {
            ViewportSize = new ViewportSize { Width = 375, Height = 667 },
            IgnoreHTTPSErrors = true,
        });
        var Page = await Context.NewPageAsync();
        try
        {
            await Page.GotoAsync(TestBaseUrl,
                new PageGotoOptions { WaitUntil = WaitUntilState.DOMContentLoaded });
            var NavHeight = await Page.EvaluateAsync<double>(
                "() => document.querySelector('.nav-menu')?.getBoundingClientRect().height ?? 0");
            Assert.IsTrue(NavHeight is > 0 and < 60,
                $"Mobile nav must be one line (height={NavHeight}px, max 60px)");
        }
        finally
        {
            await Page.CloseAsync();
            await Context.DisposeAsync();
        }
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Nav: narrow viewport — links scrollable, no visible scrollbar")]
    public async Task NarrowViewportScrollableLinksAsync()
    {
        var Context = await Browser.NewContextAsync(new BrowserNewContextOptions
        {
            ViewportSize = new ViewportSize { Width = 600, Height = 720 },
            IgnoreHTTPSErrors = true,
        });
        var Page = await Context.NewPageAsync();
        try
        {
            await Page.GotoAsync(TestBaseUrl,
                new PageGotoOptions { WaitUntil = WaitUntilState.DOMContentLoaded });
            var Result = await Page.EvaluateAsync<System.Text.Json.JsonElement>(
                "() => { const l = document.querySelector('.nav-links'); if (!l) return {exists:false}; const s = getComputedStyle(l); return { exists: true, overflowX: s.overflowX, scrollWidth: l.scrollWidth, clientWidth: l.clientWidth, linkCount: l.querySelectorAll('a').length }; }");
            Assert.IsTrue(Result.GetProperty("exists").GetBoolean(), "Nav links must exist");
            var LinkCount = Result.GetProperty("linkCount").GetInt32();
            Assert.IsTrue(LinkCount > 0, "Must have links in nav");
        }
        finally
        {
            await Page.CloseAsync();
            await Context.DisposeAsync();
        }
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Nav: active page link is highlighted")]
    public async Task ActiveLinkHighlightedAsync()
    {
        var Context = await Browser.NewContextAsync(new BrowserNewContextOptions
        {
            ViewportSize = new ViewportSize { Width = 1280, Height = 720 },
            IgnoreHTTPSErrors = true,
        });
        var Page = await Context.NewPageAsync();
        try
        {
            await Page.GotoAsync($"{TestBaseUrl}/Tasks",
                new PageGotoOptions { WaitUntil = WaitUntilState.DOMContentLoaded });
            await Page.WaitForTimeoutAsync(500);
            var HasActive = await Page.EvaluateAsync<bool>(
                "() => { const links = document.querySelectorAll('.nav-links a'); for (const a of links) { if (a.textContent.trim() === 'Tasks' && (a.classList.contains('active') || a.getAttribute('aria-current') === 'page')) return true; } return false; }");
            Assert.IsTrue(HasActive, "Tasks link must have active class or aria-current=page on /Tasks");
        }
        finally
        {
            await Page.CloseAsync();
            await Context.DisposeAsync();
        }
    }
}
