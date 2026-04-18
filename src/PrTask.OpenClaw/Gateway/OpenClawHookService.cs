using System.Collections.Concurrent;
using PrTask.OpenClaw.Models;

namespace PrTask.OpenClaw.Gateway;

#pragma warning disable SA1600

/// <summary>
/// Hook system for extending gateway behavior via HTTP webhooks and event hooks.
/// Maps to openclaw's hooks.ts, hooks-mapping.ts, server-http.ts hook dispatch,
/// and hook-runner-global.ts.
///
/// Supports:
/// - Pre-dispatch hooks (modify/suppress inbound messages)
/// - Post-dispatch hooks (modify/augment agent responses)
/// - Webhook HTTP endpoints (external integrations)
/// - Idempotency deduplication
/// </summary>
public sealed class OpenClawHookService
{
    private const int DedupeMaxEntries = 1000;
    private static readonly TimeSpan DedupeTtl = TimeSpan.FromMinutes(5);

    private readonly OpenClawGatewayService Gateway;
    private readonly ConcurrentDictionary<string, HookRegistration> RegisteredHooks = new(StringComparer.OrdinalIgnoreCase);
    private readonly ConcurrentDictionary<string, DateTime> IdempotencyKeys = new(StringComparer.OrdinalIgnoreCase);
    private readonly List<Func<GatewayMessage, CancellationToken, Task<GatewayMessage?>>> PreDispatchHandlers = [];
    private readonly List<Func<GatewayMessage, GatewayResponse, CancellationToken, Task<GatewayResponse>>> PostDispatchHandlers = [];

    internal OpenClawHookService(OpenClawGatewayService GatewayInstance)
    {
        Gateway = GatewayInstance;
    }

    /// <summary>
    /// Register a webhook hook from config.
    /// Maps to openclaw's applyHookMappings.
    /// </summary>
    public void RegisterHook(HookConfig Config)
    {
        ArgumentNullException.ThrowIfNull(Config);
        var Key = Config.Path.Trim('/').ToLowerInvariant();
        RegisteredHooks[Key] = new HookRegistration
        {
            Config = Config,
            Path = Key,
        };
    }

    /// <summary>
    /// Register a pre-dispatch handler that can modify or suppress inbound messages.
    /// </summary>
    public void OnPreDispatch(Func<GatewayMessage, CancellationToken, Task<GatewayMessage?>> Handler)
    {
        PreDispatchHandlers.Add(Handler);
    }

    /// <summary>
    /// Register a post-dispatch handler that can modify agent responses.
    /// </summary>
    public void OnPostDispatch(Func<GatewayMessage, GatewayResponse, CancellationToken, Task<GatewayResponse>> Handler)
    {
        PostDispatchHandlers.Add(Handler);
    }

    /// <summary>
    /// Run all pre-dispatch hooks on an inbound message.
    /// Returns null if the message should be suppressed.
    /// </summary>
    internal async Task<GatewayMessage?> RunPreDispatchAsync(GatewayMessage Message, CancellationToken Cancel)
    {
        var Current = (GatewayMessage?)Message;
        foreach (var Handler in PreDispatchHandlers)
        {
            if (Current is null)
            {
                break;
            }

            Current = await Handler(Current, Cancel).ConfigureAwait(false);
        }

        return Current;
    }

    /// <summary>
    /// Run all post-dispatch hooks on an agent response.
    /// </summary>
    internal async Task<GatewayResponse> RunPostDispatchAsync(GatewayMessage Message, GatewayResponse Response, CancellationToken Cancel)
    {
        var Current = Response;
        foreach (var Handler in PostDispatchHandlers)
        {
            Current = await Handler(Message, Current, Cancel).ConfigureAwait(false);
        }

        return Current;
    }

