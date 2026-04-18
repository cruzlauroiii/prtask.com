using System.Security.Claims;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Infrastructure.Data;
public class AuditSaveChangesInterceptor(IHttpContextAccessor HttpContextAccessor) : SaveChangesInterceptor
{
    private List<AuditLogEntity> PendingAuditEntries { get; } = [];
    public override InterceptionResult<int> SavingChanges(DbContextEventData EventData, InterceptionResult<int> Result)
    {
        CollectAuditEntries(EventData.Context);
        return base.SavingChanges(EventData, Result);
    }
    public override ValueTask<InterceptionResult<int>> SavingChangesAsync(
        DbContextEventData EventData,
        InterceptionResult<int> Result,
        CancellationToken CancellationToken = default)
    {
        CollectAuditEntries(EventData.Context);
        return base.SavingChangesAsync(EventData, Result, CancellationToken);
    }
    public override int SavedChanges(SaveChangesCompletedEventData EventData, int Result)
    {
        WriteAuditEntries(EventData.Context);
        return base.SavedChanges(EventData, Result);
    }
    public override async ValueTask<int> SavedChangesAsync(
        SaveChangesCompletedEventData EventData,
        int Result,
        CancellationToken CancellationToken = default)
    {
        await WriteAuditEntriesAsync(EventData.Context, CancellationToken);
        return await base.SavedChangesAsync(EventData, Result, CancellationToken);
    }
    private void CollectAuditEntries(DbContext? Context)
    {
        if (Context is null)
        {
            return;
        }
        PendingAuditEntries.Clear();
        var CurrentUserId = HttpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
        var CurrentIpAddress = ResolveIpAddress();
        var TrackedEntries = Context.ChangeTracker.Entries()
            .Where(E => E.Entity is not AuditLogEntity &&
                        E.State is EntityState.Added or EntityState.Modified or EntityState.Deleted)
            .ToList();
        foreach (var TrackedEntry in TrackedEntries)
        {
            var AuditEntry = new AuditLogEntity
            {
                Id = Guid.NewGuid().ToString(),
                UserId = CurrentUserId,
                EntityType = TrackedEntry.Metadata.ClrType.Name,
                EntityId = ResolveEntityId(TrackedEntry),
                Action = ResolveAction(TrackedEntry.State),
                Changes = SerializeChanges(TrackedEntry),
                Timestamp = DateTime.UtcNow,
                IpAddress = CurrentIpAddress
            };
            PendingAuditEntries.Add(AuditEntry);
        }
    }
    private void WriteAuditEntries(DbContext? Context)
    {
        if (Context is null || PendingAuditEntries.Count < AuditConstants.FirstPage)
        {
            return;
        }
        Context.Set<AuditLogEntity>().AddRange(PendingAuditEntries);
        PendingAuditEntries.Clear();
        Context.SaveChanges();
    }
    private async Task WriteAuditEntriesAsync(DbContext? Context, CancellationToken CancellationToken)
    {
        if (Context is null || PendingAuditEntries.Count < AuditConstants.FirstPage)
        {
            return;
        }
        Context.Set<AuditLogEntity>().AddRange(PendingAuditEntries);
        PendingAuditEntries.Clear();
        await Context.SaveChangesAsync(CancellationToken);
    }
    private string? ResolveIpAddress()
    {
        var HttpContext = HttpContextAccessor.HttpContext;
        var ForwardedFor = HttpContext?.Request.Headers[AuditConstants.XForwardedForHeader].FirstOrDefault();
        return !string.IsNullOrEmpty(ForwardedFor)
            ? ForwardedFor.Split(',')[0].Trim()
            : HttpContext?.Connection.RemoteIpAddress?.ToString();
    }
    private static string ResolveAction(EntityState State) => State switch
    {
        EntityState.Added => AuditConstants.ActionCreated,
        EntityState.Modified => AuditConstants.ActionUpdated,
        EntityState.Deleted => AuditConstants.ActionDeleted,
        EntityState.Detached => State.ToString(),
        EntityState.Unchanged => State.ToString(),
        _ => State.ToString()
    };
    private static string? ResolveEntityId(EntityEntry Entry)
    {
        var PrimaryKey = Entry.Properties.FirstOrDefault(P => P.Metadata.IsPrimaryKey());
        return PrimaryKey?.CurrentValue?.ToString();
    }
    private static string? SerializeChanges(EntityEntry Entry)
    {
        if (Entry.State == EntityState.Added)
        {
            var NewValues = Entry.Properties
                .Where(P => P.CurrentValue is not null)
                .ToDictionary(P => P.Metadata.Name, P => P.CurrentValue);
            return JsonSerializer.Serialize(NewValues, JsonSerializerOptions.Default);
        }
        if (Entry.State == EntityState.Deleted)
        {
            var OldValues = Entry.Properties
                .Where(P => P.OriginalValue is not null)
                .ToDictionary(P => P.Metadata.Name, P => P.OriginalValue);
            return JsonSerializer.Serialize(OldValues, JsonSerializerOptions.Default);
        }
        if (Entry.State == EntityState.Modified)
        {
            var ChangedProperties = Entry.Properties
                .Where(P => P.IsModified)
                .Select(P => new Dictionary<string, object?>
                {
                    [AuditConstants.ChangesPropertyKey] = P.Metadata.Name,
                    [AuditConstants.ChangesOldValueKey] = P.OriginalValue,
                    [AuditConstants.ChangesNewValueKey] = P.CurrentValue
                })
                .ToList();
            return JsonSerializer.Serialize(ChangedProperties, JsonSerializerOptions.Default);
        }
        return null;
    }
}
