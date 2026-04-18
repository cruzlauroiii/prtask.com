namespace PrTask.Domain.Constants;
public static class AnthropicConstants
{
    public const string ApiBaseUrl = "https://api.anthropic.com";
    public const string MessagesEndpoint = "/v1/messages";
    public const string MessagesUrl = ApiBaseUrl + MessagesEndpoint;
    public const string ApiUrlWithBeta = MessagesUrl + "?beta=true";
    public const string ApiKeyHeaderName = "x-api-key";
    public const string ApiVersionHeaderName = "anthropic-version";
    public const string ApiVersionValue = "2023-06-01";
    public const string DangerouslyAllowBrowserHeaderName = "anthropic-dangerous-direct-browser-access";
    public const string DangerouslyAllowBrowserHeaderValue = "true";
    public const string ContentTypeJson = "application/json";
    public const string AcceptHeaderValue = "text/event-stream";
    public const string AcceptJsonValue = "application/json";
    public const string FullBetaValue = "oauth-2025-04-20,interleaved-thinking-2025-05-14,redact-thinking-2026-02-12,context-management-2025-06-27,prompt-caching-scope-2026-01-05,advanced-tool-use-2025-11-20,effort-2025-11-24";
    public const string UserAgentValue = "claude-cli/2.1.81 (external, cli)";
    public const string XAppHeaderName = "x-app";
    public const string XAppValue = "cli";
    public const string StreamParameterName = "stream";
    public const string ModelParameterName = "model";
    public const string MaxTokensParameterName = "max_tokens";
    public const string MessagesParameterName = "messages";
    public const string SystemParameterName = "system";
    public const string ToolsParameterName = "tools";
    public const string ToolChoiceParameterName = "tool_choice";

    public const string ModelClaude4Opus = "claude-opus-4-20250514";
    public const string ModelClaude4Opus6 = "claude-opus-4-6";
    public const string ModelClaude4Sonnet = "claude-sonnet-4-20250514";
    public const string ModelClaude35Haiku = "claude-3-5-haiku-20241022";
    public const string DefaultModel = ModelClaude4Opus6;

    public const int DefaultMaxTokens = 16384;
    public const int MaxMaxTokens = 128000;
    public const int DefaultTimeoutMs = 120000;
    public const int StreamReadBufferSize = 8192;

    public const string RoleUser = "user";
    public const string RoleAssistant = "assistant";

    public const string ContentTypeText = "text";
    public const string ContentTypeImage = "image";
    public const string ContentTypeToolUse = "tool_use";
    public const string ContentTypeToolResult = "tool_result";

    public const string SseEventPrefix = "event: ";
    public const string SseDataPrefix = "data: ";
    public const string SseEventMessageStart = "message_start";
    public const string SseEventContentBlockStart = "content_block_start";
    public const string SseEventContentBlockDelta = "content_block_delta";
    public const string SseEventContentBlockStop = "content_block_stop";
    public const string SseEventMessageDelta = "message_delta";
    public const string SseEventMessageStop = "message_stop";
    public const string SseEventPing = "ping";
    public const string SseEventError = "error";

    public const string DeltaTypeTextDelta = "text_delta";
    public const string DeltaTypeInputJsonDelta = "input_json_delta";

    public const string StopReasonEndTurn = "end_turn";
    public const string StopReasonToolUse = "tool_use";
    public const string StopReasonMaxTokens = "max_tokens";
    public const string StopReasonStopSequence = "stop_sequence";

    public const string ToolNameAgent = "Agent";
    public const string ToolNameBash = "Bash";
    public const string ToolNameTaskOutput = "TaskOutput";
    public const string ToolNameExitPlanMode = "ExitPlanMode";
    public const string ToolNameFileEdit = "FileEdit";
    public const string ToolNameFileRead = "FileRead";
    public const string ToolNameFileWrite = "FileWrite";
    public const string ToolNameGlob = "Glob";
    public const string ToolNameGrep = "Grep";
    public const string ToolNameTaskStop = "TaskStop";
    public const string ToolNameListMcpResources = "ListMcpResources";
    public const string ToolNameMcp = "Mcp";
    public const string ToolNameNotebookEdit = "NotebookEdit";
    public const string ToolNameReadMcpResource = "ReadMcpResource";
    public const string ToolNameSubscribeMcpResource = "SubscribeMcpResource";
    public const string ToolNameUnsubscribeMcpResource = "UnsubscribeMcpResource";
    public const string ToolNameSubscribePolling = "SubscribePolling";
    public const string ToolNameUnsubscribePolling = "UnsubscribePolling";
    public const string ToolNameTodoWrite = "TodoWrite";
    public const string ToolNameWebFetch = "WebFetch";
    public const string ToolNameWebSearch = "WebSearch";
    public const string ToolNameAskUserQuestion = "AskUserQuestion";
    public const string ToolNameConfig = "Config";
    public const string ToolNameEnterWorktree = "EnterWorktree";
    public const string ToolNameExitWorktree = "ExitWorktree";
    public const int ToolCount = 25;

