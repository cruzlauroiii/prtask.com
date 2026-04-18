using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using PrTask.ClaudeCode.Models;

namespace PrTask.ClaudeCode.Services;

internal sealed class ToolDispatcher
{
    private readonly Dictionary<string, Func<JsonElement, CancellationToken, Task<string>>> Handlers;
    private readonly HttpClient HttpClient;
    private readonly Dictionary<string, string> BackgroundTaskOutputs;
    private readonly List<JsonElement> TodoList;
    private string WorkingDirectory;

    internal ToolDispatcher()
    {
        HttpClient = new HttpClient();
        BackgroundTaskOutputs = new Dictionary<string, string>(StringComparer.Ordinal);
        TodoList = new List<JsonElement>();
        WorkingDirectory = Environment.CurrentDirectory;
        Handlers = new Dictionary<string, Func<JsonElement, CancellationToken, Task<string>>>(StringComparer.Ordinal)
        {
            ["Agent"] = HandleAgentAsync,
            ["Bash"] = HandleBashAsync,
            ["TaskOutput"] = HandleTaskOutputAsync,
            ["ExitPlanMode"] = HandleExitPlanModeAsync,
            ["FileEdit"] = HandleFileEditAsync,
            ["FileRead"] = HandleFileReadAsync,
            ["FileWrite"] = HandleFileWriteAsync,
            ["Glob"] = HandleGlobAsync,
            ["Grep"] = HandleGrepAsync,
            ["TaskStop"] = HandleTaskStopAsync,
            ["ListMcpResources"] = HandleListMcpResourcesAsync,
            ["Mcp"] = HandleMcpAsync,
            ["NotebookEdit"] = HandleNotebookEditAsync,
            ["ReadMcpResource"] = HandleReadMcpResourceAsync,
            ["SubscribeMcpResource"] = HandleSubscribeMcpResourceAsync,
            ["UnsubscribeMcpResource"] = HandleUnsubscribeMcpResourceAsync,
            ["SubscribePolling"] = HandleSubscribePollingAsync,
            ["UnsubscribePolling"] = HandleUnsubscribePollingAsync,
            ["TodoWrite"] = HandleTodoWriteAsync,
            ["WebFetch"] = HandleWebFetchAsync,
            ["WebSearch"] = HandleWebSearchAsync,
            ["AskUserQuestion"] = HandleAskUserQuestionAsync,
            ["Config"] = HandleConfigAsync,
            ["EnterWorktree"] = HandleEnterWorktreeAsync,
            ["ExitWorktree"] = HandleExitWorktreeAsync,
        };
    }

    internal async Task<ApiContentBlock> DispatchAsync(ApiContentBlock ToolUse, CancellationToken Ct = default)
    {
        var ToolName = ToolUse.Name ?? string.Empty;
        var ToolInput = ToolUse.Input ?? default;
        var ToolId = ToolUse.Id ?? string.Empty;

        string ResultContent;
        var IsError = false;

        if (Handlers.TryGetValue(ToolName, out var Handler))
        {
            try
            {
                ResultContent = await Handler(ToolInput, Ct).ConfigureAwait(false);
            }
            catch (Exception Ex)
            {
                ResultContent = Ex.Message;
                IsError = true;
            }
        }
        else
        {
            ResultContent = string.Format(CultureInfo.InvariantCulture, "Unknown tool: {0}", ToolName);
            IsError = true;
        }

        return new ApiContentBlock
        {
            Type = "tool_result",
            ToolUseId = ToolId,
            Text = ResultContent,
            IsError = IsError,
        };
    }

    private static string GetString(JsonElement Input, string PropertyName, string DefaultValue = "")
    {
        if (Input.ValueKind == JsonValueKind.Object && Input.TryGetProperty(PropertyName, out var Prop) && Prop.ValueKind == JsonValueKind.String)
            return Prop.GetString() ?? DefaultValue;
        return DefaultValue;
    }

