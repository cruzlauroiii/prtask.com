using Microsoft.Playwright;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req4: language selector, theme toggle, username are in burger menu, not header")]
    public async Task BurgerMenuContainsExtrasAsync()
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
                $"Header must be one line (height={NavHeight}px, max 60px)");
        }
        finally
        {
            await Page.CloseAsync();
            await Context.DisposeAsync();
        }
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req6: active page highlighted in nav for each page")]
    public async Task ActiveLinkHighlightedOnEveryPageAsync()
    {
        var Context = await Browser.NewContextAsync(new BrowserNewContextOptions
        {
            ViewportSize = new ViewportSize { Width = 1280, Height = 720 },
            IgnoreHTTPSErrors = true,
        });
        var Page = await Context.NewPageAsync();
        try
        {
            var PagesToCheck = new[]
            {
                ("Tasks", "Tasks"),
                ("Leaderboard", "Leaderboard"),
                ("HowItWorks", "How It Works"),
                ("Pricing", "Pricing"),
                ("About", "About"),
                ("Dashboard", "Dashboard"),
                ("Sprints", "Sprints"),
                ("Boards", "Boards"),
                ("Download", "Download"),
                ("Settings", "Settings"),
            };
            var Failures = new List<string>();
            foreach (var (Route, LinkText) in PagesToCheck)
            {
                await Page.GotoAsync($"{TestBaseUrl}/{Route}",
                    new PageGotoOptions { WaitUntil = WaitUntilState.DOMContentLoaded, Timeout = 15000 });
                var HasActive = await Page.EvaluateAsync<bool>(
                    "(linkText) => { var links = document.querySelectorAll('.nav-links a'); for (var a of links) { if (a.textContent.trim() === linkText && (a.classList.contains('active') || a.getAttribute('aria-current') === 'page')) return true; } return false; }",
                    LinkText);
                if (!HasActive)
                {
                    Failures.Add($"/{Route}: '{LinkText}' link not highlighted");
                }
            }

            Assert.AreEqual(0, Failures.Count,
                $"Active link highlight missing:\n{string.Join("\n", Failures)}");
        }
        finally
        {
            await Page.CloseAsync();
            await Context.DisposeAsync();
        }
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req6: burger menu links also highlighted when active")]
    public async Task BurgerMenuLinksHighlightedAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(30) };
        var PagesToCheck = new[]
        {
            ("Tasks", "Tasks"),
            ("About", "About"),
            ("Settings", "Settings"),
        };
        var Failures = new List<string>();
        foreach (var (Route, _) in PagesToCheck)
        {
            var Response = await Client.GetAsync($"{TestBaseUrl}/{Route}");
            var Html = await Response.Content.ReadAsStringAsync();
            var PlainActive = $"href=\"{Route}\" aria-current=\"page\"";
            var PlainActiveAlt = $"href=\"{Route}\" aria-current=\"page\" class=\"active\"";
            var FpPattern = new System.Text.RegularExpressions.Regex(
                $"href=\"{Route}\\.[a-f0-9]{{10}}\\.html\" aria-current=\"page\"");
            if (!Html.Contains(PlainActive) && !Html.Contains(PlainActiveAlt) && !FpPattern.IsMatch(Html))
            {
                Failures.Add($"/{Route}: missing aria-current=page on nav link");
            }
        }

        Assert.AreEqual(0, Failures.Count,
            $"Burger menu active link:\n{string.Join("\n", Failures)}");
    }
}
