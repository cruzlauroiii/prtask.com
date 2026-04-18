using PrTask.Domain.Models;
namespace PrTask.Application.Services;
public interface IRefundService
{
    Task<RefundEntity?> GetByIdAsync(string RefundId);
    Task<IReadOnlyList<RefundEntity>> ListByPaymentIdAsync(string PaymentId);
    Task<RefundEntity> CreateRefundAsync(RefundEntity Entity);
    Task<RefundEntity?> UpdateStatusAsync(string RefundId, string Status);
    Task<bool> DeleteAsync(string RefundId);
}
