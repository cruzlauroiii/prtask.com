using System.Collections.Concurrent;
using PrTask.OpenClaw.Channels;
using PrTask.OpenClaw.Models;
using PrTask.OpenClaw.Plugins;

namespace PrTask.OpenClaw.Gateway;

#pragma warning disable SA1600

/// <summary>
/// Central gateway service that routes messages between channels and AI providers.
/// In-process replacement for openclaw's Hono + WebSocket gateway server.
/// Manages channel lifecycle, session state, plugin execution, and hook dispatch.
/// </summary>
public sealed class OpenClawGatewayService : IAsyncDisposable
{
    private readonly ConcurrentDictionary<string, GatewaySession> Sessions = new(StringComparer.OrdinalIgnoreCase);
    private readonly OpenClawChannelManager ChannelManager = new();
    private readonly OpenClawPluginManager PluginManager = new();
    private readonly OpenClawHookService HookService;
    private readonly OpenClawSessionService SessionService;
    private readonly CancellationTokenSource DisposeCts = new();
    private GatewayConfig Config = new();
    private bool IsRunning;

    public OpenClawGatewayService()
    {
        SessionService = new OpenClawSessionService(Sessions);
        HookService = new OpenClawHookService(this);
    }

    public bool Running => IsRunning;
    public GatewayConfig CurrentConfig => Config;
    public OpenClawChannelManager Channels => ChannelManager;
    public OpenClawPluginManager Plugins => PluginManager;
    public OpenClawHookService Hooks => HookService;
    public OpenClawSessionService SessionManager => SessionService;

    /// <summary>
    /// Configure and start the gateway with the given config.
    /// Maps to openclaw's startGatewayServer() + boot.ts initialization.
    /// </summary>
    public async Task StartAsync(GatewayConfig GatewayConfig, CancellationToken Cancel = default)
    {
        Config = GatewayConfig ?? throw new ArgumentNullException(nameof(GatewayConfig));

        // Load plugins first (they can register channels, providers, hooks)
        await PluginManager.LoadPluginsAsync(Config.Plugins, Cancel).ConfigureAwait(false);

        // Initialize channels from config
        foreach (var ChannelEntry in Config.Channels)
        {
            if (!ChannelEntry.Value.Enabled)
            {
                continue;
            }

            await ChannelManager.StartChannelAsync(ChannelEntry.Key, ChannelEntry.Value, Cancel).ConfigureAwait(false);
        }

        // Register hooks
        foreach (var Hook in Config.Hooks)
        {
            HookService.RegisterHook(Hook);
        }

        IsRunning = true;
    }

    /// <summary>
    /// Dispatch an inbound message from a channel through the gateway pipeline.
    /// This is the core routing path: channel -> hooks -> agent -> response -> channel.
    /// Maps to openclaw's server-chat.ts dispatch flow.
    /// </summary>
    public async Task<GatewayResponse> DispatchMessageAsync(GatewayMessage Message, CancellationToken Cancel = default)
    {
        ArgumentNullException.ThrowIfNull(Message);

        // Resolve or create session
        var Session = SessionService.ResolveSession(Message);

        // Run pre-dispatch hooks
        var HookedMessage = await HookService.RunPreDispatchAsync(Message, Cancel).ConfigureAwait(false);
        if (HookedMessage is null)
        {
            // Hook suppressed the message
            return new GatewayResponse
            {
                RequestId = Message.Id,
                SessionKey = Message.SessionKey,
                Text = string.Empty,
                StopReason = "hook_suppressed",
                IsComplete = true,
            };
        }

        // Add message to session history
        Session.History.Add(HookedMessage);
        Session.LastActivityAt = DateTime.UtcNow;

        // Route to agent provider (this is where the AI provider would be called)
        // For now, return a placeholder - the actual provider dispatch is pluggable
        var Response = await DispatchToAgentAsync(HookedMessage, Session, Cancel).ConfigureAwait(false);

        // Run post-dispatch hooks
        return await HookService.RunPostDispatchAsync(HookedMessage, Response, Cancel).ConfigureAwait(false);
    }

    /// <summary>
    /// Dispatch a webhook HTTP request through the hook system.
    /// Maps to openclaw's server-http.ts hook handling.
    /// </summary>
    public async Task<GatewayResponse> DispatchHookAsync(string Path, string Body, Dictionary<string, string>? Headers = null, CancellationToken Cancel = default)
    {
        return await HookService.DispatchWebhookAsync(Path, Body, Headers, Cancel).ConfigureAwait(false);
    }

    /// <summary>
    /// Send a message outbound through a specific channel.
    /// Maps to openclaw's channel outbound adapter.
    /// </summary>
    public async Task SendToChannelAsync(string ChannelId, GatewayResponse Response, CancellationToken Cancel = default)
    {
        var Channel = ChannelManager.GetChannel(ChannelId);
        if (Channel is null)
        {
            throw new InvalidOperationException($"Channel '{ChannelId}' not found or not running");
        }

        await Channel.SendAsync(Response, Cancel).ConfigureAwait(false);
    }

    /// <summary>
    /// Get the current session for a given key.
    /// </summary>
    public GatewaySession? GetSession(string SessionKey)
    {
        return SessionService.GetSession(SessionKey);
    }

    /// <summary>
    /// Get a health/readiness snapshot.
    /// Maps to openclaw's probe.ts health check.
    /// </summary>
    public GatewayHealthSnapshot GetHealthSnapshot()
    {
        return new GatewayHealthSnapshot
        {
            IsRunning = IsRunning,
            ActiveSessions = Sessions.Count,
            ActiveChannels = ChannelManager.ActiveChannelIds.Count,
            LoadedPlugins = PluginManager.GetLoadedPluginIds().Count,
            RegisteredHooks = HookService.RegisteredHookCount,
        };
    }

    private async Task<GatewayResponse> DispatchToAgentAsync(GatewayMessage Message, GatewaySession Session, CancellationToken Cancel)
    {
        // Check if any plugin wants to handle this message
        var PluginResponse = await PluginManager.TryHandleMessageAsync(Message, Session, Cancel).ConfigureAwait(false);
        if (PluginResponse is not null)
        {
            return PluginResponse;
        }

        // Default: resolve agent config and dispatch
        var AgentId = Message.AgentId;
        if (Config.Agents.TryGetValue(AgentId, out var AgentCfg))
        {
            // Agent exists in config, the provider call would happen here
            // For in-process use, this returns a stub that callers can override
            return new GatewayResponse
            {
                RequestId = Message.Id,
                SessionKey = Session.SessionKey,
                AgentId = AgentId,
                Text = string.Empty,
                IsComplete = true,
                StopReason = "no_provider_configured",
            };
        }

        return new GatewayResponse
        {
            RequestId = Message.Id,
            SessionKey = Session.SessionKey,
            AgentId = AgentId,
            Text = string.Empty,
            IsComplete = true,
            StopReason = "agent_not_found",
        };
    }

    public async ValueTask DisposeAsync()
    {
        IsRunning = false;
        await DisposeCts.CancelAsync().ConfigureAwait(false);
        await ChannelManager.DisposeAsync().ConfigureAwait(false);
        await PluginManager.DisposeAsync().ConfigureAwait(false);
        DisposeCts.Dispose();
    }
}

/// <summary>
/// Health/readiness snapshot of the gateway.
/// </summary>
public sealed class GatewayHealthSnapshot
{
    public bool IsRunning { get; set; }
    public int ActiveSessions { get; set; }
    public int ActiveChannels { get; set; }
    public int LoadedPlugins { get; set; }
    public int RegisteredHooks { get; set; }
}

#pragma warning restore SA1600