    private static int GetInt(JsonElement Input, string PropertyName, int DefaultValue = 0)
    {
        if (Input.ValueKind == JsonValueKind.Object && Input.TryGetProperty(PropertyName, out var Prop) && Prop.ValueKind == JsonValueKind.Number)
            return Prop.GetInt32();
        return DefaultValue;
    }

    private static bool GetBool(JsonElement Input, string PropertyName, bool DefaultValue = false)
    {
        if (Input.ValueKind == JsonValueKind.Object && Input.TryGetProperty(PropertyName, out var Prop))
        {
            if (Prop.ValueKind == JsonValueKind.True) return true;
            if (Prop.ValueKind == JsonValueKind.False) return false;
        }
        return DefaultValue;
    }

    private async Task<string> HandleBashAsync(JsonElement Input, CancellationToken Ct)
    {
        var Command = GetString(Input, "command");
        if (Command.Length == 0)
            return "No command provided";

        var TimeoutMs = GetInt(Input, "timeout", 120000);
        if (TimeoutMs > 600000)
            TimeoutMs = 600000;
        var RunInBackground = GetBool(Input, "run_in_background");

        var IsWindows = OperatingSystem.IsWindows();
        var ShellPath = IsWindows ? "powershell.exe" : "/bin/bash";
        var ShellArg = IsWindows ? "-Command" : "-c";

        var Psi = new ProcessStartInfo
        {
            FileName = ShellPath,
            Arguments = string.Concat(ShellArg, " ", Command),
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
            WorkingDirectory = WorkingDirectory,
        };

        using var Proc = new Process { StartInfo = Psi };
        Proc.Start();

        if (RunInBackground)
        {
            var TaskId = Guid.NewGuid().ToString("N").Substring(0, 8);
            _ = Task.Run(async () =>
            {
                var Stdout = await Proc.StandardOutput.ReadToEndAsync().ConfigureAwait(false);
                var Stderr = await Proc.StandardError.ReadToEndAsync().ConfigureAwait(false);
                await Proc.WaitForExitAsync().ConfigureAwait(false);
                var ResultSb = new StringBuilder();
                if (Stdout.Length > 0) ResultSb.AppendLine(Stdout);
                if (Stderr.Length > 0) ResultSb.Append("STDERR: ").AppendLine(Stderr);
                ResultSb.Append("Exit code: ").Append(Proc.ExitCode);
                lock (BackgroundTaskOutputs)
                {
                    BackgroundTaskOutputs[TaskId] = ResultSb.ToString();
                }
            });
            return string.Concat("Background task started with id: ", TaskId);
        }

        using var Cts = CancellationTokenSource.CreateLinkedTokenSource(Ct);
        Cts.CancelAfter(TimeoutMs);

        var StdoutTask = Proc.StandardOutput.ReadToEndAsync(Cts.Token);
        var StderrTask = Proc.StandardError.ReadToEndAsync(Cts.Token);

        try
        {
            await Proc.WaitForExitAsync(Cts.Token).ConfigureAwait(false);
        }
        catch (OperationCanceledException)
        {
            try { Proc.Kill(true); } catch { }
        }

        var StdoutResult = await StdoutTask.ConfigureAwait(false);
        var StderrResult = await StderrTask.ConfigureAwait(false);

        var OutputSb = new StringBuilder();
        if (StdoutResult.Length > 0)
            OutputSb.AppendLine(StdoutResult);
        if (StderrResult.Length > 0)
            OutputSb.Append("STDERR: ").AppendLine(StderrResult);
        if (Proc.HasExited)
            OutputSb.Append("Exit code: ").Append(Proc.ExitCode);
        else
            OutputSb.Append("Process timed out and was killed");

        return OutputSb.ToString();
    }

