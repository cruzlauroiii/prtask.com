namespace PrTask.Domain.Models;
public class PullRequestEntity
{
    public required string Id { get; init; }
    public required string TaskId { get; init; }
    public required string DeveloperId { get; init; }
    public string? GitHubPrUrl { get; set; }
    public string? DiffStorageKey { get; set; }
    public int FilesChanged { get; set; }
    public int Additions { get; set; }
    public int Deletions { get; set; }
    public int ComplexityScore { get; set; }
    public PullRequestStatus Status { get; set; } = PullRequestStatus.Submitted;
    public string? ReviewerNotes { get; set; }
    public DateTime SubmittedAt { get; init; } = DateTime.UtcNow;
    public DateTime? ReviewedAt { get; set; }
    public DateTime? MergedAt { get; set; }
    public DateTime? PaidAt { get; set; }
}
