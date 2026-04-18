using System.Text.Json.Nodes;

namespace PrTask.Cdp;

#pragma warning disable SA1600
public static class CdpNetwork
{
    public static async Task EnableAsync(CdpClient Client, string SessionId, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Network.enable", null, Cancel).ConfigureAwait(false);
    }

    public static async Task DisableAsync(CdpClient Client, string SessionId, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Network.disable", null, Cancel).ConfigureAwait(false);
    }

    public static async Task SetExtraHttpHeadersAsync(CdpClient Client, string SessionId, Dictionary<string, string> Headers, CancellationToken Cancel = default)
    {
        var HeadersObj = new JsonObject();
        foreach (var Kvp in Headers)
        {
            HeadersObj[Kvp.Key] = Kvp.Value;
        }

        await Client.SendToTargetAsync(SessionId, "Network.setExtraHTTPHeaders", new JsonObject
        {
            ["headers"] = HeadersObj,
        }, Cancel).ConfigureAwait(false);
    }

    public static async Task<(string Body, bool Base64Encoded)> GetResponseBodyAsync(CdpClient Client, string SessionId, string RequestId, CancellationToken Cancel = default)
    {
        var Result = await Client.SendToTargetAsync(SessionId, "Network.getResponseBody", new JsonObject
        {
            ["requestId"] = RequestId,
        }, Cancel).ConfigureAwait(false);

        var Body = Result["body"]?.GetValue<string>() ?? string.Empty;
        var IsBase64 = Result["base64Encoded"]?.GetValue<bool>() ?? false;
        return (Body, IsBase64);
    }

    public static async Task SetCacheDisabledAsync(CdpClient Client, string SessionId, bool CacheDisabled, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Network.setCacheDisabled", new JsonObject
        {
            ["cacheDisabled"] = CacheDisabled,
        }, Cancel).ConfigureAwait(false);
    }

    public static async Task ClearBrowserCacheAsync(CdpClient Client, string SessionId, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Network.clearBrowserCache", null, Cancel).ConfigureAwait(false);
    }

    public static async Task ClearBrowserCookiesAsync(CdpClient Client, string SessionId, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Network.clearBrowserCookies", null, Cancel).ConfigureAwait(false);
    }

    public static async Task SetUserAgentOverrideAsync(CdpClient Client, string SessionId, string UserAgent, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Network.setUserAgentOverride", new JsonObject
        {
            ["userAgent"] = UserAgent,
        }, Cancel).ConfigureAwait(false);
    }

    public static async Task EmulateNetworkConditionsAsync(CdpClient Client, string SessionId, bool Offline, double Latency, double DownloadThroughput, double UploadThroughput, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Network.emulateNetworkConditions", new JsonObject
        {
            ["offline"] = Offline,
            ["latency"] = Latency,
            ["downloadThroughput"] = DownloadThroughput,
            ["uploadThroughput"] = UploadThroughput,
        }, Cancel).ConfigureAwait(false);
    }

    public static async Task<JsonNode> GetCookiesAsync(CdpClient Client, string SessionId, string[]? Urls = null, CancellationToken Cancel = default)
    {
        var Params = new JsonObject();
        if (Urls is not null && Urls.Length > 0)
        {
            var UrlArray = new JsonArray();
            foreach (var Url in Urls)
            {
                UrlArray.Add(Url);
            }

            Params["urls"] = UrlArray;
        }

        return await Client.SendToTargetAsync(SessionId, "Network.getCookies", Params, Cancel).ConfigureAwait(false);
    }
}
#pragma warning restore SA1600
