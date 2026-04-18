namespace PrTask.OpenClaw.Models;

#pragma warning disable SA1600

/// <summary>
/// Plugin manifest describing a plugin's capabilities and metadata.
/// Maps to openclaw's OpenClawPluginDefinition and manifest.ts.
/// </summary>
public sealed class PluginManifest
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Version { get; set; } = "1.0.0";
    public string? Description { get; set; }
    public string? Author { get; set; }
    public string? License { get; set; }
    public PluginKind Kind { get; set; } = PluginKind.General;
    public List<string> Capabilities { get; set; } = [];
    public Dictionary<string, PluginSettingSchema> Settings { get; set; } = new(StringComparer.OrdinalIgnoreCase);
    public List<PluginHookBinding> Hooks { get; set; } = [];
    public List<PluginToolDefinition> Tools { get; set; } = [];
}

public enum PluginKind
{
    General,
    Channel,
    Provider,
    Memory,
    MediaProcessing,
    WebSearch,
    ImageGeneration,
    Tts,
}

public sealed class PluginSettingSchema
{
    public string Key { get; set; } = string.Empty;
    public string Type { get; set; } = "string";
    public string? Description { get; set; }
    public string? DefaultValue { get; set; }
    public bool Required { get; set; }
}

public sealed class PluginHookBinding
{
    public string HookName { get; set; } = string.Empty;
    public string MethodName { get; set; } = string.Empty;
    public int Priority { get; set; }
}

public sealed class PluginToolDefinition
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public Dictionary<string, ToolParameterSchema> Parameters { get; set; } = new(StringComparer.OrdinalIgnoreCase);
}

public sealed class ToolParameterSchema
{
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = "string";
    public string? Description { get; set; }
    public bool Required { get; set; }
}

#pragma warning restore SA1600
