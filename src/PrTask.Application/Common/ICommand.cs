using PrTask.Domain.Common;

namespace PrTask.Application.Common;

public interface ICommandHandler<in TCommand>
{
    Task<Result> HandleAsync(TCommand Command, CancellationToken CancellationToken = default);
}
