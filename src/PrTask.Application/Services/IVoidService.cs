using PrTask.Domain.Models;
namespace PrTask.Application.Services;
public interface IVoidService
{
    Task<VoidEntity?> GetByIdAsync(string VoidId);
    Task<IReadOnlyList<VoidEntity>> ListByPaymentIdAsync(string PaymentId);
    Task<VoidEntity> CreateVoidAsync(VoidEntity Entity);
    Task<VoidEntity?> UpdateStatusAsync(string VoidId, string Status);
    Task<bool> DeleteAsync(string VoidId);
}
