using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

var WasmPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "..", "output", "claudecode", "wwwroot"));
var Builder = WebApplication.CreateBuilder(new WebApplicationOptions { WebRootPath = WasmPath });
Builder.WebHost.UseKestrel(Options =>
    Options.Listen(System.Net.IPAddress.Loopback, 0, ListenOptions =>
        ListenOptions.UseHttps()));
var App = Builder.Build();

var CredsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".claude/.credentials.json");
var SessionId = Guid.NewGuid().ToString();
var Cwd = Environment.CurrentDirectory;

async Task<string> GetOAuthTokenAsync()
{
    var CredsJson = await File.ReadAllTextAsync(CredsPath);
    var Creds = JsonDocument.Parse(CredsJson);
    return Creds.RootElement.GetProperty("claudeAiOauth").GetProperty("accessToken").GetString()!;
}

App.MapPost("/api/messages", async (HttpContext Ctx) =>
{
    using var Reader = new StreamReader(Ctx.Request.Body, Encoding.UTF8);
    var RequestJson = await Reader.ReadToEndAsync();

    var OAuthToken = await GetOAuthTokenAsync();
    var RequestDict = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(RequestJson)!;

    if (!RequestDict.ContainsKey("metadata"))
    {
        var MetadataObj = new Dictionary<string, string>
        {
            ["user_id"] = JsonSerializer.Serialize(new
            {
                device_id = "7d547dfd2a15bfb7cd9bc294d55f44cb1a1dae4787814c2994a5e8b855992fb2",
                account_uuid = "c3f8fcdd-2e5d-49f9-bed8-0f68de938c02",
                session_id = SessionId,
            }),
        };
        RequestDict["metadata"] = JsonSerializer.SerializeToElement(MetadataObj);
    }

    if (!RequestDict.ContainsKey("system"))
    {
        var SystemArr = new[] { new { type = "text", text = "x-anthropic-billing-header: cc_version=2.1.81.c43; cc_entrypoint=cli; cch=6c6d8;" } };
        RequestDict["system"] = JsonSerializer.SerializeToElement(SystemArr);
    }

    var FinalRequestJson = JsonSerializer.Serialize(RequestDict);
    Console.WriteLine(string.Concat(">>> ", FinalRequestJson.Length > 500 ? FinalRequestJson.Substring(0, 500) : FinalRequestJson));

    using var ApiClient = new HttpClient();
    ApiClient.Timeout = TimeSpan.FromMinutes(10);
    var ApiRequest = new HttpRequestMessage(HttpMethod.Post, "https://api.anthropic.com/v1/messages?beta=true");
    ApiRequest.Headers.Authorization = new AuthenticationHeaderValue("Bearer", OAuthToken);
    ApiRequest.Headers.Add("anthropic-version", "2023-06-01");
    ApiRequest.Headers.Add("anthropic-beta", "oauth-2025-04-20,interleaved-thinking-2025-05-14,redact-thinking-2026-02-12,context-management-2025-06-27,prompt-caching-scope-2026-01-05,advanced-tool-use-2025-11-20,effort-2025-11-24");
    ApiRequest.Headers.Add("anthropic-dangerous-direct-browser-access", "true");
    ApiRequest.Headers.TryAddWithoutValidation("user-agent", "claude-cli/2.1.81 (external, cli)");
    ApiRequest.Headers.Add("x-app", "cli");
    ApiRequest.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    ApiRequest.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("text/event-stream"));
    ApiRequest.Content = new StringContent(FinalRequestJson, Encoding.UTF8, "application/json");

    var ApiResponse = await ApiClient.SendAsync(ApiRequest, HttpCompletionOption.ResponseHeadersRead);
    Console.WriteLine(string.Concat("<<< ", ((int)ApiResponse.StatusCode).ToString()));

    Ctx.Response.StatusCode = (int)ApiResponse.StatusCode;
    Ctx.Response.ContentType = ApiResponse.Content.Headers.ContentType?.ToString() ?? "application/json";
    await ApiResponse.Content.CopyToAsync(Ctx.Response.Body);
});

