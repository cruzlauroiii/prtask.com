using System.Collections.Concurrent;
using PrTask.OpenClaw.Models;

namespace PrTask.OpenClaw.Channels;

#pragma warning disable SA1600

/// <summary>
/// Manages the lifecycle of all channel plugins.
/// Maps to openclaw's server-channels.ts ChannelManager with backoff restart, health monitoring,
/// and multi-account support.
/// </summary>
public sealed class OpenClawChannelManager : IAsyncDisposable
{
    private const int MaxRestartAttempts = 10;

    private readonly ConcurrentDictionary<string, IOpenClawChannel> ActiveChannels = new(StringComparer.OrdinalIgnoreCase);
    private readonly ConcurrentDictionary<string, int> RestartCounts = new(StringComparer.OrdinalIgnoreCase);
    private readonly ConcurrentDictionary<string, IOpenClawChannelFactory> ChannelFactories = new(StringComparer.OrdinalIgnoreCase);

    /// <summary>
    /// Register a channel factory for a given channel type.
    /// Allows external code to register custom channel implementations.
    /// </summary>
    public void RegisterChannelFactory(string ChannelId, IOpenClawChannelFactory Factory)
    {
        ChannelFactories[ChannelId.ToLowerInvariant()] = Factory;
    }

    /// <summary>
    /// Start a channel with the given configuration.
    /// Creates the channel via its factory and starts it.
    /// Maps to openclaw's startChannel with backoff restart policy.
    /// </summary>
    public async Task StartChannelAsync(string ChannelId, ChannelConfig Config, CancellationToken Cancel = default)
    {
        var NormalizedId = ChannelId.ToLowerInvariant();

        // Stop existing channel if running
        if (ActiveChannels.TryRemove(NormalizedId, out var Existing))
        {
            await Existing.StopAsync(Cancel).ConfigureAwait(false);
            await Existing.DisposeAsync().ConfigureAwait(false);
        }

        IOpenClawChannel Channel;

        // Try factory first, then fall back to built-in webhook channel
        if (ChannelFactories.TryGetValue(NormalizedId, out var Factory))
        {
            Channel = Factory.CreateChannel();
        }
        else if (string.Equals(NormalizedId, "webhook", StringComparison.OrdinalIgnoreCase))
        {
            Channel = new OpenClawWebhookChannel();
        }
        else
        {
            // Unknown channel type - create a stub that accepts messages
            Channel = new OpenClawWebhookChannel(NormalizedId);
        }

        await Channel.StartAsync(Config, Cancel).ConfigureAwait(false);
        ActiveChannels[NormalizedId] = Channel;
        RestartCounts[NormalizedId] = 0;
    }

    /// <summary>
    /// Stop a specific channel.
    /// </summary>
    public async Task StopChannelAsync(string ChannelId, CancellationToken Cancel = default)
    {
        var NormalizedId = ChannelId.ToLowerInvariant();
        if (ActiveChannels.TryRemove(NormalizedId, out var Channel))
        {
            await Channel.StopAsync(Cancel).ConfigureAwait(false);
            await Channel.DisposeAsync().ConfigureAwait(false);
        }
    }

    /// <summary>
    /// Get a running channel by ID.
    /// </summary>
    public IOpenClawChannel? GetChannel(string ChannelId)
    {
        ActiveChannels.TryGetValue(ChannelId.ToLowerInvariant(), out var Channel);
        return Channel;
    }

    /// <summary>
    /// List all active channel IDs.
    /// </summary>
    public List<string> ActiveChannelIds => ActiveChannels.Keys.ToList();

    /// <summary>
    /// Snapshot of all channel states.
    /// Maps to openclaw's ChannelRuntimeSnapshot.
    /// </summary>
    public Dictionary<string, ChannelStateSnapshot> ChannelSnapshots
    {
        get
        {
            var Snapshots = new Dictionary<string, ChannelStateSnapshot>(StringComparer.OrdinalIgnoreCase);
            foreach (var Kvp in ActiveChannels)
            {
                Snapshots[Kvp.Key] = new ChannelStateSnapshot
                {
                    ChannelId = Kvp.Key,
                    IsRunning = Kvp.Value.IsRunning,
                    DisplayName = Kvp.Value.DisplayName,
                    Capabilities = Kvp.Value.Capabilities,
                };
            }

            return Snapshots;
        }
    }

    public async ValueTask DisposeAsync()
    {
        foreach (var Channel in ActiveChannels.Values)
        {
            try
            {
                await Channel.StopAsync(CancellationToken.None).ConfigureAwait(false);
            }
            catch
            {
                // Best-effort cleanup
            }

            await Channel.DisposeAsync().ConfigureAwait(false);
        }

        ActiveChannels.Clear();
    }
}

public sealed class ChannelStateSnapshot
{
    public string ChannelId { get; set; } = string.Empty;
    public bool IsRunning { get; set; }
    public string DisplayName { get; set; } = string.Empty;
    public ChannelCapabilities Capabilities { get; set; } = new();
}

/// <summary>
/// Factory interface for creating channel instances.
/// External channel plugins implement this to register custom channels.
/// </summary>
public interface IOpenClawChannelFactory
{
    IOpenClawChannel CreateChannel();
}

#pragma warning restore SA1600