    public static readonly string[] AllToolNames =
    [
        ToolNameAgent,
        ToolNameBash,
        ToolNameTaskOutput,
        ToolNameExitPlanMode,
        ToolNameFileEdit,
        ToolNameFileRead,
        ToolNameFileWrite,
        ToolNameGlob,
        ToolNameGrep,
        ToolNameTaskStop,
        ToolNameListMcpResources,
        ToolNameMcp,
        ToolNameNotebookEdit,
        ToolNameReadMcpResource,
        ToolNameSubscribeMcpResource,
        ToolNameUnsubscribeMcpResource,
        ToolNameSubscribePolling,
        ToolNameUnsubscribePolling,
        ToolNameTodoWrite,
        ToolNameWebFetch,
        ToolNameWebSearch,
        ToolNameAskUserQuestion,
        ToolNameConfig,
        ToolNameEnterWorktree,
        ToolNameExitWorktree,
    ];

    public const string ToolSchemaTypeObject = "object";
    public const string ToolSchemaTypeString = "string";
    public const string ToolSchemaTypeNumber = "number";
    public const string ToolSchemaTypeBoolean = "boolean";
    public const string ToolSchemaTypeInteger = "integer";
    public const string ToolSchemaTypeArray = "array";

    public const string JsonPropertyType = "type";
    public const string JsonPropertyContent = "content";
    public const string JsonPropertyRole = "role";
    public const string JsonPropertyText = "text";
    public const string JsonPropertyId = "id";
    public const string JsonPropertyName = "name";
    public const string JsonPropertyInput = "input";
    public const string JsonPropertyToolUseId = "tool_use_id";
    public const string JsonPropertyIsError = "is_error";
    public const string JsonPropertyDelta = "delta";
    public const string JsonPropertyIndex = "index";
    public const string JsonPropertyMessage = "message";
    public const string JsonPropertyStopReason = "stop_reason";
    public const string JsonPropertyUsage = "usage";
    public const string JsonPropertyInputTokens = "input_tokens";
    public const string JsonPropertyOutputTokens = "output_tokens";
    public const string JsonPropertyCacheCreationInputTokens = "cache_creation_input_tokens";
    public const string JsonPropertyCacheReadInputTokens = "cache_read_input_tokens";
    public const string JsonPropertyPartialJson = "partial_json";
    public const string JsonPropertyDescription = "description";
    public const string JsonPropertyInputSchema = "input_schema";
    public const string JsonPropertyProperties = "properties";
    public const string JsonPropertyRequired = "required";
    public const string JsonPropertyItems = "items";
    public const string JsonPropertyEnum = "enum";

