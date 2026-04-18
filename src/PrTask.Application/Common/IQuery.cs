using PrTask.Domain.Common;

namespace PrTask.Application.Common;

public interface IQueryHandler<in TQuery, TResponse>
{
    Task<Result<TResponse>> HandleAsync(TQuery Query, CancellationToken CancellationToken = default);
}