    private static Task<string> HandleFileReadAsync(JsonElement Input, CancellationToken Ct)
    {
        var FilePath = GetString(Input, "file_path");
        if (!File.Exists(FilePath))
            return Task.FromResult(string.Format(CultureInfo.InvariantCulture, "File not found: {0}", FilePath));

        var Offset = GetInt(Input, "offset", 0);
        var Limit = GetInt(Input, "limit", 2000);

        var AllLines = File.ReadAllLines(FilePath);
        var TotalLines = AllLines.Length;
        var StartLine = Offset > 0 ? Math.Min(Offset, TotalLines) : 0;
        var EndLine = Math.Min(StartLine + Limit, TotalLines);

        var ResultSb = new StringBuilder();
        for (var I = StartLine; I < EndLine; I++)
        {
            ResultSb.AppendFormat(CultureInfo.InvariantCulture, "{0,6}	{1}", I + 1, AllLines[I]);
            ResultSb.AppendLine();
        }

        return Task.FromResult(ResultSb.ToString());
    }

    private static Task<string> HandleFileWriteAsync(JsonElement Input, CancellationToken Ct)
    {
        var FilePath = GetString(Input, "file_path");
        var Content = GetString(Input, "content");

        var Dir = Path.GetDirectoryName(FilePath);
        if (Dir is not null && Dir.Length > 0 && !Directory.Exists(Dir))
            Directory.CreateDirectory(Dir);

        File.WriteAllText(FilePath, Content);
        return Task.FromResult(string.Format(CultureInfo.InvariantCulture, "Wrote {0}", FilePath));
    }

    private static Task<string> HandleFileEditAsync(JsonElement Input, CancellationToken Ct)
    {
        var FilePath = GetString(Input, "file_path");
        var OldString = GetString(Input, "old_string");
        var NewString = GetString(Input, "new_string");
        var ReplaceAll = GetBool(Input, "replace_all");

        if (!File.Exists(FilePath))
            return Task.FromResult(string.Format(CultureInfo.InvariantCulture, "File not found: {0}", FilePath));

        var FileContent = File.ReadAllText(FilePath);

        if (!FileContent.Contains(OldString, StringComparison.Ordinal))
            return Task.FromResult(string.Format(CultureInfo.InvariantCulture, "old_string not found in {0}", FilePath));

        if (!ReplaceAll)
        {
            var FirstIdx = FileContent.IndexOf(OldString, StringComparison.Ordinal);
            var SecondIdx = FileContent.IndexOf(OldString, FirstIdx + 1, StringComparison.Ordinal);
            if (SecondIdx >= 0)
            {
                var MatchCount = 1;
                var SearchIdx = SecondIdx;
                while (SearchIdx >= 0)
                {
                    MatchCount++;
                    SearchIdx = FileContent.IndexOf(OldString, SearchIdx + 1, StringComparison.Ordinal);
                }
                return Task.FromResult(string.Format(CultureInfo.InvariantCulture, "old_string matches {0} locations in {1}; provide more context to make it unique", MatchCount, FilePath));
            }

            FileContent = string.Concat(
                FileContent.AsSpan(0, FirstIdx),
                NewString,
                FileContent.AsSpan(FirstIdx + OldString.Length));
        }
        else
        {
            FileContent = FileContent.Replace(OldString, NewString, StringComparison.Ordinal);
        }

        File.WriteAllText(FilePath, FileContent);
        return Task.FromResult(string.Format(CultureInfo.InvariantCulture, "Edited {0}", FilePath));
    }

