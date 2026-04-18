namespace PrTask.E2E;

public partial class RulesTests
{
    [TestMethod]
    [DisplayName("PrTask.com PageLoad: all JS and CSS assets loaded are fingerprinted")]
    public async Task PrtaskComAllAssetsAreFingerprintedAsync()
    {
        var Page = await BrowserContext.NewPageAsync();
        try
        {
            var NonFingerprintedAssets = new List<string>();
            var Allowed = new[]
            {
                "service-worker", "appsettings.json", "manifest.json",
                "blazor.boot.json", "dotnet.js"
            };
            Page.Request += (_, Request) =>
            {
                var RequestUrl = Request.Url;
                if (!RequestUrl.StartsWith("https://prtask.com/", StringComparison.OrdinalIgnoreCase))
                {
                    return;
                }
                var RequestPath = new Uri(RequestUrl).AbsolutePath;
                if (!RequestPath.EndsWith(".js", StringComparison.OrdinalIgnoreCase)
                    && !RequestPath.EndsWith(".css", StringComparison.OrdinalIgnoreCase))
                {
                    return;
                }
                if (Allowed.Any(A => RequestPath.Contains(A, StringComparison.OrdinalIgnoreCase)))
                {
                    return;
                }
                var FileName = RequestPath.Split('/')[^1];
                var Parts = FileName.Split('.');
                var HasFingerprint = Parts.Length >= 3 &&
                    Parts.Any(P => P.Length >= 6
                        && FingerprintHashSegmentPattern().IsMatch(P)
                        && P != Parts[0]
                        && P != Parts[^1]);
                if (!HasFingerprint)
                {
                    NonFingerprintedAssets.Add(RequestPath);
                }
            };
            await Page.GotoAsync(PrtaskComUrl, new Microsoft.Playwright.PageGotoOptions
            {
                Timeout = 20000, WaitUntil = Microsoft.Playwright.WaitUntilState.DOMContentLoaded
            });
            try
            {
                await Page.WaitForLoadStateAsync(Microsoft.Playwright.LoadState.NetworkIdle,
                    new Microsoft.Playwright.PageWaitForLoadStateOptions { Timeout = 15000 });
            }
            catch (TimeoutException) { }
            Assert.AreEqual(0, NonFingerprintedAssets.Count,
                $"All JS/CSS assets must be fingerprinted:\n{string.Join("\n", NonFingerprintedAssets)}");
        }
        finally
        {
            await Page.CloseAsync();
        }
    }

    [TestMethod]
    [DisplayName("PrTask.com PageLoad: no cancelled WASM fetch requests")]
    public async Task PrtaskComNoCancelledWasmFetchesAsync()
    {
        var Page = await BrowserContext.NewPageAsync();
        try
        {
            var FailedWasmRequests = new List<string>();
            Page.RequestFailed += (_, Request) =>
            {
                if (Request.Url.EndsWith(".wasm", StringComparison.OrdinalIgnoreCase))
                {
                    FailedWasmRequests.Add($"{Request.Url} — {Request.Failure}");
                }
            };
            await Page.GotoAsync(PrtaskComUrl, new Microsoft.Playwright.PageGotoOptions
            {
                Timeout = 20000, WaitUntil = Microsoft.Playwright.WaitUntilState.DOMContentLoaded
            });
            try
            {
                await Page.WaitForLoadStateAsync(Microsoft.Playwright.LoadState.NetworkIdle,
                    new Microsoft.Playwright.PageWaitForLoadStateOptions { Timeout = 20000 });
            }
            catch (TimeoutException) { }
            await Task.Delay(3000);
            Assert.AreEqual(0, FailedWasmRequests.Count,
                $"No .wasm fetch requests should be cancelled/failed:\n{string.Join("\n", FailedWasmRequests)}");
        }
        finally
        {
            await Page.CloseAsync();
        }
    }

