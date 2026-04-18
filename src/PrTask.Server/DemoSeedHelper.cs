using Microsoft.EntityFrameworkCore;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
using PrTask.Infrastructure.Data;

namespace PrTask.Server;

public static partial class DemoSeedHelper
{
    public static async Task SeedAsync(AppDbContext Db, IServiceProvider Services)
    {
        await SeedUsersAsync(Db);
        await SeedTaskAsync(Db);
        await SeedPullRequestAsync(Db);
        await SeedSprintAsync(Db);
        await SeedBoardAsync(Db);
        await SeedBoardColumnsAsync(Db);
        await SeedPaymentAsync(Db);
        await SeedRefundAsync(Db);
        await SeedVoidAsync(Db);
        await SeedBillPaymentAsync(Db);
        await SeedAchievementAsync(Db);
        await SeedSubscriptionAsync(Db);
        await SeedInvoiceAsync(Db);
        await SeedDisbursementAsync(Db);
        await SeedP3RecurringPaymentAsync(Db);
        await SeedRepositoryAsync(Db);
        await SeedReviewCommentsAsync(Services);
    }

    private static async Task SeedUsersAsync(AppDbContext Db)
    {
        if (!await Db.Users.AnyAsync(U => U.Id == DemoSeedConstants.ClientId))
        {
            Db.Users.Add(new UserEntity
            {
                Id = DemoSeedConstants.ClientId,
                DisplayName = DemoSeedConstants.ClientDisplayName,
                Email = DemoSeedConstants.ClientEmail,
                Role = UserRole.Client,
                TotalSpentCents = DemoSeedConstants.ClientSpentCents
            });
            await Db.SaveChangesAsync();
        }
        if (!await Db.Users.AnyAsync(U => U.Id == DemoSeedConstants.DeveloperId))
        {
            Db.Users.Add(new UserEntity
            {
                Id = DemoSeedConstants.DeveloperId,
                DisplayName = DemoSeedConstants.DeveloperDisplayName,
                Email = DemoSeedConstants.DeveloperEmail,
                Role = UserRole.Developer,
                TotalEarnedCents = DemoSeedConstants.DeveloperEarnedCents
            });
            await Db.SaveChangesAsync();
        }
    }

    private static async Task SeedTaskAsync(AppDbContext Db)
    {
        if (await Db.Tasks.AnyAsync(T => T.Id == DemoSeedConstants.TaskId))
        {
            return;
        }
        Db.Tasks.Add(new TaskEntity
        {
            Id = DemoSeedConstants.TaskId,
            ClientId = DemoSeedConstants.ClientId,
            Title = DemoSeedConstants.TaskTitle,
            Description = DemoSeedConstants.TaskDescription,
            RepoUrl = DemoSeedConstants.RepoUrl,
            Complexity = TaskComplexity.Complex,
            BountyAmountCents = DemoSeedConstants.BountyAmountCents,
            Tags = [DemoSeedConstants.TagCsharp, DemoSeedConstants.TagPayments, DemoSeedConstants.TagRefactor],
            Deadline = DateTime.UtcNow.AddDays(DemoSeedConstants.DeadlineDays)
        });
        await Db.SaveChangesAsync();
    }

    private static async Task SeedPullRequestAsync(AppDbContext Db)
    {
        if (await Db.PullRequests.AnyAsync(P => P.Id == DemoSeedConstants.PrId))
        {
            return;
        }
        Db.PullRequests.Add(new PullRequestEntity
        {
            Id = DemoSeedConstants.PrId,
            TaskId = DemoSeedConstants.TaskId,
            DeveloperId = DemoSeedConstants.DeveloperId,
            GitHubPrUrl = DemoSeedConstants.GitHubPrUrl,
            FilesChanged = DemoSeedConstants.FilesChanged,
            Additions = DemoSeedConstants.Additions,
            Deletions = DemoSeedConstants.Deletions,
            ComplexityScore = DemoSeedConstants.ComplexityScore
        });
        await Db.SaveChangesAsync();
    }

    private static async Task SeedSprintAsync(AppDbContext Db)
    {
        if (await Db.Sprints.AnyAsync(S => S.Id == DemoSeedConstants.SprintId))
        {
            return;
        }
        Db.Sprints.Add(new SprintEntity
        {
            Id = DemoSeedConstants.SprintId,
            Name = DemoSeedConstants.SprintName,
            Goal = DemoSeedConstants.SprintGoal,
            OwnerId = DemoSeedConstants.ClientId,
            Status = SprintStatus.Active,
            StartDate = DateTime.UtcNow,
            EndDate = DateTime.UtcNow.AddDays(DemoSeedConstants.SprintDurationDays)
        });
        await Db.SaveChangesAsync();
    }

    private static async Task SeedBoardAsync(AppDbContext Db)
    {
        if (await Db.Boards.AnyAsync(B => B.Id == DemoSeedConstants.BoardId))
        {
            return;
        }
        Db.Boards.Add(new BoardEntity
        {
            Id = DemoSeedConstants.BoardId,
            Name = DemoSeedConstants.BoardName,
            OwnerId = DemoSeedConstants.ClientId,
            Type = BoardType.Scrum,
            SprintId = DemoSeedConstants.SprintId
        });
        await Db.SaveChangesAsync();
    }