    private Task<string> HandleGlobAsync(JsonElement Input, CancellationToken Ct)
    {
        var Pattern = GetString(Input, "pattern");
        var SearchPath = GetString(Input, "path");
        if (SearchPath.Length == 0)
            SearchPath = WorkingDirectory;

        if (!Directory.Exists(SearchPath))
            return Task.FromResult(string.Format(CultureInfo.InvariantCulture, "Directory not found: {0}", SearchPath));

        var FileName = Path.GetFileName(Pattern);
        var SubDir = Path.GetDirectoryName(Pattern) ?? string.Empty;
        var FullSearchPath = SubDir.Length > 0 ? Path.Combine(SearchPath, SubDir) : SearchPath;

        if (!Directory.Exists(FullSearchPath))
            return Task.FromResult(string.Format(CultureInfo.InvariantCulture, "Directory not found: {0}", FullSearchPath));

        var RecurseOption = Pattern.Contains("**") ? System.IO.SearchOption.AllDirectories : System.IO.SearchOption.TopDirectoryOnly;
        if (FileName.Length == 0)
            FileName = "*";

        var Files = Directory.EnumerateFiles(FullSearchPath, FileName, RecurseOption)
            .Take(100)
            .OrderByDescending(F => File.GetLastWriteTimeUtc(F))
            .ToList();

        if (Files.Count == 0)
            return Task.FromResult("No files matched the pattern");

        var ResultSb = new StringBuilder();
        foreach (var F in Files)
            ResultSb.AppendLine(F);

        if (Files.Count >= 100)
            ResultSb.AppendLine("(results truncated)");

        return Task.FromResult(ResultSb.ToString());
    }

    private Task<string> HandleGrepAsync(JsonElement Input, CancellationToken Ct)
    {
        var Pattern = GetString(Input, "pattern");
        var SearchPath = GetString(Input, "path");
        var GlobFilter = GetString(Input, "glob");
        var OutputMode = GetString(Input, "output_mode", "files_with_matches");
        var CaseInsensitive = GetBool(Input, "-i");
        var HeadLimit = GetInt(Input, "head_limit", 0);
        var ContextBefore = GetInt(Input, "-B");
        var ContextAfter = GetInt(Input, "-A");
        var ContextBoth = GetInt(Input, "context");
        var ShowLineNumbers = GetBool(Input, "-n", true);
        var OffsetSkip = GetInt(Input, "offset");

        if (SearchPath.Length == 0)
            SearchPath = WorkingDirectory;

        if (ContextBoth > 0)
        {
            if (ContextBefore == 0) ContextBefore = ContextBoth;
            if (ContextAfter == 0) ContextAfter = ContextBoth;
        }

        var RxOptions = System.Text.RegularExpressions.RegexOptions.Compiled;
        if (CaseInsensitive) RxOptions |= System.Text.RegularExpressions.RegexOptions.IgnoreCase;
        Regex Rx;
        try { Rx = new Regex(Pattern, RxOptions); }
        catch (Exception Ex) { return Task.FromResult(string.Concat("Invalid regex: ", Ex.Message)); }

        var FilesToSearch = new List<string>();
        if (File.Exists(SearchPath))
        {
            FilesToSearch.Add(SearchPath);
        }
        else if (Directory.Exists(SearchPath))
        {
            var GlobPattern = GlobFilter.Length > 0 ? GlobFilter : "*";
            FilesToSearch.AddRange(Directory.EnumerateFiles(SearchPath, GlobPattern, System.IO.SearchOption.AllDirectories));
        }
        else
        {
            return Task.FromResult(string.Format(CultureInfo.InvariantCulture, "Directory not found: {0}", SearchPath));
        }

        var ResultSb = new StringBuilder();
        var MatchedFiles = new List<string>();
        var TotalMatches = 0;
        var EntryCount = 0;

        foreach (var FilePath in FilesToSearch)
        {
            if (HeadLimit > 0 && EntryCount >= HeadLimit + OffsetSkip)
                break;

            string[] Lines;
            try { Lines = File.ReadAllLines(FilePath); }
            catch { continue; }

            var FileHasMatch = false;
            var FileMatchCount = 0;

            for (var LineIdx = 0; LineIdx < Lines.Length; LineIdx++)
            {
                if (!Rx.IsMatch(Lines[LineIdx]))
                    continue;

                FileHasMatch = true;
                FileMatchCount++;
                TotalMatches++;

                if (string.Equals(OutputMode, "content", StringComparison.Ordinal))
                {
                    EntryCount++;
                    if (EntryCount <= OffsetSkip) continue;
                    if (HeadLimit > 0 && EntryCount > OffsetSkip + HeadLimit) break;

                    var StartCtx = Math.Max(0, LineIdx - ContextBefore);
                    var EndCtx = Math.Min(Lines.Length - 1, LineIdx + ContextAfter);

                    for (var C = StartCtx; C <= EndCtx; C++)
                    {
                        if (ShowLineNumbers)
                            ResultSb.Append(FilePath).Append(':').Append(C + 1).Append(':').AppendLine(Lines[C]);
                        else
                            ResultSb.AppendLine(Lines[C]);
                    }
                }
            }

            if (FileHasMatch)
            {
                MatchedFiles.Add(FilePath);

                if (string.Equals(OutputMode, "files_with_matches", StringComparison.Ordinal))
                {
                    EntryCount++;
                    if (EntryCount > OffsetSkip)
                        ResultSb.AppendLine(FilePath);
                }
                else if (string.Equals(OutputMode, "count", StringComparison.Ordinal))
                {
                    EntryCount++;
                    if (EntryCount > OffsetSkip)
                        ResultSb.Append(FilePath).Append(':').AppendLine(FileMatchCount.ToString(CultureInfo.InvariantCulture));
                }
            }
        }

        if (ResultSb.Length == 0)
            return Task.FromResult("No matches found");

        return Task.FromResult(ResultSb.ToString());
    }

