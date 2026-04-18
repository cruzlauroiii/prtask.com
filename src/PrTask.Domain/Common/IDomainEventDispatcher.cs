namespace PrTask.Domain.Common;

public interface IDomainEventDispatcher
{
    Task DispatchAsync(IReadOnlyList<DomainEvent> DomainEvents, CancellationToken CancellationToken = default);
}
