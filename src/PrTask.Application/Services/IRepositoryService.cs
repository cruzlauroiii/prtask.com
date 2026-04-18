using PrTask.Domain.Models;
namespace PrTask.Application.Services;
public interface IRepositoryService
{
    Task<RepositoryEntity?> GetByIdAsync(string RepositoryId);
    Task<IReadOnlyList<RepositoryEntity>> ListByOwnerAsync(string OwnerId);
    Task<RepositoryEntity> CreateAsync(RepositoryEntity Entity);
    Task<RepositoryEntity> UpdateAsync(RepositoryEntity Entity);
    Task DeleteAsync(string RepositoryId);
}
