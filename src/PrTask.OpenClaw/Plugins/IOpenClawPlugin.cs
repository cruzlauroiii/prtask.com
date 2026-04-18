using PrTask.OpenClaw.Models;

namespace PrTask.OpenClaw.Plugins;

#pragma warning disable SA1600

/// <summary>
/// Interface for OpenClaw plugins.
/// Maps to openclaw's OpenClawPluginDefinition from plugins/types.ts.
/// Plugins can extend the gateway with custom tools, hooks, channel integrations, and providers.
/// </summary>
public interface IOpenClawPlugin : IAsyncDisposable
{
    /// <summary>
    /// Plugin manifest declaring capabilities and metadata.
    /// </summary>
    PluginManifest Manifest { get; }

    /// <summary>
    /// Initialize the plugin with its configuration.
    /// Called during plugin loading phase.
    /// </summary>
    Task InitializeAsync(PluginConfig Config, IOpenClawPluginContext Context, CancellationToken Cancel = default);

    /// <summary>
    /// Attempt to handle an inbound message.
    /// Returns a response if the plugin handled the message, null to pass through.
    /// </summary>
    Task<GatewayResponse?> HandleMessageAsync(GatewayMessage Message, GatewaySession Session, CancellationToken Cancel = default);

    /// <summary>
    /// Execute a tool call from an agent.
    /// Maps to openclaw's plugin tool execution.
    /// </summary>
    Task<string?> ExecuteToolAsync(string ToolName, Dictionary<string, string> Arguments, CancellationToken Cancel = default);
}

/// <summary>
/// Context provided to plugins during initialization, giving access to gateway services.
/// Maps to openclaw's PluginRuntime from plugins/runtime/types.ts.
/// </summary>
public interface IOpenClawPluginContext
{
    /// <summary>
    /// Send a message through the gateway.
    /// </summary>
    Task<GatewayResponse> DispatchMessageAsync(GatewayMessage Message, CancellationToken Cancel = default);

    /// <summary>
    /// Get the current gateway configuration.
    /// </summary>
    GatewayConfig GetConfig();

    /// <summary>
    /// Log a message from the plugin.
    /// </summary>
    void Log(string Level, string Message);
}

#pragma warning restore SA1600