    private async Task<string> HandleWebFetchAsync(JsonElement Input, CancellationToken Ct)
    {
        var Url = GetString(Input, "url");
        if (Url.Length == 0)
            return "No URL provided";

        try
        {
            using var Response = await HttpClient.GetAsync(Url, Ct).ConfigureAwait(false);
            var StatusCode = (int)Response.StatusCode;
            var Content = await Response.Content.ReadAsStringAsync(Ct).ConfigureAwait(false);

            var ResultSb = new StringBuilder();
            ResultSb.Append("HTTP ").Append(StatusCode).Append(' ').AppendLine(Response.ReasonPhrase ?? string.Empty);
            ResultSb.Append("Content-Length: ").AppendLine(Content.Length.ToString(CultureInfo.InvariantCulture));
            ResultSb.AppendLine();
            ResultSb.Append(Content);
            return ResultSb.ToString();
        }
        catch (Exception Ex)
        {
            return string.Concat("Fetch failed: ", Ex.Message);
        }
    }

    private async Task<string> HandleWebSearchAsync(JsonElement Input, CancellationToken Ct)
    {
        var Query = GetString(Input, "query");
        if (Query.Length == 0)
            return "No search query provided";

        try
        {
            var SearchUrl = string.Concat("https://html.duckduckgo.com/html/?q=", Uri.EscapeDataString(Query));
            using var Request = new HttpRequestMessage(HttpMethod.Get, SearchUrl);
            Request.Headers.Add("User-Agent", "Mozilla/5.0 (compatible; ClaudeCode/1.0)");
            using var Response = await HttpClient.SendAsync(Request, Ct).ConfigureAwait(false);
            var Content = await Response.Content.ReadAsStringAsync(Ct).ConfigureAwait(false);
            return Content;
        }
        catch (Exception Ex)
        {
            return string.Concat("Search failed: ", Ex.Message);
        }
    }

