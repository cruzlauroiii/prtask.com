using System.Text.Json.Nodes;

namespace PrTask.Cdp;

#pragma warning disable SA1600
public static class CdpConsole
{
    public static async Task EnableAsync(CdpClient Client, string SessionId, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Console.enable", null, Cancel).ConfigureAwait(false);
    }

    public static async Task DisableAsync(CdpClient Client, string SessionId, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Console.disable", null, Cancel).ConfigureAwait(false);
    }

    public static async Task ClearMessagesAsync(CdpClient Client, string SessionId, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Console.clearMessages", null, Cancel).ConfigureAwait(false);
    }

    public static void OnMessageAdded(CdpClient Client, Action<ConsoleMessage> Handler)
    {
        Client.On("Console.messageAdded", Node =>
        {
            var Message = Node["message"];
            if (Message is null)
            {
                return;
            }

            Handler(new ConsoleMessage
            {
                Source = Message["source"]?.GetValue<string>() ?? string.Empty,
                Level = Message["level"]?.GetValue<string>() ?? string.Empty,
                Text = Message["text"]?.GetValue<string>() ?? string.Empty,
                Url = Message["url"]?.GetValue<string>(),
                Line = Message["line"]?.GetValue<int>() ?? 0,
                Column = Message["column"]?.GetValue<int>() ?? 0,
            });
        });
    }

    public static void OnRuntimeConsoleApiCalled(CdpClient Client, Action<RuntimeConsoleCall> Handler)
    {
        Client.On("Runtime.consoleAPICalled", Node =>
        {
            var ArgsArray = Node["args"]?.AsArray();
            var Args = new List<string>();
            if (ArgsArray is not null)
            {
                foreach (var Arg in ArgsArray)
                {
                    if (Arg is null)
                    {
                        continue;
                    }

                    var Value = Arg["value"]?.ToJsonString() ?? Arg["description"]?.GetValue<string>() ?? string.Empty;
                    Args.Add(Value);
                }
            }

            Handler(new RuntimeConsoleCall
            {
                Type = Node["type"]?.GetValue<string>() ?? string.Empty,
                Args = Args.ToArray(),
                Timestamp = Node["timestamp"]?.GetValue<double>() ?? 0,
            });
        });
    }

    public static void OnRuntimeExceptionThrown(CdpClient Client, Action<RuntimeException> Handler)
    {
        Client.On("Runtime.exceptionThrown", Node =>
        {
            var ExDetails = Node["exceptionDetails"];
            if (ExDetails is null)
            {
                return;
            }

            Handler(new RuntimeException
            {
                Text = ExDetails["text"]?.GetValue<string>() ?? string.Empty,
                LineNumber = ExDetails["lineNumber"]?.GetValue<int>() ?? 0,
                ColumnNumber = ExDetails["columnNumber"]?.GetValue<int>() ?? 0,
                Url = ExDetails["url"]?.GetValue<string>(),
                ScriptId = ExDetails["scriptId"]?.GetValue<string>(),
            });
        });
    }
}

public sealed class ConsoleMessage
{
    public string Source { get; set; } = string.Empty;
    public string Level { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
    public string? Url { get; set; }
    public int Line { get; set; }
    public int Column { get; set; }
}

public sealed class RuntimeConsoleCall
{
    public string Type { get; set; } = string.Empty;
    public string[] Args { get; set; } = [];
    public double Timestamp { get; set; }
}

public sealed class RuntimeException
{
    public string Text { get; set; } = string.Empty;
    public int LineNumber { get; set; }
    public int ColumnNumber { get; set; }
    public string? Url { get; set; }
    public string? ScriptId { get; set; }
}
#pragma warning restore SA1600