    public const string GeneratedProjectName = "PrTask.ClaudeCode";
    public const string GeneratedNamespace = "PrTask.ClaudeCode";
    public const string GeneratedAppTitle = "Claude Code";
    public const string GeneratedProjectSdk = "Microsoft.NET.Sdk.BlazorWebAssembly";
    public const string GeneratedTargetFramework = "net11.0";
    public const string GeneratedWasmPackageId = "Microsoft.AspNetCore.Components.WebAssembly";
    public const string GeneratedWasmPackageVersion = "11.0.0-preview.2.26159.112";
    public const string GeneratedDevServerPackageId = "Microsoft.AspNetCore.Components.WebAssembly.DevServer";
    public const string GeneratedDevServerPackageVersion = "11.0.0-preview.2.26159.112";
    public const string GeneratedFaviconFileName = "favicon.ico";
    public const string GeneratedFaviconLinkTag = "    <link rel=\"icon\" href=\"favicon.ico\" />";
    public const string GeneratedFaviconBase64 = "iVBORw0KGgoAAAANSUhEUgAAAMAAAADACAYAAABS3GwHAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAT7SURBVHhe7dNBjiRFEAXRuQbDGYArcDRuDmKHTMx0pIdHpWd++9LrXXtlLOzbr7/+8ecvv/z2l5To279/vn///W8pkQEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEomgEo2qgATo2/M90d4zekiAigY/zWk54yfvcTGcDF8ZtPeOL4hqcwgOL47Z2ePL5lOgPYHN/Q4Q3jm6YygIbxHbveMr5rIgNoGt+y403j26YxgMbxPVVvG983iQE0j2+qeOP4xikMoHl8U8UbxzdOYQAHxndd9dbxnRMYwIHxXVe9dXznBK8IgHeuOjH+xhXV8U6H7vH+3QwAusa7V1THO906xpt3M4Af6BhvrqqOd07YHe/dzQB+Yne8t6o63jlld7x3JwP4ws54a1V1vHPSznjrTgbwhZ3x1qrqeOeknfHWnQxgQXW8s6o63jlpZ7x1JwNYUB3vrKqOd06rjnfuZAALquOdVdXxzmnV8c6dDGBBdbyzqjreOa063rmTASyojndWVcc7p1XHO3cygAXV8c6q6njnpJ3x1p0MYEF1vLOqOt45qTreuZsBfGFnvLWqOt45ZWe8dTcD+MLOeGtVdbxzys54624G8BO7471V1fHOCbvjvbsZwA90jDdXVcc7nTrGmxMYwP/oGG9eUR3vrPrU+LsTGMB/dI63r3jj+MYpIgM4Pf7eVW8b3zfJKwKYNr7rqreN75vEAJrHN1W8ZXzXRAbQPL6p4g3jm6YygMbxPVVPH98zmQE0jW/Z8dTxHU9gAA3jO3Y9afz2pzGAzfENHaaP3/tkBrAxfn+XyeO3Pp0BFMbv7lbd7v+vjt/7ZAawOH7rSdXxzo90jXefyAB+Mn7fp1THO1/pGG8+zSsC4J2nq453VnSMN5/EAAaqjndWdYw3n8IABqqOd67oGG8+gQEMVB3vXNUx3pzOAAaqjneu6hrvTmYAA1XHOxUd483JDGCg6ninqmO8OZUBDFQd71R1jXcnMoCBquOdHR3jzYkMYKDqeGdXx3hzGgMYqDre2dU13p3EAAaqjnc6dIw3JzGAgarjnS4d480pDGCg6ninU8d4cwIDGKg63unUMd6cwAAGqo53unWMN+9mAANVxzsndIw372QAA1XHOyd0jDfvYAADVcc7p3SMN+9iAANVxzsn7Y737mIAA1XHOyd1jDfvYAADVcc7p3WMNz/NAAaqjnc+YXe892kGMFB1vPMJHePNTzKAgarjnU/pGG9+igEMVB3vfNLueO9TRgUgfZoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKJoBKNo/RnSLeW5ZbQYAAAAASUVORK5CYII=";
    public const string GeneratedRootSelector = "#app";
    public const string GeneratedApiClientFileName = "AnthropicApiClient.cs";
    public const string GeneratedToolDispatcherFileName = "ToolDispatcher.cs";
    public const string GeneratedModelsFileName = "AnthropicModels.cs";
    public const string GeneratedProgramFileName = "Program.cs";
    public const string GeneratedAppRazorFileName = "App.razor";
    public const string GeneratedImportsRazorFileName = "_Imports.razor";
    public const string GeneratedIndexRazorFileName = "Index.razor";
    public const string GeneratedIndexHtmlFileName = "index.html";
    public const string GeneratedCssFileName = "app.css";
    public const string GeneratedCsprojExtension = ".csproj";
    public const string GeneratedPagesDirectory = "Pages";
    public const string GeneratedLayoutDirectory = "Layout";
    public const string GeneratedServicesDirectory = "Services";
    public const string GeneratedModelsDirectory = "Models";
    public const string GeneratedWwwrootDirectory = "wwwroot";
    public const string GeneratedCssDirectory = "css";
    public const string GeneratedMainLayoutFileName = "MainLayout.razor";
    public const string GeneratedDebugTypeProperty = "DebugType";
    public const string GeneratedDebugTypeValue = "none";
    public const string GeneratedDebugSymbolsProperty = "DebugSymbols";
    public const string GeneratedDebugSymbolsValue = "false";
    public const string GeneratedFingerprintProperty = "StaticWebAssetsFingerprintContent";
    public const string GeneratedFingerprintValue = "true";

    public const string ApiKeyEnvironmentVariable = "ANTHROPIC_API_KEY";
    public const string ApiKeyLocalStorageKey = "anthropic_api_key";
    public const string AuthTypeOAuth = "oauth";

