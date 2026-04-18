using System.Collections.Concurrent;
using PrTask.OpenClaw.Models;

namespace PrTask.OpenClaw.Plugins;

#pragma warning disable SA1600

/// <summary>
/// Registry of available plugin manifests.
/// Maps to openclaw's plugins/registry.ts PluginRegistry.
/// Provides discovery, lookup, and dependency resolution for plugins.
/// </summary>
public sealed class OpenClawPluginRegistry
{
    private readonly ConcurrentDictionary<string, PluginManifest> Manifests = new(StringComparer.OrdinalIgnoreCase);

    /// <summary>
    /// Register a plugin manifest.
    /// </summary>
    public void Register(PluginManifest Manifest)
    {
        ArgumentNullException.ThrowIfNull(Manifest);
        if (string.IsNullOrWhiteSpace(Manifest.Id))
        {
            throw new ArgumentException("Plugin manifest must have an Id", nameof(Manifest));
        }

        Manifests[Manifest.Id.ToLowerInvariant()] = Manifest;
    }

    /// <summary>
    /// Look up a plugin manifest by ID.
    /// </summary>
    public PluginManifest? GetManifest(string PluginId)
    {
        Manifests.TryGetValue(PluginId.ToLowerInvariant(), out var Manifest);
        return Manifest;
    }

    /// <summary>
    /// List all registered manifests.
    /// </summary>
    public List<PluginManifest> ListManifests()
    {
        return Manifests.Values.ToList();
    }

    /// <summary>
    /// List manifests by kind (e.g., Channel, Provider).
    /// </summary>
    public List<PluginManifest> ListByKind(PluginKind Kind)
    {
        return Manifests.Values.Where(M => M.Kind == Kind).ToList();
    }

    /// <summary>
    /// Check if a plugin is registered.
    /// </summary>
    public bool HasPlugin(string PluginId)
    {
        return Manifests.ContainsKey(PluginId.ToLowerInvariant());
    }

    /// <summary>
    /// Remove a plugin from the registry.
    /// </summary>
    public bool Unregister(string PluginId)
    {
        return Manifests.TryRemove(PluginId.ToLowerInvariant(), out _);
    }

    /// <summary>
    /// Get all tool definitions across all registered plugins.
    /// </summary>
    public List<(string PluginId, PluginToolDefinition Tool)> ListAllTools()
    {
        var Tools = new List<(string PluginId, PluginToolDefinition Tool)>();
        foreach (var Manifest in Manifests.Values)
        {
            foreach (var Tool in Manifest.Tools)
            {
                Tools.Add((Manifest.Id, Tool));
            }
        }

        return Tools;
    }
}

#pragma warning restore SA1600
