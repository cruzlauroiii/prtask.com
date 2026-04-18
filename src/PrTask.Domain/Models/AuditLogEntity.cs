namespace PrTask.Domain.Models;
public class AuditLogEntity
{
    public required string Id { get; init; }
    public string? UserId { get; init; }
    public string? EntityType { get; init; }
    public string? EntityId { get; init; }
    public string? Action { get; init; }
    public string? Changes { get; init; }
    public DateTime Timestamp { get; init; } = DateTime.UtcNow;
    public string? IpAddress { get; init; }
}
