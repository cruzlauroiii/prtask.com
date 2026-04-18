using PrTask.Application.Services;
using PrTask.Domain.Models;
namespace PrTask.Infrastructure.Services;
public sealed class SnapshotService : ISnapshotService
{
    public Task<DataSnapshot?> LoadAsync() =>
        Task.FromResult<DataSnapshot?>(new DataSnapshot { GeneratedAt = DateTime.UtcNow.ToString(PrTask.Domain.Constants.AppConstants.RoundTripDateTimeFormat) });
}