    [TestMethod]
    [DisplayName("PrTask.com PageLoad: no Cloudflare beacon/insights script loaded")]
    public async Task PrtaskComNoCloudflareBeaconAsync()
    {
        var Page = await BrowserContext.NewPageAsync();
        try
        {
            var BeaconRequests = new List<string>();
            Page.Request += (_, Request) =>
            {
                if (Request.Url.Contains("cloudflareinsights.com", StringComparison.OrdinalIgnoreCase)
                    || Request.Url.Contains("beacon.min.js", StringComparison.OrdinalIgnoreCase))
                {
                    BeaconRequests.Add(Request.Url);
                }
            };
            await Page.GotoAsync(PrtaskComUrl, new Microsoft.Playwright.PageGotoOptions
            {
                Timeout = 20000, WaitUntil = Microsoft.Playwright.WaitUntilState.DOMContentLoaded
            });
            try
            {
                await Page.WaitForLoadStateAsync(Microsoft.Playwright.LoadState.NetworkIdle,
                    new Microsoft.Playwright.PageWaitForLoadStateOptions { Timeout = 15000 });
            }
            catch (TimeoutException) { }
            Assert.AreEqual(0, BeaconRequests.Count,
                $"Cloudflare beacon/insights script must NOT be loaded:\n{string.Join("\n", BeaconRequests)}");
        }
        finally
        {
            await Page.CloseAsync();
        }
    }

    [TestMethod]
    [DisplayName("PrTask.com PageLoad: circuit-manager.js is served without 404")]
    public async Task PrtaskComCircuitManagerNo404Async()
    {
        var Page = await BrowserContext.NewPageAsync();
        try
        {
            var WrongPathRequests = new List<string>();
            Page.Response += (_, Response) =>
            {
                if (Response.Url.Contains("circuit-manager", StringComparison.OrdinalIgnoreCase)
                    && Response.Status == 404)
                {
                    WrongPathRequests.Add($"{Response.Url} => {Response.Status}");
                }
            };
            await Page.GotoAsync(PrtaskComUrl, new Microsoft.Playwright.PageGotoOptions
            {
                Timeout = 20000, WaitUntil = Microsoft.Playwright.WaitUntilState.DOMContentLoaded
            });
            try
            {
                await Page.WaitForLoadStateAsync(Microsoft.Playwright.LoadState.NetworkIdle,
                    new Microsoft.Playwright.PageWaitForLoadStateOptions { Timeout = 15000 });
            }
            catch (TimeoutException) { }
            Assert.AreEqual(0, WrongPathRequests.Count,
                $"circuit-manager.js must not return 404:\n{string.Join("\n", WrongPathRequests)}");
        }
        finally
        {
            await Page.CloseAsync();
        }
    }

    [TestMethod]
    [DisplayName("PrTask.com PageLoad: no 4xx or 5xx responses on initial load")]
    public async Task PrtaskComNoErrorResponsesAsync()
    {
        var Page = await BrowserContext.NewPageAsync();
        try
        {
            var ErrorResponses = new List<string>();
            var IgnoredPaths = new[] { "favicon.ico", "manifest.json", "cdn-cgi" };
            Page.Response += (_, Response) =>
            {
                if (Response.Status >= 400
                    && !IgnoredPaths.Any(P => Response.Url.Contains(P, StringComparison.OrdinalIgnoreCase)))
                {
                    ErrorResponses.Add($"{Response.Status} {Response.Url}");
                }
            };
            await Page.GotoAsync(PrtaskComUrl, new Microsoft.Playwright.PageGotoOptions
            {
                Timeout = 20000, WaitUntil = Microsoft.Playwright.WaitUntilState.DOMContentLoaded
            });
            try
            {
                await Page.WaitForLoadStateAsync(Microsoft.Playwright.LoadState.NetworkIdle,
                    new Microsoft.Playwright.PageWaitForLoadStateOptions { Timeout = 15000 });
            }
            catch (TimeoutException) { }
            await Task.Delay(2000);
            Assert.AreEqual(0, ErrorResponses.Count,
                $"Initial load must have zero 4xx/5xx responses:\n{string.Join("\n", ErrorResponses)}");
        }
        finally
        {
            await Page.CloseAsync();
        }
    }
}
