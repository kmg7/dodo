namespace kmg7.dodo.SharedKernel.Framework;

public abstract class AggregateRoot<TId> : IInternalEventHandler where TId : ValueObject
{
    public TId Id { get; protected set; }
    public int Version { get; private set; }
    protected readonly List<IDomainEvent> _changes;

    protected AggregateRoot()
    {
        _changes = [];
        Version = -1;
    }

    protected abstract void Mutate(IDomainEvent @event);
    protected abstract void EnsureValidState();

    protected void Apply(IDomainEvent @event)
    {
        Mutate(@event);
        EnsureValidState();
        _changes.Add(@event);
    }

    protected void ApplyToEntity(IInternalEventHandler entity, IDomainEvent @event)
    {
        entity.HandleEvent(@event);
    }

    public void HandleEvent(IDomainEvent @event)
    {
        Mutate(@event);
    }

    public void LoadFromHistory(IEnumerable<IDomainEvent> history)
    {
        foreach (var @event in history)
        {
            Mutate(@event);
            Version++;
        }
    }

    public IEnumerable<IDomainEvent> GetChanges()
    {
        return _changes.AsEnumerable();
    }

    public void ClearChanges()
    {
        _changes.Clear();
    }
}
