using System.Globalization;
using System.Text.Json.Nodes;

namespace PrTask.Cdp;

#pragma warning disable SA1600
public sealed class CdpPage : ICdpPage
{
    private readonly CdpClient Client;

    public string TargetId { get; }
    public string SessionId { get; }

    internal CdpPage(CdpClient Client, string TargetId, string SessionId)
    {
        this.Client = Client;
        this.TargetId = TargetId;
        this.SessionId = SessionId;
    }

    public async Task<string> NavigateAsync(string Url, CancellationToken Cancel = default)
    {
        var Result = await Client.SendToTargetAsync(SessionId, "Page.navigate", new JsonObject
        {
            ["url"] = Url,
        }, Cancel).ConfigureAwait(false);

        var FrameId = Result["frameId"]?.GetValue<string>() ?? string.Empty;
        var ErrorText = Result["errorText"]?.GetValue<string>();
        if (!string.IsNullOrEmpty(ErrorText))
        {
            throw new CdpException(string.Format(CultureInfo.InvariantCulture, "Navigation failed: {0}", ErrorText));
        }

        return FrameId;
    }

    public async Task WaitForLoadAsync(CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Page.enable", null, Cancel).ConfigureAwait(false);

        var LoadTcs = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);
        void OnLoadEvent(JsonNode _) => LoadTcs.TrySetResult();