    private static Task<string> HandleNotebookEditAsync(JsonElement Input, CancellationToken Ct)
    {
        var NotebookPath = GetString(Input, "notebook_path");
        var CellId = GetString(Input, "cell_id");
        var NewSource = GetString(Input, "new_source");
        var CellType = GetString(Input, "cell_type", "code");
        var EditMode = GetString(Input, "edit_mode", "replace");

        if (!File.Exists(NotebookPath))
            return Task.FromResult(string.Format(CultureInfo.InvariantCulture, "File not found: {0}", NotebookPath));

        var JsonText = File.ReadAllText(NotebookPath);
        using var Doc = JsonDocument.Parse(JsonText);
        var Root = Doc.RootElement;

        if (!Root.TryGetProperty("cells", out var CellsElement))
            return Task.FromResult("Notebook has no cells array");

        var CellsList = new List<JsonElement>();
        foreach (var Cell in CellsElement.EnumerateArray())
            CellsList.Add(Cell);

        var TargetIdx = -1;
        if (CellId.Length > 0)
        {
            for (var I = 0; I < CellsList.Count; I++)
            {
                if (CellsList[I].TryGetProperty("metadata", out var Meta) && Meta.TryGetProperty("id", out var IdProp))
                {
                    if (string.Equals(IdProp.GetString(), CellId, StringComparison.Ordinal))
                    {
                        TargetIdx = I;
                        break;
                    }
                }
            }
        }

        var SourceLines = NewSource.Split('\n');
        var SourceArray = new List<string>();
        for (var I = 0; I < SourceLines.Length; I++)
        {
            SourceArray.Add(I < SourceLines.Length - 1 ? string.Concat(SourceLines[I], "\n") : SourceLines[I]);
        }

        var NewCellJson = string.Concat(
            "{\"cell_type\": \"", CellType, "\", \"source\": ",
            JsonSerializer.Serialize(SourceArray),
            ", \"metadata\": {}, \"outputs\": []}");
        var NewCellElement = JsonDocument.Parse(NewCellJson).RootElement.Clone();

        if (string.Equals(EditMode, "insert", StringComparison.Ordinal))
        {
            var InsertIdx = TargetIdx >= 0 ? TargetIdx + 1 : 0;
            CellsList.Insert(InsertIdx, NewCellElement);
        }
        else if (string.Equals(EditMode, "delete", StringComparison.Ordinal))
        {
            if (TargetIdx >= 0)
                CellsList.RemoveAt(TargetIdx);
            else
                return Task.FromResult("Cell not found for deletion");
        }
        else
        {
            if (TargetIdx >= 0)
                CellsList[TargetIdx] = NewCellElement;
            else if (CellsList.Count > 0)
                CellsList[CellsList.Count - 1] = NewCellElement;
            else
                CellsList.Add(NewCellElement);
        }

        var OutputJson = new StringBuilder();
        OutputJson.Append('{');
        var First = true;
        foreach (var Prop in Root.EnumerateObject())
        {
            if (!First) OutputJson.Append(',');
            First = false;
            if (string.Equals(Prop.Name, "cells", StringComparison.Ordinal))
            {
                OutputJson.Append("\"cells\": ");
                OutputJson.Append(JsonSerializer.Serialize(CellsList));
            }
            else
            {
                OutputJson.Append('"').Append(Prop.Name).Append("\": ");
                OutputJson.Append(Prop.Value.GetRawText());
            }
        }
        OutputJson.Append('}');

        File.WriteAllText(NotebookPath, OutputJson.ToString());
        return Task.FromResult(string.Concat("Notebook edited: ", NotebookPath));
    }

    private Task<string> HandleTodoWriteAsync(JsonElement Input, CancellationToken Ct)
    {
        if (Input.ValueKind == JsonValueKind.Object && Input.TryGetProperty("todos", out var TodosElement))
        {
            TodoList.Clear();
            foreach (var Todo in TodosElement.EnumerateArray())
                TodoList.Add(Todo.Clone());
        }

        var StoragePath = Path.Combine(WorkingDirectory, ".claude-todos.json");
        File.WriteAllText(StoragePath, JsonSerializer.Serialize(TodoList));

        return Task.FromResult(string.Concat("Todos updated: ", TodoList.Count.ToString(CultureInfo.InvariantCulture), " items"));
    }

    private Task<string> HandleTaskOutputAsync(JsonElement Input, CancellationToken Ct)
    {
        var TaskId = GetString(Input, "task_id");

        string? Output;
        lock (BackgroundTaskOutputs)
        {
            BackgroundTaskOutputs.TryGetValue(TaskId, out Output);
        }

        if (Output is not null)
            return Task.FromResult(Output);

        return Task.FromResult(string.Format(CultureInfo.InvariantCulture, "No task found with id: {0}", TaskId));
    }

