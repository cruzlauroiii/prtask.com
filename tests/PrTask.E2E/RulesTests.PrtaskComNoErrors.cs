using System.Text.RegularExpressions;
using PrTask.Cdp;

namespace PrTask.E2E;

public partial class RulesTests
{
    private const string PrtaskComBaseUrl = "https://prtask.com/";

    private static readonly string[] PrtaskComAssets =
    [
        "icon-192.png"
    ];

    [GeneratedRegex(@"(?:href|src)=""([^""]*app\.min[^""]*\.css)""")]
    private static partial Regex FingerprintedCssPattern();
    [GeneratedRegex(@"src=""([^""]*blazor\.webassembly[^""]*\.js)""")]
    private static partial Regex FingerprintedBlazorJsPattern();
    [GeneratedRegex(@"src=""([^""]*circuit-manager[^""]*\.js)""")]
    private static partial Regex FingerprintedCircuitJsPattern();

    private static async Task<string[]> DiscoverFingerprintedAssetsAsync(HttpClient Client, string BaseUrl)
    {
        var (Response, Html) = await GetFollowingMetaRefreshAsync(Client, BaseUrl);
        if (!Response.IsSuccessStatusCode)
        {
            return [];
        }
        var Assets = new List<string>();
        var CssMatch = FingerprintedCssPattern().Match(Html);
        if (CssMatch.Success)
        {
            Assets.Add(CssMatch.Groups[1].Value.TrimStart('/'));
        }
        var BlazorMatch = FingerprintedBlazorJsPattern().Match(Html);
        if (BlazorMatch.Success)
        {
            Assets.Add(BlazorMatch.Groups[1].Value.TrimStart('/'));
        }
        var CircuitMatch = FingerprintedCircuitJsPattern().Match(Html);
        if (CircuitMatch.Success)
        {
            Assets.Add(CircuitMatch.Groups[1].Value.TrimStart('/'));
        }
        return [.. Assets];
    }

    [TestMethod]
    [DisplayName("PrTask.com: index loads with no browser errors (CDP)")]
    public async Task PrtaskComIndexNoErrorsCdpAsync()
    {
        var Errors = new List<string>();
        CdpConsole.OnRuntimeConsoleApiCalled(CdpHelpers.GetTransport(BrowserPage), Call =>
        {
            if (Call.Type == "error" && !IsIgnoredGhPagesError(string.Join(" ", Call.Args)))
            {
                Errors.Add(string.Join(" ", Call.Args));
            }
        });
        CdpConsole.OnRuntimeExceptionThrown(CdpHelpers.GetTransport(BrowserPage), Ex =>
        {
            if (!IsIgnoredGhPagesError(Ex.Text))
            {
                Errors.Add(Ex.Text);
            }
        });

        await BrowserPage.NavigateAsync(PrtaskComBaseUrl);

        try
        {
            await Task.Delay(500);
        }
        catch (TimeoutException) { }

        await Task.Delay(1000);

        Assert.AreEqual(0, Errors.Count,
            $"prtask.com must have zero console errors, got {Errors.Count}:\n{string.Join("\n", Errors)}");

        await TakeScreenshotAsync("prtask-com-index-no-errors.png");
    }

