using PrTask.Domain.Common;

namespace PrTask.Application.Common;

public interface IUseCase<in TRequest, TResponse>
{
    Task<Result<TResponse>> ExecuteAsync(TRequest Request, CancellationToken CancellationToken = default);
}
