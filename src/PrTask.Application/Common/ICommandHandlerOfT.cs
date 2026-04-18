using PrTask.Domain.Common;

namespace PrTask.Application.Common;

public interface ICommandHandler<in TCommand, TResponse>
{
    Task<Result<TResponse>> HandleAsync(TCommand Command, CancellationToken CancellationToken = default);
}