    /// <summary>
    /// Dispatch an inbound HTTP webhook request.
    /// Maps to openclaw's server-http.ts hook handling, including idempotency, auth, and routing.
    /// </summary>
    public async Task<GatewayResponse> DispatchWebhookAsync(string Path, string Body, Dictionary<string, string>? Headers, CancellationToken Cancel)
    {
        var NormalizedPath = Path.Trim('/').ToLowerInvariant();

        if (!RegisteredHooks.TryGetValue(NormalizedPath, out var Hook))
        {
            return new GatewayResponse
            {
                Text = string.Empty,
                StopReason = "hook_not_found",
                IsComplete = true,
            };
        }

        // Validate auth token if configured
        if (!string.IsNullOrEmpty(Hook.Config.Token))
        {
            var ProvidedToken = ExtractHookToken(Headers);
            if (!string.Equals(ProvidedToken, Hook.Config.Token, StringComparison.Ordinal))
            {
                return new GatewayResponse
                {
                    Text = string.Empty,
                    StopReason = "hook_auth_failed",
                    IsComplete = true,
                };
            }
        }

        // Check idempotency
        var IdempotencyKey = ResolveIdempotencyKey(Headers);
        if (IdempotencyKey is not null)
        {
            if (IdempotencyKeys.ContainsKey(IdempotencyKey))
            {
                return new GatewayResponse
                {
                    Text = string.Empty,
                    StopReason = "hook_duplicate",
                    IsComplete = true,
                };
            }

            IdempotencyKeys[IdempotencyKey] = DateTime.UtcNow;
            PruneIdempotencyKeys();
        }

        // Build gateway message from webhook body
        var Message = new GatewayMessage
        {
            Text = Body,
            ChannelId = Hook.Config.Channel ?? "webhook",
            AgentId = Hook.Config.AgentId ?? "main",
            Metadata = Headers != null ? new Dictionary<string, string>(Headers, StringComparer.OrdinalIgnoreCase) : [],
        };

        // Route based on delivery mode
        return Hook.Config.Delivery switch
        {
            HookDeliveryMode.Agent => await Gateway.DispatchMessageAsync(Message, Cancel).ConfigureAwait(false),
            HookDeliveryMode.Wake => new GatewayResponse
            {
                RequestId = Message.Id,
                Text = "wake_dispatched",
                IsComplete = true,
            },
            HookDeliveryMode.Deliver => await Gateway.DispatchMessageAsync(Message, Cancel).ConfigureAwait(false),
            _ => new GatewayResponse
            {
                RequestId = Message.Id,
                Text = string.Empty,
                StopReason = "unknown_delivery_mode",
                IsComplete = true,
            },
        };
    }

    public int RegisteredHookCount => RegisteredHooks.Count;

    private static string? ExtractHookToken(Dictionary<string, string>? Headers)
    {
        if (Headers is null)
        {
            return null;
        }

        if (Headers.TryGetValue("Authorization", out var AuthHeader))
        {
            var Parts = AuthHeader.Split(' ', 2);
            if (Parts.Length == 2 && string.Equals(Parts[0], "Bearer", StringComparison.OrdinalIgnoreCase))
            {
                return Parts[1].Trim();
            }
        }

        if (Headers.TryGetValue("X-Hook-Token", out var HookToken))
        {
            return HookToken.Trim();
        }

        return null;
    }

    private static string? ResolveIdempotencyKey(Dictionary<string, string>? Headers)
    {
        if (Headers is null)
        {
            return null;
        }

        if (Headers.TryGetValue("Idempotency-Key", out var Key))
        {
            return Key.Trim();
        }

        if (Headers.TryGetValue("X-Idempotency-Key", out var XKey))
        {
            return XKey.Trim();
        }

        return null;
    }

    private void PruneIdempotencyKeys()
    {
        if (IdempotencyKeys.Count <= DedupeMaxEntries)
        {
            return;
        }

        var Cutoff = DateTime.UtcNow - DedupeTtl;
        var Expired = IdempotencyKeys.Where(Kv => Kv.Value < Cutoff).Select(Kv => Kv.Key).ToList();
        foreach (var Key in Expired)
        {
            IdempotencyKeys.TryRemove(Key, out _);
        }
    }
}

internal sealed class HookRegistration
{
    public HookConfig Config { get; set; } = new();
    public string Path { get; set; } = string.Empty;
}

#pragma warning restore SA1600
