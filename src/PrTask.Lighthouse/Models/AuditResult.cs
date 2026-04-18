namespace PrTask.Lighthouse.Models;

#pragma warning disable SA1600
public sealed class AuditResult
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public double Score { get; set; }
    public string ScoreDisplayMode { get; set; } = "numeric";
    public string DisplayValue { get; set; } = string.Empty;
    public double Weight { get; set; } = 1.0;
    public List<AuditDetail> Details { get; set; } = new();
}

public sealed class AuditDetail
{
    public string Type { get; set; } = string.Empty;
    public string Label { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
    public string Severity { get; set; } = "info";
}
#pragma warning restore SA1600