App.MapPost("/api/tool/bash", async (HttpContext Ctx) =>
{
    using var Reader = new StreamReader(Ctx.Request.Body, Encoding.UTF8);
    var Body = await Reader.ReadToEndAsync();
    var Doc = JsonDocument.Parse(Body);
    var Command = Doc.RootElement.GetProperty("command").GetString() ?? string.Empty;
    var TimeoutMs = 120000;
    if (Doc.RootElement.TryGetProperty("timeout", out var ToProp))
        TimeoutMs = ToProp.GetInt32();

    Console.WriteLine(string.Concat("BASH> ", Command));

    var Psi = new ProcessStartInfo("cmd.exe", string.Concat("/c ", Command))
    {
        WorkingDirectory = Cwd,
        RedirectStandardOutput = true,
        RedirectStandardError = true,
        UseShellExecute = false,
        CreateNoWindow = true,
    };
    using var Proc = Process.Start(Psi)!;
    using var Cts = new CancellationTokenSource(TimeoutMs);
    try
    {
        await Proc.WaitForExitAsync(Cts.Token);
    }
    catch (OperationCanceledException)
    {
        Proc.Kill(true);
    }
    var StdOut = await Proc.StandardOutput.ReadToEndAsync();
    var StdErr = await Proc.StandardError.ReadToEndAsync();
    var Output = StdOut.Length > 0 && StdErr.Length > 0
        ? string.Concat(StdOut, "\nSTDERR:\n", StdErr)
        : StdOut.Length > 0 ? StdOut : StdErr;

    Ctx.Response.ContentType = "application/json";
    await Ctx.Response.WriteAsync(JsonSerializer.Serialize(new { exit_code = Proc.ExitCode, output = Output }));
});

App.MapPost("/api/tool/read", async (HttpContext Ctx) =>
{
    using var Reader = new StreamReader(Ctx.Request.Body, Encoding.UTF8);
    var Body = await Reader.ReadToEndAsync();
    var Doc = JsonDocument.Parse(Body);
    var FilePath = Doc.RootElement.GetProperty("file_path").GetString() ?? string.Empty;
    var Offset = 0;
    var Limit = 2000;
    if (Doc.RootElement.TryGetProperty("offset", out var OffProp))
        Offset = OffProp.GetInt32();
    if (Doc.RootElement.TryGetProperty("limit", out var LimProp))
        Limit = LimProp.GetInt32();

    Console.WriteLine(string.Concat("READ> ", FilePath));

    if (!File.Exists(FilePath))
    {
        Ctx.Response.StatusCode = 404;
        await Ctx.Response.WriteAsync(JsonSerializer.Serialize(new { error = string.Concat("File not found: ", FilePath) }));
        return;
    }

    var Lines = await File.ReadAllLinesAsync(FilePath);
    var Selected = Lines.Skip(Offset).Take(Limit).ToArray();
    var Numbered = new StringBuilder();
    for (var I = 0; I < Selected.Length; I++)
        Numbered.Append((Offset + I + 1).ToString().PadLeft(6)).Append('\t').AppendLine(Selected[I]);

    Ctx.Response.ContentType = "application/json";
    await Ctx.Response.WriteAsync(JsonSerializer.Serialize(new { content = Numbered.ToString(), total_lines = Lines.Length }));
});

App.MapPost("/api/tool/write", async (HttpContext Ctx) =>
{
    using var Reader = new StreamReader(Ctx.Request.Body, Encoding.UTF8);
    var Body = await Reader.ReadToEndAsync();
    var Doc = JsonDocument.Parse(Body);
    var FilePath = Doc.RootElement.GetProperty("file_path").GetString() ?? string.Empty;
    var Content = Doc.RootElement.GetProperty("content").GetString() ?? string.Empty;

    Console.WriteLine(string.Concat("WRITE> ", FilePath));
    var Dir = Path.GetDirectoryName(FilePath);
    if (!string.IsNullOrEmpty(Dir))
        Directory.CreateDirectory(Dir);
    await File.WriteAllTextAsync(FilePath, Content);

    Ctx.Response.ContentType = "application/json";
    await Ctx.Response.WriteAsync(JsonSerializer.Serialize(new { success = true, bytes = Content.Length }));
});

