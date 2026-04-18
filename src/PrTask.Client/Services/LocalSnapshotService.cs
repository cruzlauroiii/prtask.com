using PrTask.Application.Services;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class LocalSnapshotService : ISnapshotService
{
    public Task<DataSnapshot?> LoadAsync() =>
        Task.FromResult<DataSnapshot?>(null);
}