    public const string JsFunctionOpenClaudeDir = "openClaudeDir";
    public const string JsFunctionReadCredentialsFromDisk = "readCredentialsFromDisk";
    public const string CredentialsIdbName = "claude-code";
    public const string CredentialsIdbStore = "handles";
    public const string CredentialsIdbKey = "claude-dir";
    public const string CredentialsDirPickerId = "claude-dir";

    public const string OAuthTokenUrl = "https://platform.claude.com/v1/oauth/token";
    public const string OAuthClientId = "9d1c250a-e61b-44d9-88ed-5944d1962f5e";
    public const string OAuthDefaultScopes = "user:profile user:inference";
    public const string OAuthGrantTypeRefresh = "refresh_token";

    public const string CredentialsFileName = ".credentials.json";
    public const string CredentialsDir = ".claude";
    public const string OAuthPropertyName = "claudeAiOauth";
    public const string AccessTokenProperty = "accessToken";
    public const string RefreshTokenProperty = "refreshToken";
    public const string ExpiresAtProperty = "expiresAt";
    public const string OAuthAuthorizationHeader = "Bearer {0}";
    public const string CredentialsEndpointPath = "/api/credentials";
    public const string CredentialsEndpointRoute = "api/credentials";

    public const string NoWarnList = "$(NoWarn);SA1132;SA1402;SA1503;SA1508;SA1633;CS0162;CS0169;CS0219;CS0414;CS0649;CS1591;IL2110;IL2111;IL3050;PT003;PT004;PT005;PT006;PT007;CA1001;CA1050;CA1416;CA1806;CA1812;CA1838;CA2016;CA2024;CA2026;CA5394;IDE0011;IDE0028;IDE0044;IDE0046;IDE0056;IDE0057;IDE0059;IDE0200;IDE0350;MA0047;MA0075;MA0099;S101;S927;S1066;S1144;S1481;S1871;S2479;S2933;S3220;S3903;S3459;S108;S2486;S4487;RCS1006;RCS1036;RCS1061;RCS1163;RCS1169;RCS1201;RCS1213;RCS1235;RCS1267";

    public const string ToolInputCommand = "command";
    public const string ToolInputTimeout = "timeout";
    public const string ToolInputDescription = "description";
    public const string ToolInputRunInBackground = "run_in_background";
    public const string ToolInputFilePath = "file_path";
    public const string ToolInputOffset = "offset";
    public const string ToolInputLimit = "limit";
    public const string ToolInputContent = "content";
    public const string ToolInputOldString = "old_string";
    public const string ToolInputNewString = "new_string";
    public const string ToolInputReplaceAll = "replace_all";
    public const string ToolInputPattern = "pattern";
    public const string ToolInputPath = "path";
    public const string ToolInputGlob = "glob";
    public const string ToolInputOutputMode = "output_mode";
    public const string ToolInputContextBefore = "-B";
    public const string ToolInputContextAfter = "-A";
    public const string ToolInputContextBoth = "-C";
    public const string ToolInputContext = "context";
    public const string ToolInputLineNumbers = "-n";
    public const string ToolInputCaseInsensitive = "-i";
    public const string ToolInputFileType = "type";
    public const string ToolInputHeadLimit = "head_limit";
    public const string ToolInputMultiline = "multiline";
    public const string ToolInputPrompt = "prompt";
    public const string ToolInputUrl = "url";
    public const string ToolInputQuery = "query";
    public const string ToolInputAllowedDomains = "allowed_domains";
    public const string ToolInputBlockedDomains = "blocked_domains";
    public const string ToolInputNotebookPath = "notebook_path";
    public const string ToolInputCellId = "cell_id";
    public const string ToolInputNewSource = "new_source";
    public const string ToolInputCellType = "cell_type";
    public const string ToolInputEditMode = "edit_mode";
    public const string ToolInputTodos = "todos";
    public const string ToolInputTaskId = "task_id";
    public const string ToolInputBlock = "block";
    public const string ToolInputQuestions = "questions";
    public const string ToolInputSetting = "setting";
    public const string ToolInputValue = "value";
    public const string ToolInputServer = "server";
    public const string ToolInputUri = "uri";
    public const string ToolInputSubagentType = "subagent_type";

    public const string ToolOutputModeContent = "content";
    public const string ToolOutputModeFilesWithMatches = "files_with_matches";
    public const string ToolOutputModeCount = "count";

    public const string ToolEditModeReplace = "replace";
    public const string ToolEditModeInsert = "insert";
    public const string ToolEditModeDelete = "delete";

    public const string ToolCellTypeCode = "code";
    public const string ToolCellTypeMarkdown = "markdown";