    [TestMethod]
    [DisplayName("PrTask.com: all static assets return 200")]
    public async Task PrtaskComAssetsReturn200Async()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(30) };

        var Failures = new List<string>();
        var FingerprintedAssets = await DiscoverFingerprintedAssetsAsync(Client, PrtaskComBaseUrl);
        var AllAssets = (string[])[.. PrtaskComAssets, .. FingerprintedAssets];
        foreach (var Asset in AllAssets)
        {
            var Url = $"{PrtaskComBaseUrl}{Asset}";
            var Response = await Client.GetAsync(Url);
            if (!Response.IsSuccessStatusCode)
            {
                Failures.Add($"{Asset} => {(int)Response.StatusCode}");
            }
        }

        Assert.AreEqual(0, Failures.Count,
            $"All prtask.com assets must return 200, failures:\n{string.Join("\n", Failures)}");
    }

    [TestMethod]
    [DisplayName("PrTask.com: Worker rewrites base href to /")]
    public async Task PrtaskComBaseHrefRewrittenAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(15) };

        var (Response, Html) = await GetFollowingMetaRefreshAsync(Client, PrtaskComBaseUrl);
        Assert.IsTrue(Response.IsSuccessStatusCode, $"prtask.com must return 2xx, got {(int)Response.StatusCode}");

        Assert.IsTrue(Html.Contains("base href=\"/\""),
            "prtask.com Worker must rewrite base href to /");
        Assert.IsFalse(Html.Contains("base href=\"/prtask.com/\""),
            "prtask.com must NOT have base href /prtask.com/");
    }

    [TestMethod]
    [DisplayName("PrTask.com: prerendered HTML has static nav and footer")]
    public async Task PrtaskComStaticNavFooterAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(15) };

        var Pages = new[] { "index.html", "About.html", "Tasks.html", "Settings.html" };
        var Failures = new List<string>();

        foreach (var PageName in Pages)
        {
            var (Response, Html) = await GetFollowingMetaRefreshAsync(Client, $"https://cruzlauroiii.github.io/prtask.com/{PageName}");
            if (!Response.IsSuccessStatusCode)
            {
                Failures.Add($"{PageName} => {(int)Response.StatusCode}");
                continue;
            }
            if (!Html.Contains("nav-menu"))
            {
                Failures.Add($"{PageName} missing static nav");
            }
            if (!Html.Contains("site-footer"))
            {
                Failures.Add($"{PageName} missing static footer");
            }
        }

        Assert.AreEqual(0, Failures.Count,
            $"All pages must have static nav/footer:\n{string.Join("\n", Failures)}");
    }

    [TestMethod]
    [DisplayName("PrTask.com: task detail page returns 200")]
    public async Task PrtaskComTaskDetailReturns200Async()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(30) };

        var (Response, Html) = await GetFollowingMetaRefreshAsync(Client, "https://prtask.com/en/Tasks/710d2607-c76f-4734-8f49-be2d36fa3b9c");
        Assert.IsTrue(Response.IsSuccessStatusCode,
            $"Task detail must return 2xx, got {(int)Response.StatusCode}");

        Assert.IsTrue(Html.Contains("nav-menu"), "Task detail must have static nav");
        Assert.IsTrue(Html.Contains("site-footer"), "Task detail must have static footer");
    }

    [TestMethod]
    [DisplayName("PrTask.com: Settings has no cryptocurrency")]
    public async Task PrtaskComSettingsNoCryptocurrencyAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(15) };

        var (Response, Html) = await GetFollowingMetaRefreshAsync(Client, "https://prtask.com/en/Settings.html");
        Assert.IsTrue(Response.IsSuccessStatusCode, "Settings.html must return 2xx");

        Assert.IsFalse(Html.Contains("value=\"crypto\"", StringComparison.OrdinalIgnoreCase),
            "Settings must NOT have crypto payout option");
        Assert.IsFalse(Html.Contains("Cryptocurrency", StringComparison.Ordinal),
            "Settings must NOT contain Cryptocurrency");
        Assert.IsFalse(Html.Contains("wallet address", StringComparison.OrdinalIgnoreCase),
            "Settings must NOT reference wallet address");
    }

    [TestMethod]
    [DisplayName("PrTask.com: Settings has payment method and QR selects")]
    public async Task PrtaskComSettingsHasPaymentSelectsAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(15) };

        var (_, Html) = await GetFollowingMetaRefreshAsync(Client, "https://prtask.com/en/Settings.html");

        Assert.IsTrue(Html.Contains("id=\"PayoutMethod\""), "Settings must have PayoutMethod select");
        Assert.IsTrue(Html.Contains("id=\"PaymentMethod\""), "Settings must have PaymentMethod select");
        Assert.IsTrue(Html.Contains("id=\"QrPaymentSetting\""), "Settings must have QR Payment select");
        Assert.IsTrue(Html.Contains("Bank Transfer"), "Settings must have Bank Transfer option");
        Assert.IsTrue(Html.Contains("Credit or Debit Card") || Html.Contains("Credit and Debit Card"),
            "Settings must have card payment option");
    }
}
