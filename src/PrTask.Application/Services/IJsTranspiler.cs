namespace PrTask.Application.Services;
public interface IJsTranspiler
{
    JsTranspileResult TranspileFile(string InputPath, string OutputDir, string TargetNs);
    JsTranspileResult TranspileSource(string JsSource, string OutputDir, string TargetNs);
    IReadOnlyList<BlazorComponentResult> GenerateBlazorComponents(string JsSource, string OutputDir, string TargetNs);
}

public sealed class JsTranspileResult
{
    public required bool Success { get; init; }
    public int ClassCount { get; init; }
    public int FunctionCount { get; init; }
    public int ComponentCount { get; init; }
    public int LineCount { get; init; }
    public int FileCount { get; init; }
    public IReadOnlyList<string> OutputFiles { get; init; } = [];
    public IReadOnlyList<string> Errors { get; init; } = [];
    public IReadOnlyList<string> Warnings { get; init; } = [];
}

public sealed class BlazorComponentResult
{
    public required string ComponentName { get; init; }
    public required string RazorContent { get; init; }
    public required string CodeBehindContent { get; init; }
    public IReadOnlyList<string> Parameters { get; init; } = [];
    public IReadOnlyList<string> StateFields { get; init; } = [];
    public IReadOnlyList<string> EventCallbacks { get; init; } = [];
}
