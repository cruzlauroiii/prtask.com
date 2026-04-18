using System.Collections.Concurrent;
using PrTask.OpenClaw.Models;

namespace PrTask.OpenClaw.Plugins;

#pragma warning disable SA1600

/// <summary>
/// Manages plugin lifecycle: discovery, loading, initialization, and execution.
/// Maps to openclaw's plugins/loader.ts, plugins/registry.ts, and plugins/runtime/.
/// </summary>
public sealed class OpenClawPluginManager : IAsyncDisposable
{
    private readonly ConcurrentDictionary<string, PluginRegistration> LoadedPlugins = new(StringComparer.OrdinalIgnoreCase);
    private readonly ConcurrentDictionary<string, IOpenClawPluginFactory> PluginFactories = new(StringComparer.OrdinalIgnoreCase);

    /// <summary>
    /// Register a plugin factory for a given plugin ID.
    /// In-process equivalent of openclaw's plugin discovery.
    /// </summary>
    public void RegisterPluginFactory(string PluginId, IOpenClawPluginFactory Factory)
    {
        PluginFactories[PluginId.ToLowerInvariant()] = Factory;
    }

    /// <summary>
    /// Register an already-instantiated plugin.
    /// </summary>
    public void RegisterPlugin(IOpenClawPlugin Plugin)
    {
        ArgumentNullException.ThrowIfNull(Plugin);
        LoadedPlugins[Plugin.Manifest.Id.ToLowerInvariant()] = new PluginRegistration
        {
            Plugin = Plugin,
            IsInitialized = false,
        };
    }

    /// <summary>
    /// Load and initialize plugins from config.
    /// Maps to openclaw's loadOpenClawPlugins + plugin initialization.
    /// </summary>
    public async Task LoadPluginsAsync(Dictionary<string, PluginConfig> PluginConfigs, CancellationToken Cancel = default)
    {
        foreach (var PluginEntry in PluginConfigs)
        {
            if (!PluginEntry.Value.Enabled)
            {
                continue;
            }

            var PluginId = PluginEntry.Key.ToLowerInvariant();

            // If already registered (via RegisterPlugin), just initialize it
            if (LoadedPlugins.TryGetValue(PluginId, out var Existing) && !Existing.IsInitialized)
            {
                await InitializePluginAsync(Existing, PluginEntry.Value, Cancel).ConfigureAwait(false);
                continue;
            }

            // Try factory
            if (PluginFactories.TryGetValue(PluginId, out var Factory))
            {
                var Plugin = Factory.CreatePlugin();
                var Registration = new PluginRegistration { Plugin = Plugin, IsInitialized = false };
                LoadedPlugins[PluginId] = Registration;
                await InitializePluginAsync(Registration, PluginEntry.Value, Cancel).ConfigureAwait(false);
            }
        }
    }

    /// <summary>
    /// Try to handle a message with any loaded plugin.
    /// First plugin to return a non-null response wins.
    /// </summary>
    public async Task<GatewayResponse?> TryHandleMessageAsync(GatewayMessage Message, GatewaySession Session, CancellationToken Cancel = default)
    {
        foreach (var Registration in LoadedPlugins.Values)
        {
            if (!Registration.IsInitialized)
            {
                continue;
            }

            var Response = await Registration.Plugin.HandleMessageAsync(Message, Session, Cancel).ConfigureAwait(false);
            if (Response is not null)
            {
                return Response;
            }
        }

        return null;
    }

    /// <summary>
    /// Execute a tool call on the plugin that owns the tool.
    /// </summary>
    public async Task<string?> ExecuteToolAsync(string ToolName, Dictionary<string, string> Arguments, CancellationToken Cancel = default)
    {
        foreach (var Registration in LoadedPlugins.Values)
        {
            if (!Registration.IsInitialized)
            {
                continue;
            }

            if (Registration.Plugin.Manifest.Tools.Any(T => string.Equals(T.Name, ToolName, StringComparison.OrdinalIgnoreCase)))
            {
                return await Registration.Plugin.ExecuteToolAsync(ToolName, Arguments, Cancel).ConfigureAwait(false);
            }
        }

        return null;
    }

    /// <summary>
    /// Get a specific loaded plugin by ID.
    /// </summary>
    public IOpenClawPlugin? GetPlugin(string PluginId)
    {
        LoadedPlugins.TryGetValue(PluginId.ToLowerInvariant(), out var Registration);
        return Registration?.Plugin;
    }

    /// <summary>
    /// List all loaded plugin IDs.
    /// </summary>
    public List<string> GetLoadedPluginIds()
    {
        return LoadedPlugins.Keys.ToList();
    }

    /// <summary>
    /// Get all tool definitions from all loaded plugins.
    /// </summary>
    public List<PluginToolDefinition> GetAllTools()
    {
        return LoadedPlugins.Values
            .Where(R => R.IsInitialized)
            .SelectMany(R => R.Plugin.Manifest.Tools)
            .ToList();
    }

    private async Task InitializePluginAsync(PluginRegistration Registration, PluginConfig Config, CancellationToken Cancel)
    {
        var Context = new DefaultPluginContext();
        await Registration.Plugin.InitializeAsync(Config, Context, Cancel).ConfigureAwait(false);
        Registration.IsInitialized = true;
    }

    public async ValueTask DisposeAsync()
    {
        foreach (var Registration in LoadedPlugins.Values)
        {
            await Registration.Plugin.DisposeAsync().ConfigureAwait(false);
        }

        LoadedPlugins.Clear();
    }
}

internal sealed class PluginRegistration
{
    public required IOpenClawPlugin Plugin { get; set; }
    public bool IsInitialized { get; set; }
}

/// <summary>
/// Factory interface for creating plugin instances.
/// </summary>
public interface IOpenClawPluginFactory
{
    IOpenClawPlugin CreatePlugin();
}

/// <summary>
/// Default plugin context providing minimal gateway access.
/// </summary>
internal sealed class DefaultPluginContext : IOpenClawPluginContext
{
    public Task<GatewayResponse> DispatchMessageAsync(GatewayMessage Message, CancellationToken Cancel = default)
    {
        // In-process plugins should have the gateway injected separately.
        // This default implementation returns a stub response.
        return Task.FromResult(new GatewayResponse
        {
            RequestId = Message.Id,
            Text = string.Empty,
            StopReason = "no_gateway_context",
            IsComplete = true,
        });
    }

    public GatewayConfig GetConfig() => new();

    public void Log(string Level, string Message)
    {
        // Default: console output. In production, wire to ILogger.
        Console.WriteLine($"[Plugin:{Level}] {Message}");
    }
}

#pragma warning restore SA1600
