using System.Text.Json.Nodes;

namespace PrTask.Cdp;

#pragma warning disable SA1600
public static class CdpDom
{
    public static async Task<JsonNode> GetDocumentAsync(CdpClient Client, string SessionId, int Depth = -1, CancellationToken Cancel = default)
    {
        return await Client.SendToTargetAsync(SessionId, "DOM.getDocument", new JsonObject
        {
            ["depth"] = Depth,
        }, Cancel).ConfigureAwait(false);
    }

    public static async Task<int> QuerySelectorAsync(CdpClient Client, string SessionId, int NodeId, string Selector, CancellationToken Cancel = default)
    {
        var Result = await Client.SendToTargetAsync(SessionId, "DOM.querySelector", new JsonObject
        {
            ["nodeId"] = NodeId,
            ["selector"] = Selector,
        }, Cancel).ConfigureAwait(false);

        return Result["nodeId"]?.GetValue<int>() ?? 0;
    }

    public static async Task<int[]> QuerySelectorAllAsync(CdpClient Client, string SessionId, int NodeId, string Selector, CancellationToken Cancel = default)
    {
        var Result = await Client.SendToTargetAsync(SessionId, "DOM.querySelectorAll", new JsonObject
        {
            ["nodeId"] = NodeId,
            ["selector"] = Selector,
        }, Cancel).ConfigureAwait(false);

        var Arr = Result["nodeIds"]?.AsArray();
        if (Arr is null)
        {
            return [];
        }

        var Ids = new int[Arr.Count];
        for (var I = 0; I < Arr.Count; I++)
        {
            Ids[I] = Arr[I]?.GetValue<int>() ?? 0;
        }

        return Ids;
    }

    public static async Task<string> GetOuterHtmlAsync(CdpClient Client, string SessionId, int NodeId, CancellationToken Cancel = default)
    {
        var Result = await Client.SendToTargetAsync(SessionId, "DOM.getOuterHTML", new JsonObject
        {
            ["nodeId"] = NodeId,
        }, Cancel).ConfigureAwait(false);

        return Result["outerHTML"]?.GetValue<string>() ?? string.Empty;
    }

    public static async Task<JsonNode> GetBoxModelAsync(CdpClient Client, string SessionId, int NodeId, CancellationToken Cancel = default)
    {
        return await Client.SendToTargetAsync(SessionId, "DOM.getBoxModel", new JsonObject
        {
            ["nodeId"] = NodeId,
        }, Cancel).ConfigureAwait(false);
    }

    public static async Task<JsonNode> GetAttributesAsync(CdpClient Client, string SessionId, int NodeId, CancellationToken Cancel = default)
    {
        return await Client.SendToTargetAsync(SessionId, "DOM.getAttributes", new JsonObject
        {
            ["nodeId"] = NodeId,
        }, Cancel).ConfigureAwait(false);
    }

    public static async Task SetAttributeValueAsync(CdpClient Client, string SessionId, int NodeId, string Name, string Value, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "DOM.setAttributeValue", new JsonObject
        {
            ["nodeId"] = NodeId,
            ["name"] = Name,
            ["value"] = Value,
        }, Cancel).ConfigureAwait(false);
    }

    public static async Task RemoveNodeAsync(CdpClient Client, string SessionId, int NodeId, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "DOM.removeNode", new JsonObject
        {
            ["nodeId"] = NodeId,
        }, Cancel).ConfigureAwait(false);
    }

    public static async Task<int> GetNodeForLocationAsync(CdpClient Client, string SessionId, int X, int Y, CancellationToken Cancel = default)
    {
        var Result = await Client.SendToTargetAsync(SessionId, "DOM.getNodeForLocation", new JsonObject
        {
            ["x"] = X,
            ["y"] = Y,
        }, Cancel).ConfigureAwait(false);

        return Result["nodeId"]?.GetValue<int>() ?? 0;
    }
}
#pragma warning restore SA1600
