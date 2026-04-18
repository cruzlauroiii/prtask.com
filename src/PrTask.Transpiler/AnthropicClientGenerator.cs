using System.Text;
using PrTask.Domain.Constants;

namespace PrTask.Transpiler;

public sealed class AnthropicClientGenerator
{
    private readonly string OutputDir;
    private readonly string Namespace;

    public AnthropicClientGenerator(string OutputDir, string Namespace)
    {
        this.OutputDir = OutputDir;
        this.Namespace = Namespace;
    }

    public void Generate()
    {
        Directory.CreateDirectory(Path.Combine(OutputDir, AnthropicConstants.GeneratedServicesDirectory));
        Directory.CreateDirectory(Path.Combine(OutputDir, AnthropicConstants.GeneratedModelsDirectory));

        WriteModels();
        WriteApiClient();
        WriteToolDispatcher();
    }

    private void WriteModels()
    {
        var Sb = new StringBuilder();
        Sb.Append("using System.Text.Json;").AppendLine();
        Sb.Append("using System.Text.Json.Serialization;").AppendLine();
        Sb.AppendLine();
        Sb.Append("namespace ").Append(Namespace).Append('.').Append(AnthropicConstants.GeneratedModelsDirectory).AppendLine(";");
        Sb.AppendLine();

        Sb.AppendLine("internal sealed class ApiMessage");
        Sb.AppendLine("{");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.JsonPropertyRole).AppendLine("\")]");
        Sb.AppendLine("    public required string Role { get; init; }");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.JsonPropertyContent).AppendLine("\")]");
        Sb.AppendLine("    public required IReadOnlyList<ApiContentBlock> Content { get; init; }");
        Sb.AppendLine("}");
        Sb.AppendLine();

        Sb.AppendLine("internal sealed class ApiContentBlock");
        Sb.AppendLine("{");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.JsonPropertyType).AppendLine("\")]");
        Sb.AppendLine("    public required string Type { get; init; }");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.JsonPropertyText).AppendLine("\")]");
        Sb.AppendLine("    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]");
        Sb.AppendLine("    public string? Text { get; init; }");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.JsonPropertyId).AppendLine("\")]");
        Sb.AppendLine("    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]");
        Sb.AppendLine("    public string? Id { get; init; }");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.JsonPropertyName).AppendLine("\")]");
        Sb.AppendLine("    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]");
        Sb.AppendLine("    public string? Name { get; init; }");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.JsonPropertyInput).AppendLine("\")]");
        Sb.AppendLine("    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]");
        Sb.AppendLine("    public JsonElement? Input { get; init; }");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.JsonPropertyToolUseId).AppendLine("\")]");
        Sb.AppendLine("    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]");
        Sb.AppendLine("    public string? ToolUseId { get; init; }");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.JsonPropertyIsError).AppendLine("\")]");
        Sb.AppendLine("    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]");
        Sb.AppendLine("    public bool? IsError { get; init; }");
        Sb.AppendLine("}");
        Sb.AppendLine();

        Sb.AppendLine("internal sealed class ApiRequest");
        Sb.AppendLine("{");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.ModelParameterName).AppendLine("\")]");
        Sb.AppendLine("    public required string Model { get; init; }");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.MaxTokensParameterName).AppendLine("\")]");
        Sb.AppendLine("    public required int MaxTokens { get; init; }");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.MessagesParameterName).AppendLine("\")]");
        Sb.AppendLine("    public required IReadOnlyList<ApiMessage> Messages { get; init; }");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.SystemParameterName).AppendLine("\")]");
        Sb.AppendLine("    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]");
        Sb.AppendLine("    public string? System { get; init; }");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.StreamParameterName).AppendLine("\")]");
        Sb.AppendLine("    public bool Stream { get; init; }");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.ToolsParameterName).AppendLine("\")]");
        Sb.AppendLine("    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]");
        Sb.AppendLine("    public IReadOnlyList<ApiToolDefinition>? Tools { get; init; }");
        Sb.AppendLine("}");
        Sb.AppendLine();

        Sb.AppendLine("internal sealed class ApiResponse");
        Sb.AppendLine("{");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.JsonPropertyId).AppendLine("\")]");
        Sb.AppendLine("    public string Id { get; init; } = string.Empty;");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.JsonPropertyType).AppendLine("\")]");
        Sb.AppendLine("    public string Type { get; init; } = string.Empty;");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.JsonPropertyRole).AppendLine("\")]");
        Sb.AppendLine("    public string Role { get; init; } = string.Empty;");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.JsonPropertyContent).AppendLine("\")]");
        Sb.AppendLine("    public IReadOnlyList<ApiContentBlock> Content { get; init; } = [];");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.ModelParameterName).AppendLine("\")]");
        Sb.AppendLine("    public string Model { get; init; } = string.Empty;");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.JsonPropertyStopReason).AppendLine("\")]");
        Sb.AppendLine("    public string? StopReason { get; init; }");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.JsonPropertyUsage).AppendLine("\")]");
        Sb.AppendLine("    public ApiTokenUsage? Usage { get; init; }");
        Sb.AppendLine("}");
        Sb.AppendLine();

        Sb.AppendLine("internal sealed class ApiTokenUsage");
        Sb.AppendLine("{");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.JsonPropertyInputTokens).AppendLine("\")]");
        Sb.AppendLine("    public int InputTokens { get; init; }");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.JsonPropertyOutputTokens).AppendLine("\")]");
        Sb.AppendLine("    public int OutputTokens { get; init; }");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.JsonPropertyCacheCreationInputTokens).AppendLine("\")]");
        Sb.AppendLine("    public int? CacheCreationInputTokens { get; init; }");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.JsonPropertyCacheReadInputTokens).AppendLine("\")]");
        Sb.AppendLine("    public int? CacheReadInputTokens { get; init; }");
        Sb.AppendLine("}");
        Sb.AppendLine();

        Sb.AppendLine("internal sealed class ApiToolDefinition");
        Sb.AppendLine("{");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.JsonPropertyName).AppendLine("\")]");
        Sb.AppendLine("    public required string Name { get; init; }");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.JsonPropertyDescription).AppendLine("\")]");
        Sb.AppendLine("    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]");
        Sb.AppendLine("    public string? Description { get; init; }");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.JsonPropertyInputSchema).AppendLine("\")]");
        Sb.AppendLine("    public required JsonElement InputSchema { get; init; }");
        Sb.AppendLine("}");
        Sb.AppendLine();

        Sb.AppendLine("internal sealed class ApiStreamDelta");
        Sb.AppendLine("{");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.JsonPropertyType).AppendLine("\")]");
        Sb.AppendLine("    public string Type { get; init; } = string.Empty;");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.JsonPropertyText).AppendLine("\")]");
        Sb.AppendLine("    public string? Text { get; init; }");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.JsonPropertyPartialJson).AppendLine("\")]");
        Sb.AppendLine("    public string? PartialJson { get; init; }");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.JsonPropertyStopReason).AppendLine("\")]");
        Sb.AppendLine("    public string? StopReason { get; init; }");
        Sb.Append("    [JsonPropertyName(\"").Append(AnthropicConstants.JsonPropertyUsage).AppendLine("\")]");
        Sb.AppendLine("    public ApiTokenUsage? Usage { get; init; }");
        Sb.AppendLine("}");

        File.WriteAllText(
            Path.Combine(OutputDir, AnthropicConstants.GeneratedModelsDirectory, AnthropicConstants.GeneratedModelsFileName),
            Sb.ToString());
    }

    private void WriteApiClient()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("using System.Net.Http.Headers;");
        Sb.AppendLine("using System.Runtime.CompilerServices;");
        Sb.AppendLine("using System.Text;");
        Sb.AppendLine("using System.Text.Json;");
        Sb.Append("using ").Append(Namespace).Append('.').Append(AnthropicConstants.GeneratedModelsDirectory).AppendLine(";");
        Sb.AppendLine();
        Sb.Append("namespace ").Append(Namespace).Append('.').Append(AnthropicConstants.GeneratedServicesDirectory).AppendLine(";");
        Sb.AppendLine();

        Sb.AppendLine("internal sealed class AnthropicApiClient : IDisposable");
        Sb.AppendLine("{");
        Sb.AppendLine("    private readonly HttpClient Client;");
        Sb.AppendLine("    private readonly JsonSerializerOptions JsonOptions;");
        Sb.AppendLine("    private readonly string MessagesEndpoint;");
        Sb.AppendLine("    private bool Disposed;");
        Sb.AppendLine();

        Sb.AppendLine("    internal AnthropicApiClient(string Token, bool IsApiKey = false, string? ProxyBaseUrl = null)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        Client = new HttpClient();");
        Sb.AppendLine("        if (ProxyBaseUrl is not null)");
        Sb.AppendLine("        {");
        Sb.Append("            MessagesEndpoint = string.Concat(ProxyBaseUrl, \"").Append(AnthropicConstants.ProxyMessagesRoute).AppendLine("\");");
        Sb.AppendLine("        }");
        Sb.AppendLine("        else");
        Sb.AppendLine("        {");
        Sb.Append("            MessagesEndpoint = \"").Append(AnthropicConstants.MessagesUrl).AppendLine("\";");
        Sb.AppendLine("            if (IsApiKey)");
        Sb.AppendLine("            {");
        Sb.Append("                Client.DefaultRequestHeaders.Add(\"").Append(AnthropicConstants.ApiKeyHeaderName).AppendLine("\", Token);");
        Sb.AppendLine("            }");
        Sb.AppendLine("            else");
        Sb.AppendLine("            {");
        Sb.AppendLine("                Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(\"Bearer\", Token);");
        Sb.AppendLine("            }");
        Sb.Append("            Client.DefaultRequestHeaders.Add(\"").Append(AnthropicConstants.ApiVersionHeaderName).Append("\", \"").Append(AnthropicConstants.ApiVersionValue).AppendLine("\");");
        Sb.Append("            Client.DefaultRequestHeaders.Add(\"").Append(AnthropicConstants.DangerouslyAllowBrowserHeaderName).Append("\", \"").Append(AnthropicConstants.DangerouslyAllowBrowserHeaderValue).AppendLine("\");");
        Sb.AppendLine("        }");
        Sb.AppendLine("        JsonOptions = new JsonSerializerOptions");
        Sb.AppendLine("        {");
        Sb.AppendLine("            PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,");
        Sb.AppendLine("            DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,");
        Sb.AppendLine("        };");
        Sb.AppendLine("    }");
        Sb.AppendLine();

        Sb.AppendLine("    internal async Task<ApiResponse> SendMessageAsync(");
        Sb.AppendLine("        IReadOnlyList<ApiMessage> Messages,");
        Sb.AppendLine("        string? SystemPrompt = null,");
        Sb.AppendLine("        IReadOnlyList<ApiToolDefinition>? Tools = null,");
        Sb.Append("        string Model = \"").Append(AnthropicConstants.DefaultModel).AppendLine("\",");
        Sb.Append("        int MaxTokens = ").Append(AnthropicConstants.DefaultMaxTokens).AppendLine(",");
        Sb.AppendLine("        CancellationToken Ct = default)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        var Request = new ApiRequest");
        Sb.AppendLine("        {");
        Sb.AppendLine("            Model = Model,");
        Sb.AppendLine("            MaxTokens = MaxTokens,");
        Sb.AppendLine("            Messages = Messages,");
        Sb.AppendLine("            System = SystemPrompt,");
        Sb.AppendLine("            Stream = false,");
        Sb.AppendLine("            Tools = Tools,");
        Sb.AppendLine("        };");
        Sb.AppendLine();
        Sb.AppendLine("        var Json = JsonSerializer.Serialize(Request, JsonOptions);");
        Sb.Append("        using var Content = new StringContent(Json, Encoding.UTF8, \"").Append(AnthropicConstants.ContentTypeJson).AppendLine("\");");
        Sb.AppendLine("        using var Response = await Client.PostAsync(MessagesEndpoint, Content, Ct).ConfigureAwait(false);");
        Sb.AppendLine("        Response.EnsureSuccessStatusCode();");
        Sb.AppendLine("        var ResponseBody = await Response.Content.ReadAsStringAsync(Ct).ConfigureAwait(false);");
        Sb.AppendLine("        return JsonSerializer.Deserialize<ApiResponse>(ResponseBody, JsonOptions)!;");
        Sb.AppendLine("    }");
        Sb.AppendLine();

        Sb.AppendLine("    internal async IAsyncEnumerable<ApiStreamDelta> StreamMessageAsync(");
        Sb.AppendLine("        IReadOnlyList<ApiMessage> Messages,");
        Sb.AppendLine("        string? SystemPrompt = null,");
        Sb.AppendLine("        IReadOnlyList<ApiToolDefinition>? Tools = null,");
        Sb.Append("        string Model = \"").Append(AnthropicConstants.DefaultModel).AppendLine("\",");
        Sb.Append("        int MaxTokens = ").Append(AnthropicConstants.DefaultMaxTokens).AppendLine(",");
        Sb.AppendLine("        [EnumeratorCancellation] CancellationToken Ct = default)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        var Request = new ApiRequest");
        Sb.AppendLine("        {");
        Sb.AppendLine("            Model = Model,");
        Sb.AppendLine("            MaxTokens = MaxTokens,");
        Sb.AppendLine("            Messages = Messages,");
        Sb.AppendLine("            System = SystemPrompt,");
        Sb.AppendLine("            Stream = true,");
        Sb.AppendLine("            Tools = Tools,");
        Sb.AppendLine("        };");
        Sb.AppendLine();
        Sb.AppendLine("        var Json = JsonSerializer.Serialize(Request, JsonOptions);");
        Sb.Append("        using var Content = new StringContent(Json, Encoding.UTF8, \"").Append(AnthropicConstants.ContentTypeJson).AppendLine("\");");
        Sb.AppendLine("        using var HttpRequest = new HttpRequestMessage(HttpMethod.Post, MessagesEndpoint)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            Content = Content,");
        Sb.AppendLine("        };");
        Sb.Append("        HttpRequest.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(\"").Append(AnthropicConstants.AcceptHeaderValue).AppendLine("\"));");
        Sb.AppendLine();
        Sb.AppendLine("        using var Response = await Client.SendAsync(HttpRequest, HttpCompletionOption.ResponseHeadersRead, Ct).ConfigureAwait(false);");
        Sb.AppendLine("        Response.EnsureSuccessStatusCode();");
        Sb.AppendLine("        using var Stream = await Response.Content.ReadAsStreamAsync(Ct).ConfigureAwait(false);");
        Sb.AppendLine("        using var Reader = new StreamReader(Stream, Encoding.UTF8);");
        Sb.AppendLine();
        Sb.AppendLine("        var EventType = string.Empty;");
        Sb.AppendLine("        while (!Reader.EndOfStream && !Ct.IsCancellationRequested)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            var Line = await Reader.ReadLineAsync(Ct).ConfigureAwait(false);");
        Sb.AppendLine("            if (Line is null)");
        Sb.AppendLine("                break;");
        Sb.AppendLine();
        Sb.Append("            if (Line.StartsWith(\"").Append(AnthropicConstants.SseEventPrefix).AppendLine("\", StringComparison.Ordinal))");
        Sb.AppendLine("            {");
        Sb.Append("                EventType = Line.Substring(").Append(AnthropicConstants.SseEventPrefix.Length).AppendLine(");");
        Sb.AppendLine("                continue;");
        Sb.AppendLine("            }");
        Sb.AppendLine();
        Sb.Append("            if (!Line.StartsWith(\"").Append(AnthropicConstants.SseDataPrefix).AppendLine("\", StringComparison.Ordinal))");
        Sb.AppendLine("                continue;");
        Sb.AppendLine();
        Sb.Append("            var DataJson = Line.Substring(").Append(AnthropicConstants.SseDataPrefix.Length).AppendLine(");");
        Sb.AppendLine("            var DataElement = JsonSerializer.Deserialize<JsonElement>(DataJson, JsonOptions);");
        Sb.AppendLine();
        Sb.Append("            if (string.Equals(EventType, \"").Append(AnthropicConstants.SseEventContentBlockDelta).AppendLine("\", StringComparison.Ordinal))");
        Sb.AppendLine("            {");
        Sb.Append("                if (DataElement.TryGetProperty(\"").Append(AnthropicConstants.JsonPropertyDelta).AppendLine("\", out var DeltaElement))");
        Sb.AppendLine("                {");
        Sb.AppendLine("                    var Delta = JsonSerializer.Deserialize<ApiStreamDelta>(DeltaElement.GetRawText(), JsonOptions);");
        Sb.AppendLine("                    if (Delta is not null)");
        Sb.AppendLine("                        yield return Delta;");
        Sb.AppendLine("                }");
        Sb.AppendLine("            }");
        Sb.Append("            else if (string.Equals(EventType, \"").Append(AnthropicConstants.SseEventMessageDelta).AppendLine("\", StringComparison.Ordinal))");
        Sb.AppendLine("            {");
        Sb.Append("                if (DataElement.TryGetProperty(\"").Append(AnthropicConstants.JsonPropertyDelta).AppendLine("\", out var DeltaElement))");
        Sb.AppendLine("                {");
        Sb.AppendLine("                    var Delta = JsonSerializer.Deserialize<ApiStreamDelta>(DeltaElement.GetRawText(), JsonOptions);");
        Sb.AppendLine("                    if (Delta is not null)");
        Sb.AppendLine("                        yield return Delta;");
        Sb.AppendLine("                }");
        Sb.AppendLine("            }");
        Sb.Append("            else if (string.Equals(EventType, \"").Append(AnthropicConstants.SseEventContentBlockStart).AppendLine("\", StringComparison.Ordinal))");
        Sb.AppendLine("            {");
        Sb.Append("                if (DataElement.TryGetProperty(\"").Append(AnthropicConstants.JsonPropertyContent + "_block").AppendLine("\", out var BlockElement))");
        Sb.AppendLine("                {");
        Sb.AppendLine("                    var Block = JsonSerializer.Deserialize<ApiContentBlock>(BlockElement.GetRawText(), JsonOptions);");
        Sb.AppendLine("                    if (Block is not null)");
        Sb.AppendLine("                    {");
        Sb.AppendLine("                        yield return new ApiStreamDelta");
        Sb.AppendLine("                        {");
        Sb.AppendLine("                            Type = Block.Type,");
        Sb.AppendLine("                            Text = Block.Name,");
        Sb.AppendLine("                        };");
        Sb.AppendLine("                    }");
        Sb.AppendLine("                }");
        Sb.AppendLine("            }");
        Sb.AppendLine("        }");
        Sb.AppendLine("    }");
        Sb.AppendLine();

        Sb.AppendLine("    public void Dispose()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        if (!Disposed)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            Client.Dispose();");
        Sb.AppendLine("            Disposed = true;");
        Sb.AppendLine("        }");
        Sb.AppendLine("    }");
        Sb.AppendLine("}");

        File.WriteAllText(
            Path.Combine(OutputDir, AnthropicConstants.GeneratedServicesDirectory, AnthropicConstants.GeneratedApiClientFileName),
            Sb.ToString());
    }

    private void WriteToolDispatcher()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("using System.Diagnostics;");
        Sb.AppendLine("using System.Globalization;");
        Sb.AppendLine("using System.Text;");
        Sb.AppendLine("using System.Text.Json;");
        Sb.AppendLine("using System.Text.RegularExpressions;");
        Sb.Append("using ").Append(Namespace).Append('.').Append(AnthropicConstants.GeneratedModelsDirectory).AppendLine(";");
        Sb.AppendLine();
        Sb.Append("namespace ").Append(Namespace).Append('.').Append(AnthropicConstants.GeneratedServicesDirectory).AppendLine(";");
        Sb.AppendLine();

        Sb.AppendLine("internal sealed class ToolDispatcher");
        Sb.AppendLine("{");
        Sb.AppendLine("    private readonly Dictionary<string, Func<JsonElement, CancellationToken, Task<string>>> Handlers;");
        Sb.AppendLine("    private readonly HttpClient HttpClient;");
        Sb.AppendLine("    private readonly Dictionary<string, string> BackgroundTaskOutputs;");
        Sb.AppendLine("    private readonly List<JsonElement> TodoList;");
        Sb.AppendLine("    private string WorkingDirectory;");
        Sb.AppendLine();
        Sb.AppendLine("    internal ToolDispatcher()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        HttpClient = new HttpClient();");
        Sb.AppendLine("        BackgroundTaskOutputs = new Dictionary<string, string>(StringComparer.Ordinal);");
        Sb.AppendLine("        TodoList = new List<JsonElement>();");
        Sb.AppendLine("        WorkingDirectory = Environment.CurrentDirectory;");
        Sb.AppendLine("        Handlers = new Dictionary<string, Func<JsonElement, CancellationToken, Task<string>>>(StringComparer.Ordinal)");
        Sb.AppendLine("        {");

        foreach (var ToolName in AnthropicConstants.AllToolNames)
        {
            Sb.Append("            [\"").Append(ToolName).Append("\"] = Handle").Append(ToolName).AppendLine("Async,");
        }

        Sb.AppendLine("        };");
        Sb.AppendLine("    }");
        Sb.AppendLine();

        Sb.AppendLine("    internal async Task<ApiContentBlock> DispatchAsync(ApiContentBlock ToolUse, CancellationToken Ct = default)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        var ToolName = ToolUse.Name ?? string.Empty;");
        Sb.AppendLine("        var ToolInput = ToolUse.Input ?? default;");
        Sb.AppendLine("        var ToolId = ToolUse.Id ?? string.Empty;");
        Sb.AppendLine();
        Sb.AppendLine("        string ResultContent;");
        Sb.AppendLine("        var IsError = false;");
        Sb.AppendLine();
        Sb.AppendLine("        if (Handlers.TryGetValue(ToolName, out var Handler))");
        Sb.AppendLine("        {");
        Sb.AppendLine("            try");
        Sb.AppendLine("            {");
        Sb.AppendLine("                ResultContent = await Handler(ToolInput, Ct).ConfigureAwait(false);");
        Sb.AppendLine("            }");
        Sb.AppendLine("            catch (Exception Ex)");
        Sb.AppendLine("            {");
        Sb.AppendLine("                ResultContent = Ex.Message;");
        Sb.AppendLine("                IsError = true;");
        Sb.AppendLine("            }");
        Sb.AppendLine("        }");
        Sb.AppendLine("        else");
        Sb.AppendLine("        {");
        Sb.AppendLine("            ResultContent = string.Format(CultureInfo.InvariantCulture, \"Unknown tool: {0}\", ToolName);");
        Sb.AppendLine("            IsError = true;");
        Sb.AppendLine("        }");
        Sb.AppendLine();
        Sb.AppendLine("        return new ApiContentBlock");
        Sb.AppendLine("        {");
        Sb.Append("            Type = \"").Append(AnthropicConstants.ContentTypeToolResult).AppendLine("\",");
        Sb.AppendLine("            ToolUseId = ToolId,");
        Sb.AppendLine("            Text = ResultContent,");
        Sb.AppendLine("            IsError = IsError,");
        Sb.AppendLine("        };");
        Sb.AppendLine("    }");
        Sb.AppendLine();

        EmitGetString(Sb);
        EmitGetInt(Sb);
        EmitGetBool(Sb);
        EmitBashHandler(Sb);
        EmitFileReadHandler(Sb);
        EmitFileWriteHandler(Sb);
        EmitFileEditHandler(Sb);
        EmitGlobHandler(Sb);
        EmitGrepHandler(Sb);
        EmitWebFetchHandler(Sb);
        EmitWebSearchHandler(Sb);
        EmitNotebookEditHandler(Sb);
        EmitTodoWriteHandler(Sb);
        EmitTaskOutputHandler(Sb);
        EmitAskUserQuestionHandler(Sb);
        EmitAgentHandler(Sb);
        EmitExitPlanModeHandler(Sb);
        EmitTaskStopHandler(Sb);
        EmitMcpStubHandlers(Sb);
        EmitConfigHandler(Sb);
        EmitWorktreeHandlers(Sb);

        Sb.AppendLine("}");

        File.WriteAllText(
            Path.Combine(OutputDir, AnthropicConstants.GeneratedServicesDirectory, AnthropicConstants.GeneratedToolDispatcherFileName),
            Sb.ToString());
    }

    private static void EmitGetString(StringBuilder Sb)
    {
        Sb.AppendLine("    private static string GetString(JsonElement Input, string PropertyName, string DefaultValue = \"\")");
        Sb.AppendLine("    {");
        Sb.AppendLine("        if (Input.ValueKind == JsonValueKind.Object && Input.TryGetProperty(PropertyName, out var Prop) && Prop.ValueKind == JsonValueKind.String)");
        Sb.AppendLine("            return Prop.GetString() ?? DefaultValue;");
        Sb.AppendLine("        return DefaultValue;");
        Sb.AppendLine("    }");
        Sb.AppendLine();
    }

    private static void EmitGetInt(StringBuilder Sb)
    {
        Sb.AppendLine("    private static int GetInt(JsonElement Input, string PropertyName, int DefaultValue = 0)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        if (Input.ValueKind == JsonValueKind.Object && Input.TryGetProperty(PropertyName, out var Prop) && Prop.ValueKind == JsonValueKind.Number)");
        Sb.AppendLine("            return Prop.GetInt32();");
        Sb.AppendLine("        return DefaultValue;");
        Sb.AppendLine("    }");
        Sb.AppendLine();
    }

    private static void EmitGetBool(StringBuilder Sb)
    {
        Sb.AppendLine("    private static bool GetBool(JsonElement Input, string PropertyName, bool DefaultValue = false)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        if (Input.ValueKind == JsonValueKind.Object && Input.TryGetProperty(PropertyName, out var Prop))");
        Sb.AppendLine("        {");
        Sb.AppendLine("            if (Prop.ValueKind == JsonValueKind.True) return true;");
        Sb.AppendLine("            if (Prop.ValueKind == JsonValueKind.False) return false;");
        Sb.AppendLine("        }");
        Sb.AppendLine("        return DefaultValue;");
        Sb.AppendLine("    }");
        Sb.AppendLine();
    }

    private static void EmitBashHandler(StringBuilder Sb)
    {
        Sb.Append("    private async Task<string> Handle").Append(AnthropicConstants.ToolNameBash).AppendLine("Async(JsonElement Input, CancellationToken Ct)");
        Sb.AppendLine("    {");
        Sb.Append("        var Command = GetString(Input, \"").Append(AnthropicConstants.ToolInputCommand).AppendLine("\");");
        Sb.AppendLine("        if (Command.Length == 0)");
        Sb.AppendLine("            return \"No command provided\";");
        Sb.AppendLine();
        Sb.Append("        var TimeoutMs = GetInt(Input, \"").Append(AnthropicConstants.ToolInputTimeout).Append("\", ").Append(AnthropicConstants.ToolBashDefaultTimeoutMs).AppendLine(");");
        Sb.Append("        if (TimeoutMs > ").Append(AnthropicConstants.ToolBashMaxTimeoutMs).AppendLine(")");
        Sb.Append("            TimeoutMs = ").Append(AnthropicConstants.ToolBashMaxTimeoutMs).AppendLine(";");
        Sb.Append("        var RunInBackground = GetBool(Input, \"").Append(AnthropicConstants.ToolInputRunInBackground).AppendLine("\");");
        Sb.AppendLine();
        Sb.AppendLine("        var IsWindows = OperatingSystem.IsWindows();");
        Sb.Append("        var ShellPath = IsWindows ? \"").Append(AnthropicConstants.ToolBashPowershellPath).Append("\" : \"").Append(AnthropicConstants.ToolBashShellPath).AppendLine("\";");
        Sb.Append("        var ShellArg = IsWindows ? \"").Append(AnthropicConstants.ToolBashPowershellArg).Append("\" : \"").Append(AnthropicConstants.ToolBashShellArg).AppendLine("\";");
        Sb.AppendLine();
        Sb.AppendLine("        var Psi = new ProcessStartInfo");
        Sb.AppendLine("        {");
        Sb.AppendLine("            FileName = ShellPath,");
        Sb.AppendLine("            Arguments = string.Concat(ShellArg, \" \", Command),");
        Sb.AppendLine("            RedirectStandardOutput = true,");
        Sb.AppendLine("            RedirectStandardError = true,");
        Sb.AppendLine("            UseShellExecute = false,");
        Sb.AppendLine("            CreateNoWindow = true,");
        Sb.AppendLine("            WorkingDirectory = WorkingDirectory,");
        Sb.AppendLine("        };");
        Sb.AppendLine();
        Sb.AppendLine("        using var Proc = new Process { StartInfo = Psi };");
        Sb.AppendLine("        Proc.Start();");
        Sb.AppendLine();
        Sb.AppendLine("        if (RunInBackground)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            var TaskId = Guid.NewGuid().ToString(\"N\").Substring(0, 8);");
        Sb.AppendLine("            _ = Task.Run(async () =>");
        Sb.AppendLine("            {");
        Sb.AppendLine("                var Stdout = await Proc.StandardOutput.ReadToEndAsync().ConfigureAwait(false);");
        Sb.AppendLine("                var Stderr = await Proc.StandardError.ReadToEndAsync().ConfigureAwait(false);");
        Sb.AppendLine("                await Proc.WaitForExitAsync().ConfigureAwait(false);");
        Sb.AppendLine("                var ResultSb = new StringBuilder();");
        Sb.AppendLine("                if (Stdout.Length > 0) ResultSb.AppendLine(Stdout);");
        Sb.AppendLine("                if (Stderr.Length > 0) ResultSb.Append(\"STDERR: \").AppendLine(Stderr);");
        Sb.AppendLine("                ResultSb.Append(\"Exit code: \").Append(Proc.ExitCode);");
        Sb.AppendLine("                lock (BackgroundTaskOutputs)");
        Sb.AppendLine("                {");
        Sb.AppendLine("                    BackgroundTaskOutputs[TaskId] = ResultSb.ToString();");
        Sb.AppendLine("                }");
        Sb.AppendLine("            });");
        Sb.AppendLine("            return string.Concat(\"Background task started with id: \", TaskId);");
        Sb.AppendLine("        }");
        Sb.AppendLine();
        Sb.AppendLine("        using var Cts = CancellationTokenSource.CreateLinkedTokenSource(Ct);");
        Sb.AppendLine("        Cts.CancelAfter(TimeoutMs);");
        Sb.AppendLine();
        Sb.AppendLine("        var StdoutTask = Proc.StandardOutput.ReadToEndAsync(Cts.Token);");
        Sb.AppendLine("        var StderrTask = Proc.StandardError.ReadToEndAsync(Cts.Token);");
        Sb.AppendLine();
        Sb.AppendLine("        try");
        Sb.AppendLine("        {");
        Sb.AppendLine("            await Proc.WaitForExitAsync(Cts.Token).ConfigureAwait(false);");
        Sb.AppendLine("        }");
        Sb.AppendLine("        catch (OperationCanceledException)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            try { Proc.Kill(true); } catch { }");
        Sb.AppendLine("        }");
        Sb.AppendLine();
        Sb.AppendLine("        var StdoutResult = await StdoutTask.ConfigureAwait(false);");
        Sb.AppendLine("        var StderrResult = await StderrTask.ConfigureAwait(false);");
        Sb.AppendLine();
        Sb.AppendLine("        var OutputSb = new StringBuilder();");
        Sb.AppendLine("        if (StdoutResult.Length > 0)");
        Sb.AppendLine("            OutputSb.AppendLine(StdoutResult);");
        Sb.AppendLine("        if (StderrResult.Length > 0)");
        Sb.AppendLine("            OutputSb.Append(\"STDERR: \").AppendLine(StderrResult);");
        Sb.AppendLine("        if (Proc.HasExited)");
        Sb.AppendLine("            OutputSb.Append(\"Exit code: \").Append(Proc.ExitCode);");
        Sb.AppendLine("        else");
        Sb.AppendLine("            OutputSb.Append(\"Process timed out and was killed\");");
        Sb.AppendLine();
        Sb.AppendLine("        return OutputSb.ToString();");
        Sb.AppendLine("    }");
        Sb.AppendLine();
    }

    private static void EmitFileReadHandler(StringBuilder Sb)
    {
        Sb.Append("    private static Task<string> Handle").Append(AnthropicConstants.ToolNameFileRead).AppendLine("Async(JsonElement Input, CancellationToken Ct)");
        Sb.AppendLine("    {");
        Sb.Append("        var FilePath = GetString(Input, \"").Append(AnthropicConstants.ToolInputFilePath).AppendLine("\");");
        Sb.AppendLine("        if (!File.Exists(FilePath))");
        Sb.Append("            return Task.FromResult(string.Format(CultureInfo.InvariantCulture, \"").Append(AnthropicConstants.ToolFileNotFoundFormat).AppendLine("\", FilePath));");
        Sb.AppendLine();
        Sb.Append("        var Offset = GetInt(Input, \"").Append(AnthropicConstants.ToolInputOffset).AppendLine("\", 0);");
        Sb.Append("        var Limit = GetInt(Input, \"").Append(AnthropicConstants.ToolInputLimit).Append("\", ").Append(AnthropicConstants.ToolFileReadDefaultLimit).AppendLine(");");
        Sb.AppendLine();
        Sb.AppendLine("        var AllLines = File.ReadAllLines(FilePath);");
        Sb.AppendLine("        var TotalLines = AllLines.Length;");
        Sb.AppendLine("        var StartLine = Offset > 0 ? Math.Min(Offset, TotalLines) : 0;");
        Sb.AppendLine("        var EndLine = Math.Min(StartLine + Limit, TotalLines);");
        Sb.AppendLine();
        Sb.AppendLine("        var ResultSb = new StringBuilder();");
        Sb.AppendLine("        for (var I = StartLine; I < EndLine; I++)");
        Sb.AppendLine("        {");
        Sb.Append("            ResultSb.AppendFormat(CultureInfo.InvariantCulture, \"").Append(AnthropicConstants.ToolLineNumberFormat).AppendLine("\", I + 1, AllLines[I]);");
        Sb.AppendLine("            ResultSb.AppendLine();");
        Sb.AppendLine("        }");
        Sb.AppendLine();
        Sb.AppendLine("        return Task.FromResult(ResultSb.ToString());");
        Sb.AppendLine("    }");
        Sb.AppendLine();
    }

    private static void EmitFileWriteHandler(StringBuilder Sb)
    {
        Sb.Append("    private static Task<string> Handle").Append(AnthropicConstants.ToolNameFileWrite).AppendLine("Async(JsonElement Input, CancellationToken Ct)");
        Sb.AppendLine("    {");
        Sb.Append("        var FilePath = GetString(Input, \"").Append(AnthropicConstants.ToolInputFilePath).AppendLine("\");");
        Sb.Append("        var Content = GetString(Input, \"").Append(AnthropicConstants.ToolInputContent).AppendLine("\");");
        Sb.AppendLine();
        Sb.AppendLine("        var Dir = Path.GetDirectoryName(FilePath);");
        Sb.AppendLine("        if (Dir is not null && Dir.Length > 0 && !Directory.Exists(Dir))");
        Sb.AppendLine("            Directory.CreateDirectory(Dir);");
        Sb.AppendLine();
        Sb.AppendLine("        File.WriteAllText(FilePath, Content);");
        Sb.Append("        return Task.FromResult(string.Format(CultureInfo.InvariantCulture, \"").Append(AnthropicConstants.ToolWriteSuccessFormat).AppendLine("\", FilePath));");
        Sb.AppendLine("    }");
        Sb.AppendLine();
    }

    private static void EmitFileEditHandler(StringBuilder Sb)
    {
        Sb.Append("    private static Task<string> Handle").Append(AnthropicConstants.ToolNameFileEdit).AppendLine("Async(JsonElement Input, CancellationToken Ct)");
        Sb.AppendLine("    {");
        Sb.Append("        var FilePath = GetString(Input, \"").Append(AnthropicConstants.ToolInputFilePath).AppendLine("\");");
        Sb.Append("        var OldString = GetString(Input, \"").Append(AnthropicConstants.ToolInputOldString).AppendLine("\");");
        Sb.Append("        var NewString = GetString(Input, \"").Append(AnthropicConstants.ToolInputNewString).AppendLine("\");");
        Sb.Append("        var ReplaceAll = GetBool(Input, \"").Append(AnthropicConstants.ToolInputReplaceAll).AppendLine("\");");
        Sb.AppendLine();
        Sb.AppendLine("        if (!File.Exists(FilePath))");
        Sb.Append("            return Task.FromResult(string.Format(CultureInfo.InvariantCulture, \"").Append(AnthropicConstants.ToolFileNotFoundFormat).AppendLine("\", FilePath));");
        Sb.AppendLine();
        Sb.AppendLine("        var FileContent = File.ReadAllText(FilePath);");
        Sb.AppendLine();
        Sb.AppendLine("        if (!FileContent.Contains(OldString, StringComparison.Ordinal))");
        Sb.Append("            return Task.FromResult(string.Format(CultureInfo.InvariantCulture, \"").Append(AnthropicConstants.ToolOldStringNotFoundFormat).AppendLine("\", FilePath));");
        Sb.AppendLine();
        Sb.AppendLine("        if (!ReplaceAll)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            var FirstIdx = FileContent.IndexOf(OldString, StringComparison.Ordinal);");
        Sb.AppendLine("            var SecondIdx = FileContent.IndexOf(OldString, FirstIdx + 1, StringComparison.Ordinal);");
        Sb.AppendLine("            if (SecondIdx >= 0)");
        Sb.AppendLine("            {");
        Sb.AppendLine("                var MatchCount = 1;");
        Sb.AppendLine("                var SearchIdx = SecondIdx;");
        Sb.AppendLine("                while (SearchIdx >= 0)");
        Sb.AppendLine("                {");
        Sb.AppendLine("                    MatchCount++;");
        Sb.AppendLine("                    SearchIdx = FileContent.IndexOf(OldString, SearchIdx + 1, StringComparison.Ordinal);");
        Sb.AppendLine("                }");
        Sb.Append("                return Task.FromResult(string.Format(CultureInfo.InvariantCulture, \"").Append(AnthropicConstants.ToolOldStringAmbiguousFormat).AppendLine("\", MatchCount, FilePath));");
        Sb.AppendLine("            }");
        Sb.AppendLine();
        Sb.AppendLine("            FileContent = string.Concat(");
        Sb.AppendLine("                FileContent.AsSpan(0, FirstIdx),");
        Sb.AppendLine("                NewString,");
        Sb.AppendLine("                FileContent.AsSpan(FirstIdx + OldString.Length));");
        Sb.AppendLine("        }");
        Sb.AppendLine("        else");
        Sb.AppendLine("        {");
        Sb.AppendLine("            FileContent = FileContent.Replace(OldString, NewString, StringComparison.Ordinal);");
        Sb.AppendLine("        }");
        Sb.AppendLine();
        Sb.AppendLine("        File.WriteAllText(FilePath, FileContent);");
        Sb.Append("        return Task.FromResult(string.Format(CultureInfo.InvariantCulture, \"").Append(AnthropicConstants.ToolEditSuccessFormat).AppendLine("\", FilePath));");
        Sb.AppendLine("    }");
        Sb.AppendLine();
    }

    private static void EmitGlobHandler(StringBuilder Sb)
    {
        Sb.Append("    private Task<string> Handle").Append(AnthropicConstants.ToolNameGlob).AppendLine("Async(JsonElement Input, CancellationToken Ct)");
        Sb.AppendLine("    {");
        Sb.Append("        var Pattern = GetString(Input, \"").Append(AnthropicConstants.ToolInputPattern).AppendLine("\");");
        Sb.Append("        var SearchPath = GetString(Input, \"").Append(AnthropicConstants.ToolInputPath).AppendLine("\");");
        Sb.AppendLine("        if (SearchPath.Length == 0)");
        Sb.AppendLine("            SearchPath = WorkingDirectory;");
        Sb.AppendLine();
        Sb.AppendLine("        if (!Directory.Exists(SearchPath))");
        Sb.Append("            return Task.FromResult(string.Format(CultureInfo.InvariantCulture, \"").Append(AnthropicConstants.ToolDirectoryNotFoundFormat).AppendLine("\", SearchPath));");
        Sb.AppendLine();
        Sb.AppendLine("        var FileName = Path.GetFileName(Pattern);");
        Sb.AppendLine("        var SubDir = Path.GetDirectoryName(Pattern) ?? string.Empty;");
        Sb.AppendLine("        var FullSearchPath = SubDir.Length > 0 ? Path.Combine(SearchPath, SubDir) : SearchPath;");
        Sb.AppendLine();
        Sb.AppendLine("        if (!Directory.Exists(FullSearchPath))");
        Sb.Append("            return Task.FromResult(string.Format(CultureInfo.InvariantCulture, \"").Append(AnthropicConstants.ToolDirectoryNotFoundFormat).AppendLine("\", FullSearchPath));");
        Sb.AppendLine();
        Sb.AppendLine("        var RecurseOption = Pattern.Contains(\"**\") ? System.IO.SearchOption.AllDirectories : System.IO.SearchOption.TopDirectoryOnly;");
        Sb.AppendLine("        if (FileName.Length == 0)");
        Sb.AppendLine("            FileName = \"*\";");
        Sb.AppendLine();
        Sb.AppendLine("        var Files = Directory.EnumerateFiles(FullSearchPath, FileName, RecurseOption)");
        Sb.Append("            .Take(").Append(AnthropicConstants.ToolGlobMaxResults).AppendLine(")");
        Sb.AppendLine("            .OrderByDescending(F => File.GetLastWriteTimeUtc(F))");
        Sb.AppendLine("            .ToList();");
        Sb.AppendLine();
        Sb.AppendLine("        if (Files.Count == 0)");
        Sb.AppendLine("            return Task.FromResult(\"No files matched the pattern\");");
        Sb.AppendLine();
        Sb.AppendLine("        var ResultSb = new StringBuilder();");
        Sb.AppendLine("        foreach (var F in Files)");
        Sb.AppendLine("            ResultSb.AppendLine(F);");
        Sb.AppendLine();
        Sb.Append("        if (Files.Count >= ").Append(AnthropicConstants.ToolGlobMaxResults).AppendLine(")");
        Sb.AppendLine("            ResultSb.AppendLine(\"(results truncated)\");");
        Sb.AppendLine();
        Sb.AppendLine("        return Task.FromResult(ResultSb.ToString());");
        Sb.AppendLine("    }");
        Sb.AppendLine();
    }

    private static void EmitGrepHandler(StringBuilder Sb)
    {
        Sb.Append("    private Task<string> Handle").Append(AnthropicConstants.ToolNameGrep).AppendLine("Async(JsonElement Input, CancellationToken Ct)");
        Sb.AppendLine("    {");
        Sb.Append("        var Pattern = GetString(Input, \"").Append(AnthropicConstants.ToolInputPattern).AppendLine("\");");
        Sb.Append("        var SearchPath = GetString(Input, \"").Append(AnthropicConstants.ToolInputPath).AppendLine("\");");
        Sb.Append("        var GlobFilter = GetString(Input, \"").Append(AnthropicConstants.ToolInputGlob).AppendLine("\");");
        Sb.Append("        var OutputMode = GetString(Input, \"").Append(AnthropicConstants.ToolInputOutputMode).Append("\", \"").Append(AnthropicConstants.ToolOutputModeFilesWithMatches).AppendLine("\");");
        Sb.Append("        var CaseInsensitive = GetBool(Input, \"").Append(AnthropicConstants.ToolInputCaseInsensitive).AppendLine("\");");
        Sb.Append("        var HeadLimit = GetInt(Input, \"").Append(AnthropicConstants.ToolInputHeadLimit).Append("\", ").Append(AnthropicConstants.ToolGrepDefaultHeadLimit).AppendLine(");");
        Sb.Append("        var ContextBefore = GetInt(Input, \"").Append(AnthropicConstants.ToolInputContextBefore).AppendLine("\");");
        Sb.Append("        var ContextAfter = GetInt(Input, \"").Append(AnthropicConstants.ToolInputContextAfter).AppendLine("\");");
        Sb.Append("        var ContextBoth = GetInt(Input, \"").Append(AnthropicConstants.ToolInputContext).AppendLine("\");");
        Sb.Append("        var ShowLineNumbers = GetBool(Input, \"").Append(AnthropicConstants.ToolInputLineNumbers).AppendLine("\", true);");
        Sb.Append("        var OffsetSkip = GetInt(Input, \"").Append(AnthropicConstants.ToolInputOffset).AppendLine("\");");
        Sb.AppendLine();
        Sb.AppendLine("        if (SearchPath.Length == 0)");
        Sb.AppendLine("            SearchPath = WorkingDirectory;");
        Sb.AppendLine();
        Sb.AppendLine("        if (ContextBoth > 0)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            if (ContextBefore == 0) ContextBefore = ContextBoth;");
        Sb.AppendLine("            if (ContextAfter == 0) ContextAfter = ContextBoth;");
        Sb.AppendLine("        }");
        Sb.AppendLine();
        Sb.AppendLine("        var RxOptions = System.Text.RegularExpressions.RegexOptions.Compiled;");
        Sb.AppendLine("        if (CaseInsensitive) RxOptions |= System.Text.RegularExpressions.RegexOptions.IgnoreCase;");
        Sb.AppendLine("        Regex Rx;");
        Sb.AppendLine("        try { Rx = new Regex(Pattern, RxOptions); }");
        Sb.AppendLine("        catch (Exception Ex) { return Task.FromResult(string.Concat(\"Invalid regex: \", Ex.Message)); }");
        Sb.AppendLine();
        Sb.AppendLine("        var FilesToSearch = new List<string>();");
        Sb.AppendLine("        if (File.Exists(SearchPath))");
        Sb.AppendLine("        {");
        Sb.AppendLine("            FilesToSearch.Add(SearchPath);");
        Sb.AppendLine("        }");
        Sb.AppendLine("        else if (Directory.Exists(SearchPath))");
        Sb.AppendLine("        {");
        Sb.AppendLine("            var GlobPattern = GlobFilter.Length > 0 ? GlobFilter : \"*\";");
        Sb.AppendLine("            FilesToSearch.AddRange(Directory.EnumerateFiles(SearchPath, GlobPattern, System.IO.SearchOption.AllDirectories));");
        Sb.AppendLine("        }");
        Sb.AppendLine("        else");
        Sb.AppendLine("        {");
        Sb.Append("            return Task.FromResult(string.Format(CultureInfo.InvariantCulture, \"").Append(AnthropicConstants.ToolDirectoryNotFoundFormat).AppendLine("\", SearchPath));");
        Sb.AppendLine("        }");
        Sb.AppendLine();
        Sb.AppendLine("        var ResultSb = new StringBuilder();");
        Sb.AppendLine("        var MatchedFiles = new List<string>();");
        Sb.AppendLine("        var TotalMatches = 0;");
        Sb.AppendLine("        var EntryCount = 0;");
        Sb.AppendLine();
        Sb.AppendLine("        foreach (var FilePath in FilesToSearch)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            if (HeadLimit > 0 && EntryCount >= HeadLimit + OffsetSkip)");
        Sb.AppendLine("                break;");
        Sb.AppendLine();
        Sb.AppendLine("            string[] Lines;");
        Sb.AppendLine("            try { Lines = File.ReadAllLines(FilePath); }");
        Sb.AppendLine("            catch { continue; }");
        Sb.AppendLine();
        Sb.AppendLine("            var FileHasMatch = false;");
        Sb.AppendLine("            var FileMatchCount = 0;");
        Sb.AppendLine();
        Sb.AppendLine("            for (var LineIdx = 0; LineIdx < Lines.Length; LineIdx++)");
        Sb.AppendLine("            {");
        Sb.AppendLine("                if (!Rx.IsMatch(Lines[LineIdx]))");
        Sb.AppendLine("                    continue;");
        Sb.AppendLine();
        Sb.AppendLine("                FileHasMatch = true;");
        Sb.AppendLine("                FileMatchCount++;");
        Sb.AppendLine("                TotalMatches++;");
        Sb.AppendLine();
        Sb.Append("                if (string.Equals(OutputMode, \"").Append(AnthropicConstants.ToolOutputModeContent).AppendLine("\", StringComparison.Ordinal))");
        Sb.AppendLine("                {");
        Sb.AppendLine("                    EntryCount++;");
        Sb.AppendLine("                    if (EntryCount <= OffsetSkip) continue;");
        Sb.AppendLine("                    if (HeadLimit > 0 && EntryCount > OffsetSkip + HeadLimit) break;");
        Sb.AppendLine();
        Sb.AppendLine("                    var StartCtx = Math.Max(0, LineIdx - ContextBefore);");
        Sb.AppendLine("                    var EndCtx = Math.Min(Lines.Length - 1, LineIdx + ContextAfter);");
        Sb.AppendLine();
        Sb.AppendLine("                    for (var C = StartCtx; C <= EndCtx; C++)");
        Sb.AppendLine("                    {");
        Sb.AppendLine("                        if (ShowLineNumbers)");
        Sb.AppendLine("                            ResultSb.Append(FilePath).Append(':').Append(C + 1).Append(':').AppendLine(Lines[C]);");
        Sb.AppendLine("                        else");
        Sb.AppendLine("                            ResultSb.AppendLine(Lines[C]);");
        Sb.AppendLine("                    }");
        Sb.AppendLine("                }");
        Sb.AppendLine("            }");
        Sb.AppendLine();
        Sb.AppendLine("            if (FileHasMatch)");
        Sb.AppendLine("            {");
        Sb.AppendLine("                MatchedFiles.Add(FilePath);");
        Sb.AppendLine();
        Sb.Append("                if (string.Equals(OutputMode, \"").Append(AnthropicConstants.ToolOutputModeFilesWithMatches).AppendLine("\", StringComparison.Ordinal))");
        Sb.AppendLine("                {");
        Sb.AppendLine("                    EntryCount++;");
        Sb.AppendLine("                    if (EntryCount > OffsetSkip)");
        Sb.AppendLine("                        ResultSb.AppendLine(FilePath);");
        Sb.AppendLine("                }");
        Sb.Append("                else if (string.Equals(OutputMode, \"").Append(AnthropicConstants.ToolOutputModeCount).AppendLine("\", StringComparison.Ordinal))");
        Sb.AppendLine("                {");
        Sb.AppendLine("                    EntryCount++;");
        Sb.AppendLine("                    if (EntryCount > OffsetSkip)");
        Sb.AppendLine("                        ResultSb.Append(FilePath).Append(':').AppendLine(FileMatchCount.ToString(CultureInfo.InvariantCulture));");
        Sb.AppendLine("                }");
        Sb.AppendLine("            }");
        Sb.AppendLine("        }");
        Sb.AppendLine();
        Sb.AppendLine("        if (ResultSb.Length == 0)");
        Sb.Append("            return Task.FromResult(\"").Append(AnthropicConstants.ToolGrepNoMatchesMessage).AppendLine("\");");
        Sb.AppendLine();
        Sb.AppendLine("        return Task.FromResult(ResultSb.ToString());");
        Sb.AppendLine("    }");
        Sb.AppendLine();
    }

    private static void EmitWebFetchHandler(StringBuilder Sb)
    {
        Sb.Append("    private async Task<string> Handle").Append(AnthropicConstants.ToolNameWebFetch).AppendLine("Async(JsonElement Input, CancellationToken Ct)");
        Sb.AppendLine("    {");
        Sb.Append("        var Url = GetString(Input, \"").Append(AnthropicConstants.ToolInputUrl).AppendLine("\");");
        Sb.AppendLine("        if (Url.Length == 0)");
        Sb.AppendLine("            return \"No URL provided\";");
        Sb.AppendLine();
        Sb.AppendLine("        try");
        Sb.AppendLine("        {");
        Sb.AppendLine("            using var Response = await HttpClient.GetAsync(Url, Ct).ConfigureAwait(false);");
        Sb.AppendLine("            var StatusCode = (int)Response.StatusCode;");
        Sb.AppendLine("            var Content = await Response.Content.ReadAsStringAsync(Ct).ConfigureAwait(false);");
        Sb.AppendLine();
        Sb.AppendLine("            var ResultSb = new StringBuilder();");
        Sb.AppendLine("            ResultSb.Append(\"HTTP \").Append(StatusCode).Append(' ').AppendLine(Response.ReasonPhrase ?? string.Empty);");
        Sb.AppendLine("            ResultSb.Append(\"Content-Length: \").AppendLine(Content.Length.ToString(CultureInfo.InvariantCulture));");
        Sb.AppendLine("            ResultSb.AppendLine();");
        Sb.AppendLine("            ResultSb.Append(Content);");
        Sb.AppendLine("            return ResultSb.ToString();");
        Sb.AppendLine("        }");
        Sb.AppendLine("        catch (Exception Ex)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            return string.Concat(\"Fetch failed: \", Ex.Message);");
        Sb.AppendLine("        }");
        Sb.AppendLine("    }");
        Sb.AppendLine();
    }

    private static void EmitWebSearchHandler(StringBuilder Sb)
    {
        Sb.Append("    private async Task<string> Handle").Append(AnthropicConstants.ToolNameWebSearch).AppendLine("Async(JsonElement Input, CancellationToken Ct)");
        Sb.AppendLine("    {");
        Sb.Append("        var Query = GetString(Input, \"").Append(AnthropicConstants.ToolInputQuery).AppendLine("\");");
        Sb.AppendLine("        if (Query.Length == 0)");
        Sb.AppendLine("            return \"No search query provided\";");
        Sb.AppendLine();
        Sb.AppendLine("        try");
        Sb.AppendLine("        {");
        Sb.AppendLine("            var SearchUrl = string.Concat(\"https://html.duckduckgo.com/html/?q=\", Uri.EscapeDataString(Query));");
        Sb.AppendLine("            using var Request = new HttpRequestMessage(HttpMethod.Get, SearchUrl);");
        Sb.AppendLine("            Request.Headers.Add(\"User-Agent\", \"Mozilla/5.0 (compatible; ClaudeCode/1.0)\");");
        Sb.AppendLine("            using var Response = await HttpClient.SendAsync(Request, Ct).ConfigureAwait(false);");
        Sb.AppendLine("            var Content = await Response.Content.ReadAsStringAsync(Ct).ConfigureAwait(false);");
        Sb.AppendLine("            return Content;");
        Sb.AppendLine("        }");
        Sb.AppendLine("        catch (Exception Ex)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            return string.Concat(\"Search failed: \", Ex.Message);");
        Sb.AppendLine("        }");
        Sb.AppendLine("    }");
        Sb.AppendLine();
    }

    private static void EmitNotebookEditHandler(StringBuilder Sb)
    {
        Sb.Append("    private static Task<string> Handle").Append(AnthropicConstants.ToolNameNotebookEdit).AppendLine("Async(JsonElement Input, CancellationToken Ct)");
        Sb.AppendLine("    {");
        Sb.Append("        var NotebookPath = GetString(Input, \"").Append(AnthropicConstants.ToolInputNotebookPath).AppendLine("\");");
        Sb.Append("        var CellId = GetString(Input, \"").Append(AnthropicConstants.ToolInputCellId).AppendLine("\");");
        Sb.Append("        var NewSource = GetString(Input, \"").Append(AnthropicConstants.ToolInputNewSource).AppendLine("\");");
        Sb.Append("        var CellType = GetString(Input, \"").Append(AnthropicConstants.ToolInputCellType).Append("\", \"").Append(AnthropicConstants.ToolCellTypeCode).AppendLine("\");");
        Sb.Append("        var EditMode = GetString(Input, \"").Append(AnthropicConstants.ToolInputEditMode).Append("\", \"").Append(AnthropicConstants.ToolEditModeReplace).AppendLine("\");");
        Sb.AppendLine();
        Sb.AppendLine("        if (!File.Exists(NotebookPath))");
        Sb.Append("            return Task.FromResult(string.Format(CultureInfo.InvariantCulture, \"").Append(AnthropicConstants.ToolFileNotFoundFormat).AppendLine("\", NotebookPath));");
        Sb.AppendLine();
        Sb.AppendLine("        var JsonText = File.ReadAllText(NotebookPath);");
        Sb.AppendLine("        using var Doc = JsonDocument.Parse(JsonText);");
        Sb.AppendLine("        var Root = Doc.RootElement;");
        Sb.AppendLine();
        Sb.Append("        if (!Root.TryGetProperty(\"").Append(AnthropicConstants.ToolNotebookCellsKey).AppendLine("\", out var CellsElement))");
        Sb.AppendLine("            return Task.FromResult(\"Notebook has no cells array\");");
        Sb.AppendLine();
        Sb.AppendLine("        var CellsList = new List<JsonElement>();");
        Sb.AppendLine("        foreach (var Cell in CellsElement.EnumerateArray())");
        Sb.AppendLine("            CellsList.Add(Cell);");
        Sb.AppendLine();
        Sb.AppendLine("        var TargetIdx = -1;");
        Sb.AppendLine("        if (CellId.Length > 0)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            for (var I = 0; I < CellsList.Count; I++)");
        Sb.AppendLine("            {");
        Sb.Append("                if (CellsList[I].TryGetProperty(\"").Append(AnthropicConstants.ToolNotebookMetadataKey).Append("\", out var Meta) && Meta.TryGetProperty(\"").Append(AnthropicConstants.ToolNotebookIdKey).AppendLine("\", out var IdProp))");
        Sb.AppendLine("                {");
        Sb.AppendLine("                    if (string.Equals(IdProp.GetString(), CellId, StringComparison.Ordinal))");
        Sb.AppendLine("                    {");
        Sb.AppendLine("                        TargetIdx = I;");
        Sb.AppendLine("                        break;");
        Sb.AppendLine("                    }");
        Sb.AppendLine("                }");
        Sb.AppendLine("            }");
        Sb.AppendLine("        }");
        Sb.AppendLine();
        Sb.AppendLine("        var SourceLines = NewSource.Split('\\n');");
        Sb.AppendLine("        var SourceArray = new List<string>();");
        Sb.AppendLine("        for (var I = 0; I < SourceLines.Length; I++)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            SourceArray.Add(I < SourceLines.Length - 1 ? string.Concat(SourceLines[I], \"\\n\") : SourceLines[I]);");
        Sb.AppendLine("        }");
        Sb.AppendLine();
        Sb.AppendLine("        var NewCellJson = string.Concat(");
        Sb.AppendLine("            \"{\\\"cell_type\\\": \\\"\", CellType, \"\\\", \\\"source\\\": \",");
        Sb.AppendLine("            JsonSerializer.Serialize(SourceArray),");
        Sb.AppendLine("            \", \\\"metadata\\\": {}, \\\"outputs\\\": []}\");");
        Sb.AppendLine("        var NewCellElement = JsonDocument.Parse(NewCellJson).RootElement.Clone();");
        Sb.AppendLine();
        Sb.Append("        if (string.Equals(EditMode, \"").Append(AnthropicConstants.ToolEditModeInsert).AppendLine("\", StringComparison.Ordinal))");
        Sb.AppendLine("        {");
        Sb.AppendLine("            var InsertIdx = TargetIdx >= 0 ? TargetIdx + 1 : 0;");
        Sb.AppendLine("            CellsList.Insert(InsertIdx, NewCellElement);");
        Sb.AppendLine("        }");
        Sb.Append("        else if (string.Equals(EditMode, \"").Append(AnthropicConstants.ToolEditModeDelete).AppendLine("\", StringComparison.Ordinal))");
        Sb.AppendLine("        {");
        Sb.AppendLine("            if (TargetIdx >= 0)");
        Sb.AppendLine("                CellsList.RemoveAt(TargetIdx);");
        Sb.AppendLine("            else");
        Sb.AppendLine("                return Task.FromResult(\"Cell not found for deletion\");");
        Sb.AppendLine("        }");
        Sb.AppendLine("        else");
        Sb.AppendLine("        {");
        Sb.AppendLine("            if (TargetIdx >= 0)");
        Sb.AppendLine("                CellsList[TargetIdx] = NewCellElement;");
        Sb.AppendLine("            else if (CellsList.Count > 0)");
        Sb.AppendLine("                CellsList[CellsList.Count - 1] = NewCellElement;");
        Sb.AppendLine("            else");
        Sb.AppendLine("                CellsList.Add(NewCellElement);");
        Sb.AppendLine("        }");
        Sb.AppendLine();
        Sb.AppendLine("        var OutputJson = new StringBuilder();");
        Sb.AppendLine("        OutputJson.Append('{');");
        Sb.AppendLine("        var First = true;");
        Sb.AppendLine("        foreach (var Prop in Root.EnumerateObject())");
        Sb.AppendLine("        {");
        Sb.AppendLine("            if (!First) OutputJson.Append(',');");
        Sb.AppendLine("            First = false;");
        Sb.Append("            if (string.Equals(Prop.Name, \"").Append(AnthropicConstants.ToolNotebookCellsKey).AppendLine("\", StringComparison.Ordinal))");
        Sb.AppendLine("            {");
        Sb.AppendLine("                OutputJson.Append(\"\\\"cells\\\": \");");
        Sb.AppendLine("                OutputJson.Append(JsonSerializer.Serialize(CellsList));");
        Sb.AppendLine("            }");
        Sb.AppendLine("            else");
        Sb.AppendLine("            {");
        Sb.AppendLine("                OutputJson.Append('\"').Append(Prop.Name).Append(\"\\\": \");");
        Sb.AppendLine("                OutputJson.Append(Prop.Value.GetRawText());");
        Sb.AppendLine("            }");
        Sb.AppendLine("        }");
        Sb.AppendLine("        OutputJson.Append('}');");
        Sb.AppendLine();
        Sb.AppendLine("        File.WriteAllText(NotebookPath, OutputJson.ToString());");
        Sb.AppendLine("        return Task.FromResult(string.Concat(\"Notebook edited: \", NotebookPath));");
        Sb.AppendLine("    }");
        Sb.AppendLine();
    }

    private static void EmitTodoWriteHandler(StringBuilder Sb)
    {
        Sb.Append("    private Task<string> Handle").Append(AnthropicConstants.ToolNameTodoWrite).AppendLine("Async(JsonElement Input, CancellationToken Ct)");
        Sb.AppendLine("    {");
        Sb.Append("        if (Input.ValueKind == JsonValueKind.Object && Input.TryGetProperty(\"").Append(AnthropicConstants.ToolInputTodos).AppendLine("\", out var TodosElement))");
        Sb.AppendLine("        {");
        Sb.AppendLine("            TodoList.Clear();");
        Sb.AppendLine("            foreach (var Todo in TodosElement.EnumerateArray())");
        Sb.AppendLine("                TodoList.Add(Todo.Clone());");
        Sb.AppendLine("        }");
        Sb.AppendLine();
        Sb.Append("        var StoragePath = Path.Combine(WorkingDirectory, \"").Append(AnthropicConstants.ToolTodoStorageFileName).AppendLine("\");");
        Sb.AppendLine("        File.WriteAllText(StoragePath, JsonSerializer.Serialize(TodoList));");
        Sb.AppendLine();
        Sb.AppendLine("        return Task.FromResult(string.Concat(\"Todos updated: \", TodoList.Count.ToString(CultureInfo.InvariantCulture), \" items\"));");
        Sb.AppendLine("    }");
        Sb.AppendLine();
    }

    private static void EmitTaskOutputHandler(StringBuilder Sb)
    {
        Sb.Append("    private Task<string> Handle").Append(AnthropicConstants.ToolNameTaskOutput).AppendLine("Async(JsonElement Input, CancellationToken Ct)");
        Sb.AppendLine("    {");
        Sb.Append("        var TaskId = GetString(Input, \"").Append(AnthropicConstants.ToolInputTaskId).AppendLine("\");");
        Sb.AppendLine();
        Sb.AppendLine("        string? Output;");
        Sb.AppendLine("        lock (BackgroundTaskOutputs)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            BackgroundTaskOutputs.TryGetValue(TaskId, out Output);");
        Sb.AppendLine("        }");
        Sb.AppendLine();
        Sb.AppendLine("        if (Output is not null)");
        Sb.AppendLine("            return Task.FromResult(Output);");
        Sb.AppendLine();
        Sb.Append("        return Task.FromResult(string.Format(CultureInfo.InvariantCulture, \"").Append(AnthropicConstants.ToolTaskOutputNotFoundFormat).AppendLine("\", TaskId));");
        Sb.AppendLine("    }");
        Sb.AppendLine();
    }

    private static void EmitAskUserQuestionHandler(StringBuilder Sb)
    {
        Sb.Append("    private static Task<string> Handle").Append(AnthropicConstants.ToolNameAskUserQuestion).AppendLine("Async(JsonElement Input, CancellationToken Ct)");
        Sb.AppendLine("    {");
        Sb.Append("        if (Input.ValueKind == JsonValueKind.Object && Input.TryGetProperty(\"").Append(AnthropicConstants.ToolInputQuestions).AppendLine("\", out var QuestionsElement))");
        Sb.AppendLine("        {");
        Sb.AppendLine("            var ResultSb = new StringBuilder();");
        Sb.AppendLine("            foreach (var Q in QuestionsElement.EnumerateArray())");
        Sb.AppendLine("            {");
        Sb.AppendLine("                if (Q.TryGetProperty(\"question\", out var QuestionProp))");
        Sb.AppendLine("                    ResultSb.AppendLine(QuestionProp.GetString() ?? string.Empty);");
        Sb.AppendLine("            }");
        Sb.AppendLine("            return Task.FromResult(ResultSb.ToString());");
        Sb.AppendLine("        }");
        Sb.AppendLine();
        Sb.AppendLine("        return Task.FromResult(\"No questions provided\");");
        Sb.AppendLine("    }");
        Sb.AppendLine();
    }

    private static void EmitAgentHandler(StringBuilder Sb)
    {
        Sb.Append("    private static Task<string> Handle").Append(AnthropicConstants.ToolNameAgent).AppendLine("Async(JsonElement Input, CancellationToken Ct)");
        Sb.AppendLine("    {");
        Sb.Append("        var Prompt = GetString(Input, \"").Append(AnthropicConstants.ToolInputPrompt).AppendLine("\");");
        Sb.Append("        var Description = GetString(Input, \"").Append(AnthropicConstants.ToolInputDescription).AppendLine("\");");
        Sb.AppendLine("        return Task.FromResult(string.Concat(\"Agent sub-task acknowledged: \", Description, \" - \", Prompt));");
        Sb.AppendLine("    }");
        Sb.AppendLine();
    }

    private static void EmitExitPlanModeHandler(StringBuilder Sb)
    {
        Sb.Append("    private static Task<string> Handle").Append(AnthropicConstants.ToolNameExitPlanMode).AppendLine("Async(JsonElement Input, CancellationToken Ct)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        return Task.FromResult(\"Plan mode exited\");");
        Sb.AppendLine("    }");
        Sb.AppendLine();
    }

    private static void EmitTaskStopHandler(StringBuilder Sb)
    {
        Sb.Append("    private Task<string> Handle").Append(AnthropicConstants.ToolNameTaskStop).AppendLine("Async(JsonElement Input, CancellationToken Ct)");
        Sb.AppendLine("    {");
        Sb.Append("        var TaskId = GetString(Input, \"").Append(AnthropicConstants.ToolInputTaskId).AppendLine("\");");
        Sb.AppendLine("        return Task.FromResult(string.Concat(\"Task stopped: \", TaskId));");
        Sb.AppendLine("    }");
        Sb.AppendLine();
    }

    private static void EmitMcpStubHandlers(StringBuilder Sb)
    {
        var McpTools = new[]
        {
            AnthropicConstants.ToolNameListMcpResources,
            AnthropicConstants.ToolNameMcp,
            AnthropicConstants.ToolNameReadMcpResource,
            AnthropicConstants.ToolNameSubscribeMcpResource,
            AnthropicConstants.ToolNameUnsubscribeMcpResource,
            AnthropicConstants.ToolNameSubscribePolling,
            AnthropicConstants.ToolNameUnsubscribePolling,
        };

        foreach (var ToolName in McpTools)
        {
            Sb.Append("    private static Task<string> Handle").Append(ToolName).AppendLine("Async(JsonElement Input, CancellationToken Ct)");
            Sb.AppendLine("    {");
            Sb.Append("        return Task.FromResult(string.Format(CultureInfo.InvariantCulture, \"").Append(AnthropicConstants.ToolNotImplementedFormat).Append("\", \"").Append(ToolName).AppendLine("\"));");
            Sb.AppendLine("    }");
            Sb.AppendLine();
        }
    }

    private static void EmitConfigHandler(StringBuilder Sb)
    {
        Sb.Append("    private static Task<string> Handle").Append(AnthropicConstants.ToolNameConfig).AppendLine("Async(JsonElement Input, CancellationToken Ct)");
        Sb.AppendLine("    {");
        Sb.Append("        var Setting = GetString(Input, \"").Append(AnthropicConstants.ToolInputSetting).AppendLine("\");");
        Sb.AppendLine("        return Task.FromResult(string.Concat(\"Config: \", Setting));");
        Sb.AppendLine("    }");
        Sb.AppendLine();
    }

    private static void EmitWorktreeHandlers(StringBuilder Sb)
    {
        Sb.Append("    private static Task<string> Handle").Append(AnthropicConstants.ToolNameEnterWorktree).AppendLine("Async(JsonElement Input, CancellationToken Ct)");
        Sb.AppendLine("    {");
        Sb.Append("        return Task.FromResult(string.Format(CultureInfo.InvariantCulture, \"").Append(AnthropicConstants.ToolNotImplementedFormat).Append("\", \"").Append(AnthropicConstants.ToolNameEnterWorktree).AppendLine("\"));");
        Sb.AppendLine("    }");
        Sb.AppendLine();

        Sb.Append("    private static Task<string> Handle").Append(AnthropicConstants.ToolNameExitWorktree).AppendLine("Async(JsonElement Input, CancellationToken Ct)");
        Sb.AppendLine("    {");
        Sb.Append("        return Task.FromResult(string.Format(CultureInfo.InvariantCulture, \"").Append(AnthropicConstants.ToolNotImplementedFormat).Append("\", \"").Append(AnthropicConstants.ToolNameExitWorktree).AppendLine("\"));");
        Sb.AppendLine("    }");
        Sb.AppendLine();
    }
}
