using PrTask.Domain.Models;
namespace PrTask.Application.Services;
public interface IAuditService
{
    Task<AuditLogEntity?> GetByIdAsync(string AuditLogId);
    Task<IReadOnlyList<AuditLogEntity>> ListByEntityAsync(string EntityType, string EntityId);
    Task<IReadOnlyList<AuditLogEntity>> ListByUserAsync(string UserId);
    Task<IReadOnlyList<AuditLogEntity>> ListRecentAsync(int Page, int PageSize);
    Task<long> CountAsync();
}
