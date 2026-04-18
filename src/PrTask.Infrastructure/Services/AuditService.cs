using Microsoft.EntityFrameworkCore;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
using PrTask.Infrastructure.Data;
namespace PrTask.Infrastructure.Services;
public class AuditService(AppDbContext Db) : IAuditService
{
    public async Task<AuditLogEntity?> GetByIdAsync(string AuditLogId) =>
        await Db.AuditLogs.FindAsync(AuditLogId);
    public async Task<IReadOnlyList<AuditLogEntity>> ListByEntityAsync(string EntityType, string EntityId) =>
        await Db.AuditLogs
            .Where(A => A.EntityType == EntityType && A.EntityId == EntityId)
            .OrderByDescending(A => A.Timestamp)
            .ToListAsync();
    public async Task<IReadOnlyList<AuditLogEntity>> ListByUserAsync(string UserId) =>
        await Db.AuditLogs
            .Where(A => A.UserId == UserId)
            .OrderByDescending(A => A.Timestamp)
            .ToListAsync();
    public async Task<IReadOnlyList<AuditLogEntity>> ListRecentAsync(int Page, int PageSize)
    {
        var ClampedPageSize = Math.Min(PageSize, AuditConstants.MaxPageSize);
        var Skip = (Page - AuditConstants.FirstPage) * ClampedPageSize;
        return await Db.AuditLogs
            .OrderByDescending(A => A.Timestamp)
            .Skip(Skip)
            .Take(ClampedPageSize)
            .ToListAsync();
    }
    public async Task<long> CountAsync() =>
        await Db.AuditLogs.LongCountAsync();
}