App.MapPost("/api/tool/glob", async (HttpContext Ctx) =>
{
    using var Reader = new StreamReader(Ctx.Request.Body, Encoding.UTF8);
    var Body = await Reader.ReadToEndAsync();
    var Doc = JsonDocument.Parse(Body);
    var Pattern = Doc.RootElement.GetProperty("pattern").GetString() ?? string.Empty;
    var SearchPath = Cwd;
    if (Doc.RootElement.TryGetProperty("path", out var PathProp))
        SearchPath = PathProp.GetString() ?? Cwd;

    Console.WriteLine(string.Concat("GLOB> ", Pattern, " in ", SearchPath));

    var Psi = new ProcessStartInfo("cmd.exe", string.Concat("/c dir /s /b \"", Path.Combine(SearchPath, Pattern), "\" 2>NUL"))
    {
        WorkingDirectory = SearchPath,
        RedirectStandardOutput = true,
        UseShellExecute = false,
        CreateNoWindow = true,
    };
    using var Proc = Process.Start(Psi)!;
    var Output = await Proc.StandardOutput.ReadToEndAsync();
    await Proc.WaitForExitAsync();
    var Files = Output.Split('\n', StringSplitOptions.RemoveEmptyEntries).Select(F => F.Trim()).Where(F => F.Length > 0).ToArray();

    Ctx.Response.ContentType = "application/json";
    await Ctx.Response.WriteAsync(JsonSerializer.Serialize(new { files = Files }));
});

App.MapPost("/api/tool/grep", async (HttpContext Ctx) =>
{
    using var Reader = new StreamReader(Ctx.Request.Body, Encoding.UTF8);
    var Body = await Reader.ReadToEndAsync();
    var Doc = JsonDocument.Parse(Body);
    var PatternStr = Doc.RootElement.GetProperty("pattern").GetString() ?? string.Empty;
    var SearchPath = Cwd;
    if (Doc.RootElement.TryGetProperty("path", out var PathProp))
        SearchPath = PathProp.GetString() ?? Cwd;

    Console.WriteLine(string.Concat("GREP> ", PatternStr, " in ", SearchPath));

    var Psi = new ProcessStartInfo("cmd.exe", string.Concat("/c findstr /s /n /r /c:\"", PatternStr, "\" \"", SearchPath, "\\*\" 2>NUL"))
    {
        WorkingDirectory = SearchPath,
        RedirectStandardOutput = true,
        UseShellExecute = false,
        CreateNoWindow = true,
    };
    using var Proc = Process.Start(Psi)!;
    var Output = await Proc.StandardOutput.ReadToEndAsync();
    await Proc.WaitForExitAsync();

    Ctx.Response.ContentType = "application/json";
    await Ctx.Response.WriteAsync(JsonSerializer.Serialize(new { output = Output.Length > 10000 ? Output.Substring(0, 10000) : Output }));
});

App.MapPost("/api/tool/edit", async (HttpContext Ctx) =>
{
    using var Reader = new StreamReader(Ctx.Request.Body, Encoding.UTF8);
    var Body = await Reader.ReadToEndAsync();
    var Doc = JsonDocument.Parse(Body);
    var FilePath = Doc.RootElement.GetProperty("file_path").GetString() ?? string.Empty;
    var OldString = Doc.RootElement.GetProperty("old_string").GetString() ?? string.Empty;
    var NewString = Doc.RootElement.GetProperty("new_string").GetString() ?? string.Empty;

    Console.WriteLine(string.Concat("EDIT> ", FilePath));

    if (!File.Exists(FilePath))
    {
        Ctx.Response.StatusCode = 404;
        await Ctx.Response.WriteAsync(JsonSerializer.Serialize(new { error = "File not found" }));
        return;
    }

    var Content = await File.ReadAllTextAsync(FilePath);
    if (!Content.Contains(OldString))
    {
        Ctx.Response.StatusCode = 400;
        await Ctx.Response.WriteAsync(JsonSerializer.Serialize(new { error = "old_string not found in file" }));
        return;
    }

    var NewContent = Content.Replace(OldString, NewString);
    await File.WriteAllTextAsync(FilePath, NewContent);

    Ctx.Response.ContentType = "application/json";
    await Ctx.Response.WriteAsync(JsonSerializer.Serialize(new { success = true }));
});

App.UseStaticFiles(new StaticFileOptions { ServeUnknownFileTypes = true });
App.MapFallbackToFile("index.html");

App.Lifetime.ApplicationStarted.Register(() =>
{
    foreach (var Addr in App.Urls)
        Console.WriteLine(string.Concat("Claude Code: ", Addr));
    Console.WriteLine(string.Concat("Credentials: ", CredsPath));
    Console.WriteLine(string.Concat("Working directory: ", Cwd));
});
App.Run();
