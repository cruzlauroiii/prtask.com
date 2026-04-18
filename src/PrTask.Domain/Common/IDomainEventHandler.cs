namespace PrTask.Domain.Common;

public interface IDomainEventSubscriber<in TEvent> where TEvent : DomainEvent
{
    Task HandleAsync(TEvent DomainEvent, CancellationToken CancellationToken = default);
}
