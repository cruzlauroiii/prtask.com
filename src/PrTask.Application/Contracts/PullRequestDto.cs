using PrTask.Domain.Models;
namespace PrTask.Application.Contracts;
public record PullRequestDto(
    string Id, string TaskId, string DeveloperId, string? GitHubPrUrl,
    int FilesChanged, int Additions, int Deletions, int ComplexityScore,
    PullRequestStatus Status, string? ReviewerNotes, DateTime SubmittedAt,
    DateTime? ReviewedAt, DateTime? MergedAt, DateTime? PaidAt)
{
    public static PullRequestDto FromEntity(PullRequestEntity E) =>
        new(E.Id, E.TaskId, E.DeveloperId, E.GitHubPrUrl, E.FilesChanged,
            E.Additions, E.Deletions, E.ComplexityScore, E.Status,
            E.ReviewerNotes, E.SubmittedAt, E.ReviewedAt, E.MergedAt, E.PaidAt);
}
