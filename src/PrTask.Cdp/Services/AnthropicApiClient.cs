using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using PrTask.Claude.Wasm.Models;

namespace PrTask.Claude.Wasm.Services;

internal sealed class AnthropicApiClient : IDisposable
{
    private readonly HttpClient Client;
    private readonly JsonSerializerOptions JsonOptions;
    private bool Disposed;

    internal AnthropicApiClient(string AccessToken)
    {
        Client = new HttpClient();
        Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
        Client.DefaultRequestHeaders.Add("anthropic-version", "2023-06-01");
        Client.DefaultRequestHeaders.Add("anthropic-dangerous-direct-browser-access", "true");
        JsonOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
            DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        };
    }

    internal async Task<ApiResponse> SendMessageAsync(
        IReadOnlyList<ApiMessage> Messages,
        string? SystemPrompt = null,
        IReadOnlyList<ApiToolDefinition>? Tools = null,
        string Model = "claude-sonnet-4-20250514",
        int MaxTokens = 16384,
        CancellationToken Ct = default)
    {
        var Request = new ApiRequest
        {
            Model = Model,
            MaxTokens = MaxTokens,
            Messages = Messages,
            System = SystemPrompt,
            Stream = false,
            Tools = Tools,
        };

        var Json = JsonSerializer.Serialize(Request, JsonOptions);
        using var Content = new StringContent(Json, Encoding.UTF8, "application/json");
        using var Response = await Client.PostAsync("https://api.anthropic.com/v1/messages", Content, Ct).ConfigureAwait(false);
        Response.EnsureSuccessStatusCode();
        var ResponseBody = await Response.Content.ReadAsStringAsync(Ct).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ApiResponse>(ResponseBody, JsonOptions)!;
    }

    internal async IAsyncEnumerable<ApiStreamDelta> StreamMessageAsync(
        IReadOnlyList<ApiMessage> Messages,
        string? SystemPrompt = null,
        IReadOnlyList<ApiToolDefinition>? Tools = null,
        string Model = "claude-sonnet-4-20250514",
        int MaxTokens = 16384,
        [EnumeratorCancellation] CancellationToken Ct = default)
    {
        var Request = new ApiRequest
        {
            Model = Model,
            MaxTokens = MaxTokens,
            Messages = Messages,
            System = SystemPrompt,
            Stream = true,
            Tools = Tools,
        };

        var Json = JsonSerializer.Serialize(Request, JsonOptions);
        using var Content = new StringContent(Json, Encoding.UTF8, "application/json");
        using var HttpRequest = new HttpRequestMessage(HttpMethod.Post, "https://api.anthropic.com/v1/messages")
        {
            Content = Content,
        };
        HttpRequest.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("text/event-stream"));

        using var Response = await Client.SendAsync(HttpRequest, HttpCompletionOption.ResponseHeadersRead, Ct).ConfigureAwait(false);
        Response.EnsureSuccessStatusCode();
        using var Stream = await Response.Content.ReadAsStreamAsync(Ct).ConfigureAwait(false);
        using var Reader = new StreamReader(Stream, Encoding.UTF8);

        var EventType = string.Empty;
        while (!Reader.EndOfStream && !Ct.IsCancellationRequested)
        {
            var Line = await Reader.ReadLineAsync(Ct).ConfigureAwait(false);
            if (Line is null)
                break;

            if (Line.StartsWith("event: ", StringComparison.Ordinal))
            {
                EventType = Line.Substring(7);
                continue;
            }

            if (!Line.StartsWith("data: ", StringComparison.Ordinal))
                continue;

            var DataJson = Line.Substring(6);
            var DataElement = JsonSerializer.Deserialize<JsonElement>(DataJson, JsonOptions);

            if (string.Equals(EventType, "content_block_delta", StringComparison.Ordinal))
            {
                if (DataElement.TryGetProperty("delta", out var DeltaElement))
                {
                    var Delta = JsonSerializer.Deserialize<ApiStreamDelta>(DeltaElement.GetRawText(), JsonOptions);
                    if (Delta is not null)
                        yield return Delta;
                }
            }
            else if (string.Equals(EventType, "message_delta", StringComparison.Ordinal))
            {
                if (DataElement.TryGetProperty("delta", out var DeltaElement))
                {
                    var Delta = JsonSerializer.Deserialize<ApiStreamDelta>(DeltaElement.GetRawText(), JsonOptions);
                    if (Delta is not null)
                        yield return Delta;
                }
            }
            else if (string.Equals(EventType, "content_block_start", StringComparison.Ordinal))
            {
                if (DataElement.TryGetProperty("content_block", out var BlockElement))
                {
                    var Block = JsonSerializer.Deserialize<ApiContentBlock>(BlockElement.GetRawText(), JsonOptions);
                    if (Block is not null)
                    {
                        yield return new ApiStreamDelta
                        {
                            Type = Block.Type,
                            Text = Block.Name,
                        };
                    }
                }
            }
        }
    }

    public void Dispose()
    {
        if (!Disposed)
        {
            Client.Dispose();
            Disposed = true;
        }
    }
}
