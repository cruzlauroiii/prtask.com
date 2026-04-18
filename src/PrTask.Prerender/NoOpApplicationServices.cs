using Microsoft.Extensions.DependencyInjection;
using PrTask.Application.Services;

namespace PrTask.Prerender;

public static class NoOpApplicationServices
{
    public static void Register(IServiceCollection Services)
    {
        Services.AddSingleton<ITaskService, NoOpTaskService>();
        Services.AddSingleton<IUserService, NoOpUserService>();
        Services.AddSingleton<ILeaderboardService, NoOpLeaderboardService>();
        Services.AddSingleton<IBoardService, NoOpBoardService>();
        Services.AddSingleton<ISprintService, NoOpSprintService>();
        Services.AddSingleton<IPullRequestService, NoOpPullRequestService>();
        Services.AddSingleton<IPaymentRecordService, NoOpPaymentRecordService>();
        Services.AddSingleton<IPaymentService, NoOpPaymentService>();
        Services.AddSingleton<IDiffComputeService, NoOpDiffComputeService>();
        Services.AddSingleton<ISyncService, NoOpSyncService>();
        Services.AddSingleton<IComplexityScoringService, NoOpComplexityScoringService>();
        Services.AddSingleton<IDiffSanitizationService, NoOpDiffSanitizationService>();
        Services.AddSingleton<IAchievementService, NoOpAchievementService>();
        Services.AddSingleton<IKycVerificationService, NoOpKycVerificationService>();
        Services.AddSingleton<ISubscriptionService, NoOpSubscriptionService>();
        Services.AddSingleton<IInvoiceService, NoOpInvoiceService>();
    }
}