    private static Task<string> HandleAskUserQuestionAsync(JsonElement Input, CancellationToken Ct)
    {
        if (Input.ValueKind == JsonValueKind.Object && Input.TryGetProperty("questions", out var QuestionsElement))
        {
            var ResultSb = new StringBuilder();
            foreach (var Q in QuestionsElement.EnumerateArray())
            {
                if (Q.TryGetProperty("question", out var QuestionProp))
                    ResultSb.AppendLine(QuestionProp.GetString() ?? string.Empty);
            }
            return Task.FromResult(ResultSb.ToString());
        }

        return Task.FromResult("No questions provided");
    }

    private static Task<string> HandleAgentAsync(JsonElement Input, CancellationToken Ct)
    {
        var Prompt = GetString(Input, "prompt");
        var Description = GetString(Input, "description");
        return Task.FromResult(string.Concat("Agent sub-task acknowledged: ", Description, " - ", Prompt));
    }

    private static Task<string> HandleExitPlanModeAsync(JsonElement Input, CancellationToken Ct)
    {
        return Task.FromResult("Plan mode exited");
    }

    private Task<string> HandleTaskStopAsync(JsonElement Input, CancellationToken Ct)
    {
        var TaskId = GetString(Input, "task_id");
        return Task.FromResult(string.Concat("Task stopped: ", TaskId));
    }

    private static Task<string> HandleListMcpResourcesAsync(JsonElement Input, CancellationToken Ct)
    {
        return Task.FromResult(string.Format(CultureInfo.InvariantCulture, "Tool {0} runs server-side only", "ListMcpResources"));
    }

    private static Task<string> HandleMcpAsync(JsonElement Input, CancellationToken Ct)
    {
        return Task.FromResult(string.Format(CultureInfo.InvariantCulture, "Tool {0} runs server-side only", "Mcp"));
    }

    private static Task<string> HandleReadMcpResourceAsync(JsonElement Input, CancellationToken Ct)
    {
        return Task.FromResult(string.Format(CultureInfo.InvariantCulture, "Tool {0} runs server-side only", "ReadMcpResource"));
    }

    private static Task<string> HandleSubscribeMcpResourceAsync(JsonElement Input, CancellationToken Ct)
    {
        return Task.FromResult(string.Format(CultureInfo.InvariantCulture, "Tool {0} runs server-side only", "SubscribeMcpResource"));
    }

    private static Task<string> HandleUnsubscribeMcpResourceAsync(JsonElement Input, CancellationToken Ct)
    {
        return Task.FromResult(string.Format(CultureInfo.InvariantCulture, "Tool {0} runs server-side only", "UnsubscribeMcpResource"));
    }

    private static Task<string> HandleSubscribePollingAsync(JsonElement Input, CancellationToken Ct)
    {
        return Task.FromResult(string.Format(CultureInfo.InvariantCulture, "Tool {0} runs server-side only", "SubscribePolling"));
    }

    private static Task<string> HandleUnsubscribePollingAsync(JsonElement Input, CancellationToken Ct)
    {
        return Task.FromResult(string.Format(CultureInfo.InvariantCulture, "Tool {0} runs server-side only", "UnsubscribePolling"));
    }

    private static Task<string> HandleConfigAsync(JsonElement Input, CancellationToken Ct)
    {
        var Setting = GetString(Input, "setting");
        return Task.FromResult(string.Concat("Config: ", Setting));
    }

    private static Task<string> HandleEnterWorktreeAsync(JsonElement Input, CancellationToken Ct)
    {
        return Task.FromResult(string.Format(CultureInfo.InvariantCulture, "Tool {0} runs server-side only", "EnterWorktree"));
    }

    private static Task<string> HandleExitWorktreeAsync(JsonElement Input, CancellationToken Ct)
    {
        return Task.FromResult(string.Format(CultureInfo.InvariantCulture, "Tool {0} runs server-side only", "ExitWorktree"));
    }

}
