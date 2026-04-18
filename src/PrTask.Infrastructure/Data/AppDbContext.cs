using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using PrTask.Domain.Models;
namespace PrTask.Infrastructure.Data;
public class AppDbContext(DbContextOptions<AppDbContext> Options) : DbContext(Options)
{
    public DbSet<TaskEntity> Tasks => Set<TaskEntity>();
    public DbSet<UserEntity> Users => Set<UserEntity>();
    public DbSet<PullRequestEntity> PullRequests => Set<PullRequestEntity>();
    public DbSet<PaymentEntity> Payments => Set<PaymentEntity>();
    public DbSet<AchievementEntity> Achievements => Set<AchievementEntity>();
    public DbSet<LeaderboardEntry> LeaderboardEntries => Set<LeaderboardEntry>();
    public DbSet<SprintEntity> Sprints => Set<SprintEntity>();
    public DbSet<BoardEntity> Boards => Set<BoardEntity>();
    public DbSet<BoardColumnEntity> BoardColumns => Set<BoardColumnEntity>();
    public DbSet<SubscriptionEntity> Subscriptions => Set<SubscriptionEntity>();
    public DbSet<InvoiceEntity> Invoices => Set<InvoiceEntity>();
    public DbSet<DisbursementEntity> Disbursements => Set<DisbursementEntity>();
    public DbSet<VoidEntity> Voids => Set<VoidEntity>();
    public DbSet<RefundEntity> Refunds => Set<RefundEntity>();
    public DbSet<BillPaymentEntity> BillPayments => Set<BillPaymentEntity>();
    public DbSet<P3RecurringPaymentEntity> P3RecurringPayments => Set<P3RecurringPaymentEntity>();
    public DbSet<RepositoryEntity> Repositories => Set<RepositoryEntity>();
    public DbSet<AuditLogEntity> AuditLogs => Set<AuditLogEntity>();
    protected override void OnModelCreating(ModelBuilder Builder)
    {
        Builder.Entity<LeaderboardEntry>().HasKey(E => E.UserId);
        Builder.Entity<TaskEntity>()
            .Property(E => E.Tags)
            .HasConversion(
                V => V == null ? null : JsonSerializer.Serialize(V, JsonSerializerOptions.Default),
                V => V == null ? null : JsonSerializer.Deserialize<string[]>(V, JsonSerializerOptions.Default));
        Builder.Entity<UserEntity>().HasIndex(E => E.GitHubId);
        Builder.Entity<PullRequestEntity>().HasIndex(E => E.TaskId);
        Builder.Entity<PullRequestEntity>().HasIndex(E => E.DeveloperId);
        Builder.Entity<PaymentEntity>().HasIndex(E => E.TaskId);
        Builder.Entity<PaymentEntity>().HasIndex(E => E.PayerId);
        Builder.Entity<PaymentEntity>().HasIndex(E => E.MayaPaymentId);
        Builder.Entity<AchievementEntity>().HasIndex(E => E.UserId);
        Builder.Entity<LeaderboardEntry>().HasIndex(E => E.TotalEarnedCents);
        Builder.Entity<LeaderboardEntry>().HasIndex(E => E.TotalSpentCents);
        Builder.Entity<TaskEntity>().HasIndex(E => E.ParentId);
        Builder.Entity<TaskEntity>().HasIndex(E => E.SprintId);
        Builder.Entity<TaskEntity>().HasIndex(E => E.BoardColumnId);
        Builder.Entity<SprintEntity>().HasIndex(E => E.OwnerId);
        Builder.Entity<BoardEntity>().HasIndex(E => E.OwnerId);
        Builder.Entity<BoardColumnEntity>().HasIndex(E => E.BoardId);
        Builder.Entity<SubscriptionEntity>().HasIndex(E => E.CustomerId);
        Builder.Entity<SubscriptionEntity>().HasIndex(E => E.CardTokenId);
        Builder.Entity<SubscriptionEntity>().HasIndex(E => E.MayaSubscriptionId);
        Builder.Entity<InvoiceEntity>().HasIndex(E => E.UserId);
        Builder.Entity<InvoiceEntity>().HasIndex(E => E.MayaInvoiceId);
        Builder.Entity<DisbursementEntity>().HasIndex(E => E.Status);
        Builder.Entity<VoidEntity>().HasIndex(E => E.PaymentId);
        Builder.Entity<RefundEntity>().HasIndex(E => E.PaymentId);
        Builder.Entity<RepositoryEntity>().HasIndex(E => E.OwnerId);
        Builder.Entity<AuditLogEntity>().HasIndex(E => E.UserId);
        Builder.Entity<AuditLogEntity>().HasIndex(E => E.EntityType);
        Builder.Entity<AuditLogEntity>().HasIndex(E => E.EntityId);
        Builder.Entity<AuditLogEntity>().HasIndex(E => E.Timestamp);
    }
}
