using PrTask.Domain.Models;
namespace PrTask.Application.Contracts;
public record AuditLogDto(
    string Id, string? UserId, string? EntityType, string? EntityId,
    string? Action, string? Changes, DateTime Timestamp, string? IpAddress)
{
    public static AuditLogDto FromEntity(AuditLogEntity E) =>
        new(E.Id, E.UserId, E.EntityType, E.EntityId,
            E.Action, E.Changes, E.Timestamp, E.IpAddress);
}
