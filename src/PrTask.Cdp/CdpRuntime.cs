using System.Text.Json.Nodes;

namespace PrTask.Cdp;

#pragma warning disable SA1600
public static class CdpRuntime
{
    public static async Task EnableAsync(CdpClient Client, string SessionId, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Runtime.enable", null, Cancel).ConfigureAwait(false);
    }

    public static async Task DisableAsync(CdpClient Client, string SessionId, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Runtime.disable", null, Cancel).ConfigureAwait(false);
    }

    public static async Task<JsonNode> EvaluateAsync(CdpClient Client, string SessionId, string Expression, bool ReturnByValue = true, bool AwaitPromise = true, CancellationToken Cancel = default)
    {
        var Result = await Client.SendToTargetAsync(SessionId, "Runtime.evaluate", new JsonObject
        {
            ["expression"] = Expression,
            ["returnByValue"] = ReturnByValue,
            ["awaitPromise"] = AwaitPromise,
        }, Cancel).ConfigureAwait(false);

        var ExceptionDetails = Result["exceptionDetails"];
        if (ExceptionDetails is not null)
        {
            var Text = ExceptionDetails["text"]?.GetValue<string>() ?? "Script evaluation error";
            throw new CdpException(Text);
        }

        return Result["result"] ?? new JsonObject();
    }

    public static async Task<JsonNode> CallFunctionOnAsync(CdpClient Client, string SessionId, string FunctionDeclaration, string ObjectId, JsonNode[]? Arguments = null, bool ReturnByValue = true, CancellationToken Cancel = default)
    {
        var Params = new JsonObject
        {
            ["functionDeclaration"] = FunctionDeclaration,
            ["objectId"] = ObjectId,
            ["returnByValue"] = ReturnByValue,
        };

        if (Arguments is not null && Arguments.Length > 0)
        {
            var ArgsArray = new JsonArray();
            foreach (var Arg in Arguments)
            {
                ArgsArray.Add(Arg.DeepClone());
            }

            Params["arguments"] = ArgsArray;
        }

        var Result = await Client.SendToTargetAsync(SessionId, "Runtime.callFunctionOn", Params, Cancel).ConfigureAwait(false);

        var ExceptionDetails = Result["exceptionDetails"];
        if (ExceptionDetails is not null)
        {
            var Text = ExceptionDetails["text"]?.GetValue<string>() ?? "CallFunctionOn error";
            throw new CdpException(Text);
        }

        return Result["result"] ?? new JsonObject();
    }

    public static async Task<JsonNode> GetPropertiesAsync(CdpClient Client, string SessionId, string ObjectId, bool OwnProperties = true, CancellationToken Cancel = default)
    {
        return await Client.SendToTargetAsync(SessionId, "Runtime.getProperties", new JsonObject
        {
            ["objectId"] = ObjectId,
            ["ownProperties"] = OwnProperties,
        }, Cancel).ConfigureAwait(false);
    }

    public static async Task ReleaseObjectAsync(CdpClient Client, string SessionId, string ObjectId, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Runtime.releaseObject", new JsonObject
        {
            ["objectId"] = ObjectId,
        }, Cancel).ConfigureAwait(false);
    }

    public static async Task<string> GetHeapUsageAsync(CdpClient Client, string SessionId, CancellationToken Cancel = default)
    {
        var Result = await Client.SendToTargetAsync(SessionId, "Runtime.getHeapUsage", null, Cancel).ConfigureAwait(false);
        return Result.ToJsonString();
    }
}
#pragma warning restore SA1600
