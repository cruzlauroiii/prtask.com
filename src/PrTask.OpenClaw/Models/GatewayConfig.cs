namespace PrTask.OpenClaw.Models;

#pragma warning disable SA1600

/// <summary>
/// Core configuration model matching openclaw's OpenClawConfig.
/// Supports YAML/JSON config loading with channel, provider, plugin, agent, and hook settings.
/// </summary>
public sealed class GatewayConfig
{
    public string Name { get; set; } = "PrTask Gateway";
    public int Port { get; set; } = 3000;
    public string Host { get; set; } = "127.0.0.1";
    public GatewayAuthConfig Auth { get; set; } = new();
    public Dictionary<string, ChannelConfig> Channels { get; set; } = new(StringComparer.OrdinalIgnoreCase);
    public Dictionary<string, ProviderConfig> Providers { get; set; } = new(StringComparer.OrdinalIgnoreCase);
    public Dictionary<string, PluginConfig> Plugins { get; set; } = new(StringComparer.OrdinalIgnoreCase);
    public Dictionary<string, AgentConfig> Agents { get; set; } = new(StringComparer.OrdinalIgnoreCase);
    public List<HookConfig> Hooks { get; set; } = [];
    public SessionConfig Sessions { get; set; } = new();
    public CronConfig Cron { get; set; } = new();
}

public sealed class GatewayAuthConfig
{
    public string? Token { get; set; }
    public string? Password { get; set; }
    public bool AllowAnonymous { get; set; }
}

public sealed class ChannelConfig
{
    public bool Enabled { get; set; } = true;
    public string ChannelId { get; set; } = string.Empty;
    public Dictionary<string, string> Credentials { get; set; } = new(StringComparer.OrdinalIgnoreCase);
    public Dictionary<string, object?> Settings { get; set; } = new(StringComparer.OrdinalIgnoreCase);
    public Dictionary<string, ChannelAccountConfig> Accounts { get; set; } = new(StringComparer.OrdinalIgnoreCase);
}

public sealed class ChannelAccountConfig
{
    public bool Enabled { get; set; } = true;
    public string AccountId { get; set; } = string.Empty;
    public Dictionary<string, string> Credentials { get; set; } = new(StringComparer.OrdinalIgnoreCase);
}

public sealed class ProviderConfig
{
    public bool Enabled { get; set; } = true;
    public string ProviderId { get; set; } = string.Empty;
    public string? ApiKey { get; set; }
    public string? BaseUrl { get; set; }
    public string? DefaultModel { get; set; }
    public Dictionary<string, object?> Settings { get; set; } = new(StringComparer.OrdinalIgnoreCase);
}

public sealed class PluginConfig
{
    public bool Enabled { get; set; } = true;
    public string PluginId { get; set; } = string.Empty;
    public string? Path { get; set; }
    public Dictionary<string, object?> Settings { get; set; } = new(StringComparer.OrdinalIgnoreCase);
}

public sealed class AgentConfig
{
    public string AgentId { get; set; } = "main";
    public string? SystemPrompt { get; set; }
    public string? Model { get; set; }
    public string? Provider { get; set; }
    public int? MaxTokens { get; set; }
    public double? Temperature { get; set; }
    public List<string> Tools { get; set; } = [];
    public HeartbeatConfig? Heartbeat { get; set; }
}

public sealed class HeartbeatConfig
{
    public bool Enabled { get; set; }
    public int IntervalSeconds { get; set; } = 300;
    public int AckMaxChars { get; set; } = 200;
}

public sealed class HookConfig
{
    public string Path { get; set; } = string.Empty;
    public string? Token { get; set; }
    public string? Channel { get; set; }
    public string? AgentId { get; set; }
    public string Method { get; set; } = "POST";
    public HookDeliveryMode Delivery { get; set; } = HookDeliveryMode.Agent;
}

public enum HookDeliveryMode
{
    Agent,
    Wake,
    Deliver,
}

public sealed class SessionConfig
{
    public string StorePath { get; set; } = string.Empty;
    public int MaxHistoryLength { get; set; } = 100;
    public int TimeoutMinutes { get; set; } = 30;
}

public sealed class CronConfig
{
    public bool Enabled { get; set; }
    public List<CronJobConfig> Jobs { get; set; } = [];
}

public sealed class CronJobConfig
{
    public string Name { get; set; } = string.Empty;
    public string Schedule { get; set; } = string.Empty;
    public string AgentId { get; set; } = "main";
    public string? Message { get; set; }
}

#pragma warning restore SA1600
