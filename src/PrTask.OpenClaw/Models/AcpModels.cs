using System.Text.Json.Serialization;

namespace PrTask.OpenClaw.Models;

#pragma warning disable SA1600

/// <summary>
/// Agent Client Protocol (ACP) models for agent-to-agent communication.
/// Maps to openclaw's ACP server/client/session/translator/policy.
/// </summary>
public sealed class AcpTask
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public string AgentId { get; set; } = string.Empty;
    public AcpTaskStatus Status { get; set; } = AcpTaskStatus.Pending;
    public AcpTaskInput Input { get; set; } = new();
    public AcpTaskOutput? Output { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? CompletedAt { get; set; }
    public string? ParentTaskId { get; set; }
    public Dictionary<string, string> Metadata { get; set; } = new(StringComparer.OrdinalIgnoreCase);
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AcpTaskStatus
{
    Pending,
    InProgress,
    Completed,
    Failed,
    Cancelled,
}

public sealed class AcpTaskInput
{
    public string Text { get; set; } = string.Empty;
    public List<GatewayAttachment> Attachments { get; set; } = [];
    public string? SessionKey { get; set; }
}

public sealed class AcpTaskOutput
{
    public string Text { get; set; } = string.Empty;
    public List<GatewayAttachment> Attachments { get; set; } = [];
    public string? Error { get; set; }
}

/// <summary>
/// ACP agent card describing an agent's capabilities.
/// </summary>
public sealed class AcpAgentCard
{
    public string AgentId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? Version { get; set; }
    public List<string> Capabilities { get; set; } = [];
    public List<string> SupportedInputTypes { get; set; } = ["text"];
    public List<string> SupportedOutputTypes { get; set; } = ["text"];
}

/// <summary>
/// ACP policy controlling agent access and model overrides.
/// Maps to openclaw's policy.ts.
/// </summary>
public sealed class AcpPolicy
{
    public bool AllowModelOverride { get; set; }
    public bool AllowAnyModel { get; set; }
    public HashSet<string> AllowedModels { get; set; } = new(StringComparer.OrdinalIgnoreCase);
    public int MaxConcurrentTasks { get; set; } = 10;
    public int MaxTaskTimeoutSeconds { get; set; } = 300;
    public AcpProvenanceMode ProvenanceMode { get; set; } = AcpProvenanceMode.None;
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AcpProvenanceMode
{
    None,
    Prefix,
    Metadata,
}

#pragma warning restore SA1600
