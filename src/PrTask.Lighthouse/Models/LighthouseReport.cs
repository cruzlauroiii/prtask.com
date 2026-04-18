namespace PrTask.Lighthouse.Models;

#pragma warning disable SA1600
public sealed class LighthouseReport
{
    public string Url { get; set; } = string.Empty;
    public DateTime AuditedAt { get; set; } = DateTime.UtcNow;
    public string UserAgent { get; set; } = string.Empty;
    public CategoryScore Performance { get; set; } = new();
    public CategoryScore Accessibility { get; set; } = new();
    public CategoryScore Seo { get; set; } = new();
    public CategoryScore BestPractices { get; set; } = new();
    public List<AuditResult> Audits { get; set; } = new();

    public double OverallScore => (Performance.Score + Accessibility.Score + Seo.Score + BestPractices.Score) / 4.0;
}

public sealed class CategoryScore
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public double Score { get; set; }
    public List<AuditResult> Audits { get; set; } = new();
}
#pragma warning restore SA1600
