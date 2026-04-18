using System.Globalization;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using PrTask.OpenClaw.Models;

namespace PrTask.OpenClaw.Gateway;

#pragma warning disable SA1600

/// <summary>
/// HTTP API service providing REST endpoints for the gateway.
/// In-process replacement for openclaw's server-http.ts Hono routes.
/// Exposes hooks, OpenAI-compatible chat completions, health probes, and session management.
///
/// Can be used standalone via StartListeningAsync for external webhook integrations,
/// or called directly via HandleRequestAsync for in-process routing.
/// </summary>
public sealed class OpenClawHttpService : IAsyncDisposable
{
    private readonly OpenClawGatewayService Gateway;
    private HttpListener? Listener;

    public OpenClawHttpService(OpenClawGatewayService GatewayService)
    {
        Gateway = GatewayService ?? throw new ArgumentNullException(nameof(GatewayService));
    }

    /// <summary>
    /// Start an HTTP listener for external webhook and API access.
    /// Maps to openclaw's createHttpServer in server-http.ts.
    /// </summary>
    public async Task StartListeningAsync(string Prefix, CancellationToken Cancel = default)
    {
        Listener = new HttpListener();
        Listener.Prefixes.Add(Prefix);
        Listener.Start();

        _ = Task.Run(async () =>
        {
            while (!Cancel.IsCancellationRequested && Listener.IsListening)
            {
                try
                {
                    var Context = await Listener.GetContextAsync().ConfigureAwait(false);
                    _ = HandleHttpContextAsync(Context, Cancel);
                }
                catch (ObjectDisposedException)
                {
                    break;
                }
                catch (HttpListenerException)
                {
                    break;
                }
            }
        }, Cancel);

        await Task.CompletedTask.ConfigureAwait(false);
    }

    /// <summary>
    /// Handle an in-process HTTP-style request without requiring an actual HTTP server.
    /// Returns (StatusCode, ResponseBody).
    /// </summary>
    public async Task<(int StatusCode, string Body)> HandleRequestAsync(
        string Method, string Path, string Body, Dictionary<string, string>? Headers = null, CancellationToken Cancel = default)
    {
        var NormalizedPath = Path.TrimStart('/').ToLowerInvariant();

        // Health/readiness probe
        if (NormalizedPath is "health" or "healthz" or "ready")
        {
            var Snapshot = Gateway.GetHealthSnapshot();
            return (200, JsonSerializer.Serialize(Snapshot));
        }

        // Sessions API
        if (NormalizedPath == "sessions" && string.Equals(Method, "GET", StringComparison.OrdinalIgnoreCase))
        {
            var SessionList = Gateway.SessionManager.ListSessions();
            return (200, JsonSerializer.Serialize(SessionList));
        }

        // Hook dispatch
        if (NormalizedPath.StartsWith("hooks/", StringComparison.OrdinalIgnoreCase))
        {
            var HookPath = NormalizedPath["hooks/".Length..];
            var Response = await Gateway.DispatchHookAsync(HookPath, Body, Headers, Cancel).ConfigureAwait(false);
            if (Response.StopReason == "hook_not_found")
            {
                return (404, "{\"error\":\"hook_not_found\"}");
            }

            if (Response.StopReason == "hook_auth_failed")
            {
                return (401, "{\"error\":\"unauthorized\"}");
            }

            if (Response.StopReason == "hook_duplicate")
            {
                return (200, "{\"status\":\"duplicate\"}");
            }

            return (200, JsonSerializer.Serialize(Response));
        }

        // OpenAI-compatible chat completions endpoint
        if (NormalizedPath == "v1/chat/completions" && string.Equals(Method, "POST", StringComparison.OrdinalIgnoreCase))
        {
            return await HandleOpenAiChatCompletionAsync(Body, Cancel).ConfigureAwait(false);
        }

        return (404, "{\"error\":\"not_found\"}");
    }

    /// <summary>
    /// Handle OpenAI-compatible /v1/chat/completions request.
    /// Maps to openclaw's openai-http.ts.
    /// </summary>
    private async Task<(int StatusCode, string Body)> HandleOpenAiChatCompletionAsync(string Body, CancellationToken Cancel)
    {
        JsonNode? Parsed;
        try
        {
            Parsed = JsonNode.Parse(Body);
        }
        catch
        {
            return (400, "{\"error\":\"invalid_json\"}");
        }

        if (Parsed is null)
        {
            return (400, "{\"error\":\"empty_body\"}");
        }

        var Messages = Parsed["messages"]?.AsArray();
        var LastMessage = Messages?.LastOrDefault();
        var Content = LastMessage?["content"]?.GetValue<string>() ?? string.Empty;
        var Model = Parsed["model"]?.GetValue<string>() ?? "default";

        var GatewayMsg = new GatewayMessage
        {
            Text = Content,
            ChannelId = "openai-http",
            AgentId = "main",
        };

        var Response = await Gateway.DispatchMessageAsync(GatewayMsg, Cancel).ConfigureAwait(false);

        // Format as OpenAI-compatible response
        var OpenAiResponse = new JsonObject
        {
            ["id"] = string.Format(CultureInfo.InvariantCulture, "chatcmpl-{0}", Response.Id),
            ["object"] = "chat.completion",
            ["created"] = new DateTimeOffset(Response.Timestamp).ToUnixTimeSeconds(),
            ["model"] = Model,
            ["choices"] = new JsonArray
            {
                new JsonObject
                {
                    ["index"] = 0,
                    ["message"] = new JsonObject
                    {
                        ["role"] = "assistant",
                        ["content"] = Response.Text,
                    },
                    ["finish_reason"] = Response.StopReason ?? "stop",
                },
            },
            ["usage"] = new JsonObject
            {
                ["prompt_tokens"] = Response.Usage?.InputTokens ?? 0,
                ["completion_tokens"] = Response.Usage?.OutputTokens ?? 0,
                ["total_tokens"] = Response.Usage?.TotalTokens ?? 0,
            },
        };

        return (200, OpenAiResponse.ToJsonString());
    }

    private async Task HandleHttpContextAsync(HttpListenerContext Context, CancellationToken Cancel)
    {
        try
        {
            var Method = Context.Request.HttpMethod;
            var Path = Context.Request.Url?.AbsolutePath ?? "/";
            var Body = string.Empty;

            if (Context.Request.HasEntityBody)
            {
                using var Reader = new System.IO.StreamReader(Context.Request.InputStream, Encoding.UTF8);
                Body = await Reader.ReadToEndAsync(Cancel).ConfigureAwait(false);
            }

            var Headers = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            foreach (string HeaderName in Context.Request.Headers)
            {
                Headers[HeaderName] = Context.Request.Headers[HeaderName] ?? string.Empty;
            }

            var (StatusCode, ResponseBody) = await HandleRequestAsync(Method, Path, Body, Headers, Cancel).ConfigureAwait(false);

            Context.Response.StatusCode = StatusCode;
            Context.Response.ContentType = "application/json";
            var Buffer = Encoding.UTF8.GetBytes(ResponseBody);
            Context.Response.ContentLength64 = Buffer.Length;
            await Context.Response.OutputStream.WriteAsync(Buffer, Cancel).ConfigureAwait(false);
        }
        catch
        {
            Context.Response.StatusCode = 500;
        }
        finally
        {
            Context.Response.Close();
        }
    }

    public async ValueTask DisposeAsync()
    {
        if (Listener is not null && Listener.IsListening)
        {
            Listener.Stop();
            Listener.Close();
        }

        await Task.CompletedTask.ConfigureAwait(false);
    }
}

#pragma warning restore SA1600
