using PrTask.OpenClaw.Models;

namespace PrTask.OpenClaw.Channels;

#pragma warning disable SA1600

/// <summary>
/// HTTP webhook channel implementation.
/// The simplest channel: receives messages via HTTP POST and sends responses back.
/// Maps to openclaw's web channel + hook delivery mechanism.
/// This is the minimum viable channel for PrTask's in-process gateway usage.
/// </summary>
public sealed class OpenClawWebhookChannel : IOpenClawChannel
{
    private readonly string Id;
    private bool Running;

    public OpenClawWebhookChannel(string ChannelId = "webhook")
    {
        Id = ChannelId;
    }

    public string ChannelId => Id;
    public string DisplayName => $"Webhook ({Id})";
    public bool IsRunning => Running;

    public ChannelCapabilities Capabilities { get; } = new()
    {
        SupportsText = true,
        SupportsImages = true,
        SupportsFiles = true,
        SupportsStreaming = false,
        SupportsThreading = false,
        SupportsEditing = false,
        SupportsDeletion = false,
        MaxMessageLength = 65536,
    };

    public event Func<GatewayMessage, Task>? OnMessageReceived;

    public Task StartAsync(ChannelConfig Config, CancellationToken Cancel = default)
    {
        Running = true;
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken Cancel = default)
    {
        Running = false;
        return Task.CompletedTask;
    }

    /// <summary>
    /// Inject a message into the channel as if received externally.
    /// Used for in-process testing and direct message dispatch.
    /// </summary>
    public async Task InjectMessageAsync(GatewayMessage Message)
    {
        ArgumentNullException.ThrowIfNull(Message);
        Message.ChannelId = Id;

        if (OnMessageReceived is not null)
        {
            await OnMessageReceived(Message).ConfigureAwait(false);
        }
    }

    /// <summary>
    /// Send a response. For webhook channels, this stores the response
    /// for the caller to pick up (since there's no persistent outbound connection).
    /// </summary>
    public Task SendAsync(GatewayResponse Response, CancellationToken Cancel = default)
    {
        // For webhook channels, sending is handled synchronously in the request/response cycle.
        // This is a no-op for fire-and-forget scenarios.
        LastResponse = Response;
        return Task.CompletedTask;
    }

    /// <summary>
    /// Last response sent through this channel.
    /// Useful for request/response webhook patterns.
    /// </summary>
    public GatewayResponse? LastResponse { get; private set; }

    public ValueTask DisposeAsync()
    {
        Running = false;
        return ValueTask.CompletedTask;
    }
}

#pragma warning restore SA1600