    private static async Task SeedBoardColumnsAsync(AppDbContext Db)
    {
        if (await Db.BoardColumns.AnyAsync(C => C.Id == DemoSeedConstants.ColumnTodoId))
        {
            return;
        }
        Db.BoardColumns.AddRange(
            new BoardColumnEntity { Id = DemoSeedConstants.ColumnTodoId, BoardId = DemoSeedConstants.BoardId, Name = DemoSeedConstants.ColumnTodoName, Order = 0 },
            new BoardColumnEntity { Id = DemoSeedConstants.ColumnInProgressId, BoardId = DemoSeedConstants.BoardId, Name = DemoSeedConstants.ColumnInProgressName, Order = 1, WipLimit = DemoSeedConstants.ColumnWipLimit },
            new BoardColumnEntity { Id = DemoSeedConstants.ColumnDoneId, BoardId = DemoSeedConstants.BoardId, Name = DemoSeedConstants.ColumnDoneName, Order = 2 });
        await Db.SaveChangesAsync();
    }

    private static async Task SeedPaymentAsync(AppDbContext Db)
    {
        if (await Db.Payments.AnyAsync(P => P.Id == DemoSeedConstants.PaymentId))
        {
            return;
        }
        Db.Payments.Add(new PaymentEntity
        {
            Id = DemoSeedConstants.PaymentId,
            PayerId = DemoSeedConstants.ClientId,
            PayeeId = DemoSeedConstants.DeveloperId,
            TaskId = DemoSeedConstants.TaskId,
            PullRequestId = DemoSeedConstants.PrId,
            AmountCents = DemoSeedConstants.PaymentAmountCents,
            Type = PaymentType.AutomaticCharge,
            Status = PaymentStatus.Completed
        });
        await Db.SaveChangesAsync();
    }

    private static async Task SeedRefundAsync(AppDbContext Db)
    {
        if (await Db.Refunds.AnyAsync(R => R.Id == DemoSeedConstants.RefundId))
        {
            return;
        }
        Db.Refunds.Add(new RefundEntity
        {
            Id = DemoSeedConstants.RefundId,
            PaymentId = DemoSeedConstants.PaymentId,
            Reason = DemoSeedConstants.RefundReason,
            AmountCents = DemoSeedConstants.RefundAmountCents,
            Currency = DemoSeedConstants.RefundCurrency
        });
        await Db.SaveChangesAsync();
    }

    private static async Task SeedVoidAsync(AppDbContext Db)
    {
        if (await Db.Voids.AnyAsync(V => V.Id == DemoSeedConstants.VoidId))
        {
            return;
        }
        Db.Voids.Add(new VoidEntity
        {
            Id = DemoSeedConstants.VoidId,
            PaymentId = DemoSeedConstants.PaymentId,
            Reason = DemoSeedConstants.VoidReason,
            AmountCents = DemoSeedConstants.VoidAmountCents
        });
        await Db.SaveChangesAsync();
    }

    private static async Task SeedBillPaymentAsync(AppDbContext Db)
    {
        if (await Db.BillPayments.AnyAsync(B => B.Id == DemoSeedConstants.BillPaymentId))
        {
            return;
        }
        Db.BillPayments.Add(new BillPaymentEntity
        {
            Id = DemoSeedConstants.BillPaymentId,
            BillerSlug = DemoSeedConstants.BillerSlug,
            AccountNumber = DemoSeedConstants.BillerAccountNumber,
            AmountCents = DemoSeedConstants.BillAmountCents
        });
        await Db.SaveChangesAsync();
    }

    private static async Task SeedAchievementAsync(AppDbContext Db)
    {
        if (await Db.Achievements.AnyAsync(A => A.Id == DemoSeedConstants.AchievementId))
        {
            return;
        }
        Db.Achievements.Add(new AchievementEntity
        {
            Id = DemoSeedConstants.AchievementId,
            UserId = DemoSeedConstants.DeveloperId,
            BadgeType = BadgeConstants.FirstPrMerged
        });
        await Db.SaveChangesAsync();
    }

    private static async Task SeedReviewCommentsAsync(IServiceProvider Services)
    {
        var CommentSvc = Services.GetRequiredService<IReviewCommentService>();
        var Existing = await CommentSvc.ListByPullRequestAsync(DemoSeedConstants.PrId);
        if (Existing.Count == 0)
        {
            await CommentSvc.CreateAsync(new ReviewComment
            {
                PullRequestId = DemoSeedConstants.PrId,
                AuthorId = DemoSeedConstants.ClientId,
                FilePath = DemoSeedConstants.ExampleFilePath,
                LineNumber = DemoSeedConstants.Comment1Line,
                Body = DemoSeedConstants.Comment1Body
            });
            await CommentSvc.CreateAsync(new ReviewComment
            {
                PullRequestId = DemoSeedConstants.PrId,
                AuthorId = DemoSeedConstants.ClientId,
                FilePath = DemoSeedConstants.ExampleFilePath,
                LineNumber = DemoSeedConstants.Comment2Line,
                Body = DemoSeedConstants.Comment2Body
            });
        }
    }
}