    public const int ToolBashDefaultTimeoutMs = 120000;
    public const int ToolBashMaxTimeoutMs = 600000;
    public const int ToolFileReadDefaultLimit = 2000;
    public const int ToolGlobMaxResults = 100;
    public const int ToolGrepDefaultHeadLimit = 0;

    public const string ToolTodoStatusPending = "pending";
    public const string ToolTodoStatusInProgress = "in_progress";
    public const string ToolTodoStatusCompleted = "completed";

    public const string ToolNotebookCellsKey = "cells";
    public const string ToolNotebookSourceKey = "source";
    public const string ToolNotebookCellTypeKey = "cell_type";
    public const string ToolNotebookMetadataKey = "metadata";
    public const string ToolNotebookIdKey = "id";

    public const string ToolBashShellPath = "/bin/bash";
    public const string ToolBashShellArg = "-c";
    public const string ToolBashPowershellPath = "powershell.exe";
    public const string ToolBashPowershellArg = "-Command";

    public const string ToolLineNumberFormat = "{0,6}\t{1}";
    public const string ToolFileNotFoundFormat = "File not found: {0}";
    public const string ToolDirectoryNotFoundFormat = "Directory not found: {0}";
    public const string ToolOldStringNotFoundFormat = "old_string not found in {0}";
    public const string ToolOldStringAmbiguousFormat = "old_string matches {0} locations in {1}; provide more context to make it unique";
    public const string ToolEditSuccessFormat = "Edited {0}";
    public const string ToolWriteSuccessFormat = "Wrote {0}";
    public const string ToolGrepNoMatchesMessage = "No matches found";
    public const string ToolNotImplementedFormat = "Tool {0} runs server-side only";

    public const string ToolTaskOutputNotFoundFormat = "No task found with id: {0}";
    public const string ToolTodoStorageFileName = ".claude-todos.json";

    public const string ProxyProjectName = "PrTask.ClaudeCode.Proxy";
    public const string ProxyNamespace = "PrTask.ClaudeCode.Proxy";
    public const string ProxyProjectSdk = "Microsoft.NET.Sdk.Web";
    public const string ProxyDefaultUrl = "http://127.0.0.1:0";
    public const string ProxyLocalhost = "http://127.0.0.1";
    public const string ProxyWssLocalhost = "ws://127.0.0.1";
    public const int ProxyPortRangeStart = 5280;
    public const int ProxyPortRangeEnd = 5289;
    public const string ProxyCredentialsSubPath = ".claude/.credentials.json";
    public const string ProxyOAuthJsonPath = "claudeAiOauth";
    public const string ProxyAccessTokenJsonPath = "accessToken";
    public const string ProxyRefreshTokenJsonPath = "refreshToken";
    public const string ProxyExpiresAtJsonPath = "expiresAt";
    public const string ProxyAuthorizationHeaderPrefix = "Bearer ";
    public const string ProxyMessagesRoute = "/v1/messages";
    public const string ProxyWssRoute = "/ws";
    public const string ProxyCorsAllowAll = "AllowAll";
    public const string ProxyStartInstruction = "Start proxy: dotnet run --project PrTask.ClaudeCode.Proxy";
    public const string ProxyAutoDiscoverMessage = "Searching for proxy...";
    public const string ProxyConnectedFormat = "Connected to proxy at {0}";
    public const string ProxyNotFoundMessage = "Proxy not found. Start the proxy first.";
    public const string ProxyUrlLocalStorageKey = "proxy_url";
    public const string JsFunctionGetProxyUrl = "getProxyUrl";
    public const string JsFunctionSetProxyUrl = "setProxyUrl";

    public const string CreateApiKeyUrl = "https://api.anthropic.com/api/oauth/claude_cli/create_api_key";
    public const string CreateApiKeyRawKeyProperty = "raw_key";
    public const string OAuthRefreshGrantType = "refresh_token";

    public const string AnthropicBetaHeaderName = "anthropic-beta";
    public const string AnthropicBetaOAuthValue = "oauth-2025-04-20";

    public const string WssMessageTypeRequest = "request";
    public const string WssMessageTypeResponse = "response";
    public const string WssMessageTypeError = "error";
    public const string WssMessageTypeSseEvent = "sse_event";
    public const string WssMessageTypeSseDone = "sse_done";
    public const string WssMessageTypeStatus = "status";
    public const string WssJsonPropertyType = "type";
    public const string WssJsonPropertyData = "data";
    public const string WssJsonPropertyStatusCode = "status_code";
    public const string WssJsonPropertyMessage = "message";
}
