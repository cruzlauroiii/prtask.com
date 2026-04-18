using PrTask.Domain.Models;
namespace PrTask.Application.Services;
public interface ISnapshotService
{
    Task<DataSnapshot?> LoadAsync();
}
