using Microsoft.EntityFrameworkCore;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
using PrTask.Infrastructure.Data;

namespace PrTask.Server;

public static partial class DemoSeedHelper
{
    private static async Task SeedSubscriptionAsync(AppDbContext Db)
    {
        if (await Db.Subscriptions.AnyAsync(S => S.Id == DemoSeedConstants.SubscriptionId))
        {
            return;
        }
        Db.Subscriptions.Add(new SubscriptionEntity
        {
            Id = DemoSeedConstants.SubscriptionId,
            CustomerId = DemoSeedConstants.ClientId,
            CardTokenId = DemoSeedConstants.SubscriptionCardTokenId,
            Description = DemoSeedConstants.SubscriptionDescription,
            AmountCents = DemoSeedConstants.SubscriptionAmountCents,
            Currency = DemoSeedConstants.SubscriptionCurrency,
            Interval = SubscriptionInterval.Month,
            IntervalCount = 1,
            StartDate = DateTimeOffset.UtcNow,
            Status = SubscriptionStatus.Active
        });
        await Db.SaveChangesAsync();
    }

    private static async Task SeedInvoiceAsync(AppDbContext Db)
    {
        if (await Db.Invoices.AnyAsync(I => I.Id == DemoSeedConstants.InvoiceId))
        {
            return;
        }
        Db.Invoices.Add(new InvoiceEntity
        {
            Id = DemoSeedConstants.InvoiceId,
            UserId = DemoSeedConstants.ClientId,
            AmountCents = DemoSeedConstants.InvoiceAmountCents,
            Currency = DemoSeedConstants.InvoiceCurrency,
            Description = DemoSeedConstants.InvoiceDescription
        });
        await Db.SaveChangesAsync();
    }

    private static async Task SeedDisbursementAsync(AppDbContext Db)
    {
        if (await Db.Disbursements.AnyAsync(D => D.Id == DemoSeedConstants.DisbursementId))
        {
            return;
        }
        Db.Disbursements.Add(new DisbursementEntity
        {
            Id = DemoSeedConstants.DisbursementId,
            BeneficiaryCount = DemoSeedConstants.DisbursementBeneficiaryCount,
            TotalAmountCents = DemoSeedConstants.DisbursementTotalAmountCents,
            Status = DisbursementStatus.Created
        });
        await Db.SaveChangesAsync();
    }

    private static async Task SeedP3RecurringPaymentAsync(AppDbContext Db)
    {
        if (await Db.P3RecurringPayments.AnyAsync(P => P.Id == DemoSeedConstants.P3RecurringPaymentId))
        {
            return;
        }
        Db.P3RecurringPayments.Add(new P3RecurringPaymentEntity
        {
            Id = DemoSeedConstants.P3RecurringPaymentId,
            OriginalTransactionRefNo = DemoSeedConstants.P3OriginalTransactionRefNo,
            FrequencyIndicator = DemoSeedConstants.P3FrequencyIndicator,
            AmountCents = DemoSeedConstants.P3RecurringAmountCents,
            Currency = DemoSeedConstants.P3RecurringCurrency
        });
        await Db.SaveChangesAsync();
    }

    private static async Task SeedRepositoryAsync(AppDbContext Db)
    {
        if (await Db.Repositories.AnyAsync(R => R.Id == DemoSeedConstants.RepositoryId))
        {
            return;
        }
        Db.Repositories.Add(new RepositoryEntity
        {
            Id = DemoSeedConstants.RepositoryId,
            OwnerId = DemoSeedConstants.ClientId,
            Url = DemoSeedConstants.RepositoryUrl,
            Name = DemoSeedConstants.RepositoryName,
            Visibility = RepositoryVisibility.Public
        });
        await Db.SaveChangesAsync();
    }
}
