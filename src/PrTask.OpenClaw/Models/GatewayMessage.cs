using System.Text.Json.Serialization;

namespace PrTask.OpenClaw.Models;

#pragma warning disable SA1600

/// <summary>
/// Represents a message flowing through the gateway between channels and agents.
/// Maps to openclaw's gateway WS protocol messages.
/// </summary>
public sealed class GatewayMessage
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public string SessionKey { get; set; } = string.Empty;
    public string ChannelId { get; set; } = string.Empty;
    public string AccountId { get; set; } = "default";
    public string AgentId { get; set; } = "main";
    public GatewayMessageType Type { get; set; } = GatewayMessageType.Text;
    public string Text { get; set; } = string.Empty;
    public string? ReplyToId { get; set; }
    public string? ThreadId { get; set; }
    public string? SenderId { get; set; }
    public string? SenderName { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    public Dictionary<string, string> Metadata { get; set; } = new(StringComparer.OrdinalIgnoreCase);
    public List<GatewayAttachment> Attachments { get; set; } = [];
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum GatewayMessageType
{
    Text,
    Image,
    Audio,
    Video,
    File,
    Location,
    Sticker,
    Reaction,
    System,
}

public sealed class GatewayAttachment
{
    public string FileName { get; set; } = string.Empty;
    public string MimeType { get; set; } = string.Empty;
    public long SizeBytes { get; set; }
    public string? Url { get; set; }
    public byte[]? Data { get; set; }
}

/// <summary>
/// Gateway response from agent processing.
/// </summary>
public sealed class GatewayResponse
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public string RequestId { get; set; } = string.Empty;
    public string SessionKey { get; set; } = string.Empty;
    public string AgentId { get; set; } = "main";
    public string Text { get; set; } = string.Empty;
    public bool IsStreaming { get; set; }
    public bool IsComplete { get; set; } = true;
    public string? StopReason { get; set; }
    public GatewayUsage? Usage { get; set; }
    public List<GatewayToolCall> ToolCalls { get; set; } = [];
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}

public sealed class GatewayUsage
{
    public int InputTokens { get; set; }
    public int OutputTokens { get; set; }
    public int TotalTokens { get; set; }
}

public sealed class GatewayToolCall
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Arguments { get; set; } = string.Empty;
    public string? Result { get; set; }
}

/// <summary>
/// Session state for a conversation between a user and an agent.
/// Maps to openclaw's session store.
/// </summary>
public sealed class GatewaySession
{
    public string SessionKey { get; set; } = string.Empty;
    public string AgentId { get; set; } = "main";
    public string ChannelId { get; set; } = string.Empty;
    public string AccountId { get; set; } = "default";
    public List<GatewayMessage> History { get; set; } = [];
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime LastActivityAt { get; set; } = DateTime.UtcNow;
    public Dictionary<string, string> State { get; set; } = new(StringComparer.OrdinalIgnoreCase);
}

#pragma warning restore SA1600