        Client.On("Page.loadEventFired", OnLoadEvent);
        try
        {
            // Check if the page has already finished loading before the listener was attached.
            var ReadyState = await Client.SendToTargetAsync(SessionId, "Runtime.evaluate", new JsonObject
            {
                ["expression"] = "document.readyState",
                ["returnByValue"] = true,
            }, Cancel).ConfigureAwait(false);

            var State = ReadyState["result"]?["value"]?.GetValue<string>();
            if (State == "complete")
            {
                return;
            }

            using var TimeoutCts = CancellationTokenSource.CreateLinkedTokenSource(Cancel);
            TimeoutCts.CancelAfter(60000);
            await LoadTcs.Task.WaitAsync(TimeoutCts.Token).ConfigureAwait(false);
        }
        catch (OperationCanceledException) when (!Cancel.IsCancellationRequested)
        {
            throw new CdpTimeoutException("Timeout waiting for page load event");
        }
        finally
        {
            Client.Off("Page.loadEventFired", OnLoadEvent);
        }
    }

    public async Task<byte[]> CaptureScreenshotAsync(string Format = "png", int Quality = 80, CancellationToken Cancel = default)
    {
        var Params = new JsonObject
        {
            ["format"] = Format,
        };
        if (Format == "jpeg" || Format == "webp")
        {
            Params["quality"] = Quality;
        }

        var Result = await Client.SendToTargetAsync(SessionId, "Page.captureScreenshot", Params, Cancel).ConfigureAwait(false);
        var Data = Result["data"]?.GetValue<string>() ?? string.Empty;
        return Convert.FromBase64String(Data);
    }

    public async Task<string> GetOuterHtmlAsync(string Selector, CancellationToken Cancel = default)
    {
        var NodeId = await QuerySelectorAsync(Selector, Cancel).ConfigureAwait(false);
        if (NodeId == 0)
        {
            throw new CdpException(string.Format(CultureInfo.InvariantCulture, "Selector not found: {0}", Selector));
        }

        var Result = await Client.SendToTargetAsync(SessionId, "DOM.getOuterHTML", new JsonObject
        {
            ["nodeId"] = NodeId,
        }, Cancel).ConfigureAwait(false);

        return Result["outerHTML"]?.GetValue<string>() ?? string.Empty;
    }

    public async Task<int> QuerySelectorAsync(string Selector, CancellationToken Cancel = default)
    {
        var DocResult = await Client.SendToTargetAsync(SessionId, "DOM.getDocument", new JsonObject
        {
            ["depth"] = 0,
        }, Cancel).ConfigureAwait(false);

        var RootNodeId = DocResult["root"]?["nodeId"]?.GetValue<int>() ?? 0;

        var QueryResult = await Client.SendToTargetAsync(SessionId, "DOM.querySelector", new JsonObject
        {
            ["nodeId"] = RootNodeId,
            ["selector"] = Selector,
        }, Cancel).ConfigureAwait(false);

        return QueryResult["nodeId"]?.GetValue<int>() ?? 0;
    }

    public async Task<int[]> QuerySelectorAllAsync(string Selector, CancellationToken Cancel = default)
    {
        var DocResult = await Client.SendToTargetAsync(SessionId, "DOM.getDocument", new JsonObject
        {
            ["depth"] = 0,
        }, Cancel).ConfigureAwait(false);

        var RootNodeId = DocResult["root"]?["nodeId"]?.GetValue<int>() ?? 0;

        var QueryResult = await Client.SendToTargetAsync(SessionId, "DOM.querySelectorAll", new JsonObject
        {
            ["nodeId"] = RootNodeId,
            ["selector"] = Selector,
        }, Cancel).ConfigureAwait(false);

        var NodeIds = QueryResult["nodeIds"]?.AsArray();
        if (NodeIds is null)
        {
            return [];
        }

        var Ids = new int[NodeIds.Count];
        for (var I = 0; I < NodeIds.Count; I++)
        {
            Ids[I] = NodeIds[I]?.GetValue<int>() ?? 0;
        }

        return Ids;
    }

    public async Task<object?> EvaluateAsync(string Expression, CancellationToken Cancel = default)
    {
        var Result = await Client.SendToTargetAsync(SessionId, "Runtime.evaluate", new JsonObject
        {
            ["expression"] = Expression,
            ["returnByValue"] = true,
            ["awaitPromise"] = true,
        }, Cancel).ConfigureAwait(false);

        var ExceptionDetails = Result["exceptionDetails"];
        if (ExceptionDetails is not null)
        {
            var ExText = ExceptionDetails["text"]?.GetValue<string>() ?? "Script evaluation failed";
            throw new CdpException(string.Format(CultureInfo.InvariantCulture, "Evaluation error: {0}", ExText));
        }

        var RemoteObject = Result["result"];
        if (RemoteObject is null)
        {
            return null;
        }

        var Type = RemoteObject["type"]?.GetValue<string>();
        return Type switch
        {
            "undefined" => null,
            "string" => RemoteObject["value"]?.GetValue<string>(),
            "number" => RemoteObject["value"]?.GetValue<double>(),
            "boolean" => RemoteObject["value"]?.GetValue<bool>(),
            "object" => RemoteObject["value"]?.ToJsonString(),
            _ => RemoteObject["value"]?.ToJsonString(),
        };
    }

    public async Task ClickAsync(int X, int Y, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Input.dispatchMouseEvent", new JsonObject
        {
            ["type"] = "mousePressed",
            ["x"] = X,
            ["y"] = Y,
            ["button"] = "left",
            ["clickCount"] = 1,
        }, Cancel).ConfigureAwait(false);

        await Client.SendToTargetAsync(SessionId, "Input.dispatchMouseEvent", new JsonObject
        {
            ["type"] = "mouseReleased",
            ["x"] = X,
            ["y"] = Y,
            ["button"] = "left",
            ["clickCount"] = 1,
        }, Cancel).ConfigureAwait(false);
    }

    public async Task TypeTextAsync(string Text, CancellationToken Cancel = default)
    {
        foreach (var Ch in Text)
        {
            await Client.SendToTargetAsync(SessionId, "Input.dispatchKeyEvent", new JsonObject
            {
                ["type"] = "keyDown",
                ["text"] = Ch.ToString(CultureInfo.InvariantCulture),
                ["key"] = Ch.ToString(CultureInfo.InvariantCulture),
                ["unmodifiedText"] = Ch.ToString(CultureInfo.InvariantCulture),
            }, Cancel).ConfigureAwait(false);

            await Client.SendToTargetAsync(SessionId, "Input.dispatchKeyEvent", new JsonObject
            {
                ["type"] = "keyUp",
                ["key"] = Ch.ToString(CultureInfo.InvariantCulture),
            }, Cancel).ConfigureAwait(false);
        }
    }

    public async Task PressKeyAsync(string Key, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Input.dispatchKeyEvent", new JsonObject
        {
            ["type"] = "rawKeyDown",
            ["key"] = Key,
            ["windowsVirtualKeyCode"] = GetKeyCode(Key),
        }, Cancel).ConfigureAwait(false);

        await Client.SendToTargetAsync(SessionId, "Input.dispatchKeyEvent", new JsonObject
        {
            ["type"] = "keyUp",
            ["key"] = Key,
            ["windowsVirtualKeyCode"] = GetKeyCode(Key),
        }, Cancel).ConfigureAwait(false);
    }

    public async Task SetViewportAsync(int Width, int Height, double DeviceScaleFactor = 1.0, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Emulation.setDeviceMetricsOverride", new JsonObject
        {
            ["width"] = Width,
            ["height"] = Height,
            ["deviceScaleFactor"] = DeviceScaleFactor,
            ["mobile"] = false,
        }, Cancel).ConfigureAwait(false);
    }

    public async Task EnableNetworkAsync(CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Network.enable", null, Cancel).ConfigureAwait(false);
    }

    public async Task SetExtraHeadersAsync(Dictionary<string, string> Headers, CancellationToken Cancel = default)
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

    public async Task<string> GetResponseBodyAsync(string RequestId, CancellationToken Cancel = default)
    {
        var Result = await Client.SendToTargetAsync(SessionId, "Network.getResponseBody", new JsonObject
        {
            ["requestId"] = RequestId,
        }, Cancel).ConfigureAwait(false);

        var Body = Result["body"]?.GetValue<string>() ?? string.Empty;
        var Base64Encoded = Result["base64Encoded"]?.GetValue<bool>() ?? false;
        return Base64Encoded
            ? System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(Body))
            : Body;
    }

    public async Task EnableConsoleAsync(CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Console.enable", null, Cancel).ConfigureAwait(false);
        await Client.SendToTargetAsync(SessionId, "Runtime.enable", null, Cancel).ConfigureAwait(false);
    }

    private static int GetKeyCode(string Key) => Key switch
    {
        "Enter" => 13,
        "Tab" => 9,
        "Backspace" => 8,
        "Delete" => 46,
        "Escape" => 27,
        "ArrowUp" => 38,
        "ArrowDown" => 40,
        "ArrowLeft" => 37,
        "ArrowRight" => 39,
        "Home" => 36,
        "End" => 35,
        "PageUp" => 33,
        "PageDown" => 34,
        "Space" or " " => 32,
        "F1" => 112,
        "F2" => 113,
        "F3" => 114,
        "F4" => 115,
        "F5" => 116,
        "F12" => 123,
        _ => 0,
    };

    public async ValueTask DisposeAsync()
    {
        try
        {
            await Client.SendAsync("Target.detachFromTarget", new JsonObject
            {
                ["sessionId"] = SessionId,
            }).ConfigureAwait(false);
        }
        catch
        {
            // Best effort detach
        }
    }
}
#pragma warning restore SA1600
