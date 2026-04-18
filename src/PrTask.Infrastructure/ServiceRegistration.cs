using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Infrastructure.Services;
namespace PrTask.Infrastructure;
public static class ServiceRegistration
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection Services)
    {
        Services.AddScoped<IUserService, UserService>();
        Services.AddScoped<IComplexityScoringService, ComplexityScoringService>();
        Services.AddScoped<IDiffSanitizationService, DiffSanitizationService>();
        Services.AddScoped<IAchievementService, AchievementService>();
        Services.AddScoped<ITaskService, TaskService>();
        Services.AddScoped<IPullRequestService, PullRequestService>();
        Services.AddScoped<IPaymentService, PaymentService>();
        Services.AddScoped<ILeaderboardService, LeaderboardService>();
        Services.AddHttpClient(AppConstants.AppName, Client => Client.BaseAddress = new Uri($"https://{AppConstants.AppDomain}"));
        return Services;
    }
}
