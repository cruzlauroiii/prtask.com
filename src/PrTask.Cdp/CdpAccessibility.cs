using System.Text.Json.Nodes;

namespace PrTask.Cdp;

#pragma warning disable SA1600
public static class CdpAccessibility
{
    public static async Task EnableAsync(CdpClient Client, string SessionId, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Accessibility.enable", null, Cancel).ConfigureAwait(false);
    }

    public static async Task DisableAsync(CdpClient Client, string SessionId, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Accessibility.disable", null, Cancel).ConfigureAwait(false);
    }

    public static async Task<AccessibilityNode[]> GetFullAxTreeAsync(CdpClient Client, string SessionId, CancellationToken Cancel = default)
    {
        var Result = await Client.SendToTargetAsync(SessionId, "Accessibility.getFullAXTree", null, Cancel).ConfigureAwait(false);
        var Nodes = Result["nodes"]?.AsArray();
        if (Nodes is null)
        {
            return [];
        }

        var TreeNodes = new List<AccessibilityNode>();
        foreach (var Node in Nodes)
        {
            if (Node is null)
            {
                continue;
            }

            TreeNodes.Add(ParseNode(Node));
        }

        return TreeNodes.ToArray();
    }

    public static async Task<AccessibilityNode?> GetPartialAxTreeAsync(CdpClient Client, string SessionId, int? NodeId = null, string? ObjectId = null, CancellationToken Cancel = default)
    {
        var Params = new JsonObject();
        if (NodeId.HasValue)
        {
            Params["nodeId"] = NodeId.Value;
        }

        if (ObjectId is not null)
        {
            Params["objectId"] = ObjectId;
        }

        Params["fetchRelatives"] = true;

        var Result = await Client.SendToTargetAsync(SessionId, "Accessibility.getPartialAXTree", Params, Cancel).ConfigureAwait(false);
        var Arr = Result["nodes"]?.AsArray();
        if (Arr is null || Arr.Count == 0)
        {
            return null;
        }

        return ParseNode(Arr[0]!);
    }

    private static string NodeToString(JsonNode? Node)
    {
        if (Node is null)
        {
            return string.Empty;
        }

        if (Node is JsonValue Val && Val.TryGetValue<string>(out var Str))
        {
            return Str;
        }

        return Node.ToString();
    }

    private static string? NodeToNullableString(JsonNode? Node)
    {
        if (Node is null)
        {
            return null;
        }

        if (Node is JsonValue Val && Val.TryGetValue<string>(out var Str))
        {
            return Str;
        }

        return Node.ToString();
    }

    private static AccessibilityNode ParseNode(JsonNode Node)
    {
        var Properties = new Dictionary<string, string>();
        var PropsArray = Node["properties"]?.AsArray();
        if (PropsArray is not null)
        {
            foreach (var Prop in PropsArray)
            {
                if (Prop is null)
                {
                    continue;
                }

                var Name = NodeToString(Prop["name"]);
                var Value = Prop["value"]?["value"]?.ToJsonString() ?? string.Empty;
                if (!string.IsNullOrEmpty(Name))
                {
                    Properties[Name] = Value;
                }
            }
        }

        var ChildIds = new List<string>();
        var ChildIdsArray = Node["childIds"]?.AsArray();
        if (ChildIdsArray is not null)
        {
            foreach (var ChildId in ChildIdsArray)
            {
                if (ChildId is not null)
                {
                    ChildIds.Add(NodeToString(ChildId));
                }
            }
        }

        return new AccessibilityNode
        {
            NodeId = NodeToString(Node["nodeId"]),
            Ignored = Node["ignored"]?.GetValue<bool>() ?? false,
            Role = NodeToString(Node["role"]?["value"]),
            Name = NodeToString(Node["name"]?["value"]),
            Description = NodeToString(Node["description"]?["value"]),
            Value = NodeToString(Node["value"]?["value"]),
            Properties = Properties,
            ChildIds = ChildIds.ToArray(),
            ParentId = NodeToNullableString(Node["parentId"]),
            BackendDomNodeId = Node["backendDOMNodeId"]?.GetValue<int>(),
        };
    }
}

public sealed class AccessibilityNode
{
    public string NodeId { get; set; } = string.Empty;
    public bool Ignored { get; set; }
    public string Role { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
    public Dictionary<string, string> Properties { get; set; } = new();
    public string[] ChildIds { get; set; } = [];
    public string? ParentId { get; set; }
    public int? BackendDomNodeId { get; set; }
}
#pragma warning restore SA1600
