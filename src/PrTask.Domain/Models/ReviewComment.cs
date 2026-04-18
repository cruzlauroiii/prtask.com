namespace PrTask.Domain.Models;
public class ReviewComment
{
    public string Id { get; init; } = Guid.NewGuid().ToString();
    public string PullRequestId { get; init; } = string.Empty;
    public string AuthorId { get; init; } = string.Empty;
    public string FilePath { get; set; } = string.Empty;
    public int LineNumber { get; set; }
    public string Body { get; set; } = string.Empty;
    public string? ParentCommentId { get; set; }
    public bool IsResolved { get; set; }
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
}
