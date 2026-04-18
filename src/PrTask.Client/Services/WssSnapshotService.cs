using PrTask.Application.Services;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class WssSnapshotService : ISnapshotService
{
    public Task<DataSnapshot?> LoadAsync() =>
        Task.FromResult<DataSnapshot?>(null);
}
