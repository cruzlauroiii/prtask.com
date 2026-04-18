using PrTask.OpenClaw.Models;

namespace PrTask.OpenClaw.Channels;

#pragma warning disable SA1600

/// <summary>
/// Interface for channel plugins.
/// Maps to openclaw's ChannelPlugin type from channels/plugins/types.ts.
/// Each channel implementation handles bidirectional messaging with an external platform.
/// </summary>
public interface IOpenClawChannel : IAsyncDisposable
{
    /// <summary>
    /// Unique channel identifier (e.g., "telegram", "discord", "webhook").
    /// </summary>
    string ChannelId { get; }

    /// <summary>
    /// Human-readable channel name.
    /// </summary>
    string DisplayName { get; }

    /// <summary>
    /// Whether the channel is currently connected and running.
    /// </summary>
    bool IsRunning { get; }

    /// <summary>
    /// Channel capabilities.
    /// Maps to openclaw's ChannelCapabilities type.
    /// </summary>
    ChannelCapabilities Capabilities { get; }

    /// <summary>
    /// Start the channel with the given configuration.
    /// Maps to openclaw's channel lifecycle adapter start.
    /// </summary>
    Task StartAsync(ChannelConfig Config, CancellationToken Cancel = default);

    /// <summary>
    /// Stop the channel gracefully.
    /// </summary>
    Task StopAsync(CancellationToken Cancel = default);

    /// <summary>
    /// Send a response message through this channel.
    /// Maps to openclaw's ChannelOutboundAdapter.
    /// </summary>
    Task SendAsync(GatewayResponse Response, CancellationToken Cancel = default);

    /// <summary>
    /// Event raised when a message is received from this channel.
    /// </summary>
    event Func<GatewayMessage, Task>? OnMessageReceived;
}

/// <summary>
/// Channel capabilities declaration.
/// Maps to openclaw's ChannelCapabilities type.
/// </summary>
public sealed class ChannelCapabilities
{
    public bool SupportsText { get; set; } = true;
    public bool SupportsImages { get; set; }
    public bool SupportsAudio { get; set; }
    public bool SupportsVideo { get; set; }
    public bool SupportsFiles { get; set; }
    public bool SupportsReactions { get; set; }
    public bool SupportsThreading { get; set; }
    public bool SupportsStreaming { get; set; }
    public bool SupportsEditing { get; set; }
    public bool SupportsDeletion { get; set; }
    public bool SupportsButtons { get; set; }
    public int MaxMessageLength { get; set; } = 4096;
}

#pragma warning restore SA1600
