namespace kmg7.dodo.SharedKernel.Framework;

public abstract class Entity<TId> : IInternalEventHandler where TId : ValueObject
{
    public TId Id { get; protected set; }
    private readonly Action<IDomainEvent> _eventApplier;

    protected Entity(Action<IDomainEvent> eventApplier)
    {
        _eventApplier = eventApplier;
    }

    protected abstract void Mutate(IDomainEvent @event);

    public void ApplyEvent(IDomainEvent @event)
    {
        Mutate(@event);
        _eventApplier(@event);
    }

    public void HandleEvent(IDomainEvent @event)
    {
        Mutate(@event);
    }
}
