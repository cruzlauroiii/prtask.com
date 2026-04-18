using System.Collections.Concurrent;
using PrTask.OpenClaw.Models;

namespace PrTask.OpenClaw.Gateway;

#pragma warning disable SA1600

/// <summary>
/// Manages gateway sessions (conversation state between users and agents).
/// Maps to openclaw's server-sessions-*.ts, config/sessions.ts, routing/session-key.ts.
/// Handles session creation, resolution, key derivation, and history management.
/// </summary>
public sealed class OpenClawSessionService
{
    public const string DefaultAccountId = "default";
    public const string DefaultAgentId = "main";
    public const string DefaultMainKey = "main";

    private readonly ConcurrentDictionary<string, GatewaySession> Sessions;

    internal OpenClawSessionService(ConcurrentDictionary<string, GatewaySession> SessionStore)
    {
        Sessions = SessionStore;
    }

    /// <summary>
    /// Resolve or create a session for the given message.
    /// Builds a session key from channel, account, and agent identifiers.
    /// Maps to openclaw's resolveSessionKey + loadSessionStore.
    /// </summary>
    public GatewaySession ResolveSession(GatewayMessage Message)
    {
        ArgumentNullException.ThrowIfNull(Message);

        var Key = DeriveSessionKey(Message.ChannelId, Message.AccountId, Message.AgentId, Message.ThreadId);

        if (string.IsNullOrEmpty(Message.SessionKey))
        {
            Message.SessionKey = Key;
        }

        return Sessions.GetOrAdd(Key, _ => new GatewaySession
        {
            SessionKey = Key,
            AgentId = Message.AgentId,
            ChannelId = Message.ChannelId,
            AccountId = Message.AccountId,
            CreatedAt = DateTime.UtcNow,
            LastActivityAt = DateTime.UtcNow,
        });
    }

    /// <summary>
    /// Get an existing session by key.
    /// </summary>
    public GatewaySession? GetSession(string SessionKey)
    {
        Sessions.TryGetValue(SessionKey, out var Session);
        return Session;
    }

    /// <summary>
    /// List all active sessions.
    /// </summary>
    public List<GatewaySession> ListSessions()
    {
        return Sessions.Values.ToList();
    }

    /// <summary>
    /// Remove a session by key.
    /// </summary>
    public bool RemoveSession(string SessionKey)
    {
        return Sessions.TryRemove(SessionKey, out _);
    }

    /// <summary>
    /// Trim session history to the given max length.
    /// Maps to openclaw's session history truncation logic.
    /// </summary>
    public void TrimSessionHistory(string SessionKey, int MaxHistory)
    {
        if (Sessions.TryGetValue(SessionKey, out var Session) && Session.History.Count > MaxHistory)
        {
            Session.History.RemoveRange(0, Session.History.Count - MaxHistory);
        }
    }

    /// <summary>
    /// Derive a session key from component parts.
    /// Format: agent:{agentId}:{channelId}:{accountId}[:{threadId}]
    /// Maps to openclaw's routing/session-key.ts buildAgentMainSessionKey.
    /// </summary>
    public static string DeriveSessionKey(string ChannelId, string AccountId, string AgentId, string? ThreadId = null)
    {
        var NormalizedAgent = NormalizeId(AgentId, DefaultAgentId);
        var NormalizedChannel = NormalizeId(ChannelId, "unknown");
        var NormalizedAccount = NormalizeId(AccountId, DefaultAccountId);

        var Key = $"agent:{NormalizedAgent}:{NormalizedChannel}:{NormalizedAccount}";
        if (!string.IsNullOrWhiteSpace(ThreadId))
        {
            Key = $"{Key}:{ThreadId.Trim().ToLowerInvariant()}";
        }

        return Key;
    }

    /// <summary>
    /// Parse a session key back into its component parts.
    /// Maps to openclaw's parseAgentSessionKey.
    /// </summary>
    public static ParsedSessionKey? ParseSessionKey(string SessionKey)
    {
        if (string.IsNullOrWhiteSpace(SessionKey))
        {
            return null;
        }

        var Parts = SessionKey.Split(':');
        if (Parts.Length < 4 || !string.Equals(Parts[0], "agent", StringComparison.OrdinalIgnoreCase))
        {
            return null;
        }

        return new ParsedSessionKey
        {
            AgentId = Parts[1],
            ChannelId = Parts[2],
            AccountId = Parts[3],
            ThreadId = Parts.Length > 4 ? Parts[4] : null,
        };
    }

    private static string NormalizeId(string Value, string Default)
    {
        var Trimmed = (Value ?? string.Empty).Trim().ToLowerInvariant();
        return string.IsNullOrEmpty(Trimmed) ? Default : Trimmed;
    }
}

public sealed class ParsedSessionKey
{
    public string AgentId { get; set; } = string.Empty;
    public string ChannelId { get; set; } = string.Empty;
    public string AccountId { get; set; } = string.Empty;
    public string? ThreadId { get; set; }
}

#pragma warning restore SA1600
