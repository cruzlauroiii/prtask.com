using System.Globalization;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace PrTask.Cdp;

#pragma warning disable SA1600
public sealed class CdpBrowser : IAsyncDisposable
{
    private readonly CdpClient Client = new();
    private readonly HttpClient Http = new();
    private string BrowserWebSocketUrl = string.Empty;
    private string DebuggerUrl = string.Empty;

    public CdpClient Transport => Client;

    public async Task ConnectAsync(string DebuggerHost = "127.0.0.1", int DebuggerPort = 9222, CancellationToken Cancel = default)
    {
        DebuggerUrl = string.Format(CultureInfo.InvariantCulture, "http://{0}:{1}", DebuggerHost, DebuggerPort);

        var VersionUrl = string.Format(CultureInfo.InvariantCulture, "{0}/json/version", DebuggerUrl);
        var VersionJson = await Http.GetStringAsync(VersionUrl, Cancel).ConfigureAwait(false);
        var VersionDoc = JsonNode.Parse(VersionJson);
        BrowserWebSocketUrl = VersionDoc?["webSocketDebuggerUrl"]?.GetValue<string>()
            ?? throw new CdpConnectionException("No webSocketDebuggerUrl in /json/version response");

        await Client.ConnectAsync(BrowserWebSocketUrl, Cancel).ConfigureAwait(false);
    }

    public async Task<CdpTargetInfo[]> GetTargetsAsync(CancellationToken Cancel = default)
    {
        var ListUrl = string.Format(CultureInfo.InvariantCulture, "{0}/json/list", DebuggerUrl);
        var Json = await Http.GetStringAsync(ListUrl, Cancel).ConfigureAwait(false);
        var Array = JsonNode.Parse(Json)?.AsArray();
        if (Array is null)
        {
            return [];
        }

        var Targets = new List<CdpTargetInfo>();
        foreach (var Item in Array)
        {
            if (Item is null)
            {
                continue;
            }

            Targets.Add(new CdpTargetInfo
            {
                Id = Item["id"]?.GetValue<string>() ?? string.Empty,
                Type = Item["type"]?.GetValue<string>() ?? string.Empty,
                Title = Item["title"]?.GetValue<string>() ?? string.Empty,
                Url = Item["url"]?.GetValue<string>() ?? string.Empty,
                WebSocketDebuggerUrl = Item["webSocketDebuggerUrl"]?.GetValue<string>() ?? string.Empty,
            });
        }

        return Targets.ToArray();
    }

    public async Task<CdpPage> NewPageAsync(string? Url = null, CancellationToken Cancel = default)
    {
        var CreateParams = new JsonObject
        {
            ["url"] = Url ?? "about:blank",
        };

        var CreateResult = await Client.SendAsync("Target.createTarget", CreateParams, Cancel).ConfigureAwait(false);
        var TargetId = CreateResult["targetId"]?.GetValue<string>()
            ?? throw new CdpException("No target id in Target.createTarget response");

        // Attach to the target using CDP Target.attachToTarget
        var AttachResult = await Client.SendAsync("Target.attachToTarget", new JsonObject
        {
            ["targetId"] = TargetId,
            ["flatten"] = true,
        }, Cancel).ConfigureAwait(false);

        var SessionId = AttachResult["sessionId"]?.GetValue<string>()
            ?? throw new CdpException("No sessionId in Target.attachToTarget response");

        return new CdpPage(Client, TargetId, SessionId);
    }

    public async Task<CdpPage> AttachToTargetAsync(string TargetId, CancellationToken Cancel = default)
    {
        var AttachResult = await Client.SendAsync("Target.attachToTarget", new JsonObject
        {
            ["targetId"] = TargetId,
            ["flatten"] = true,
        }, Cancel).ConfigureAwait(false);

        var SessionId = AttachResult["sessionId"]?.GetValue<string>()
            ?? throw new CdpException("No sessionId in Target.attachToTarget response");

        return new CdpPage(Client, TargetId, SessionId);
    }

    public async Task CloseTargetAsync(string TargetId, CancellationToken Cancel = default)
    {
        await Client.SendAsync("Target.closeTarget", new JsonObject
        {
            ["targetId"] = TargetId,
        }, Cancel).ConfigureAwait(false);
    }

    public async ValueTask DisposeAsync()
    {
        await Client.DisposeAsync().ConfigureAwait(false);
        Http.Dispose();
    }
}

public sealed class CdpTargetInfo
{
    public string Id { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string WebSocketDebuggerUrl { get; set; } = string.Empty;
}
#pragma warning restore SA1600
