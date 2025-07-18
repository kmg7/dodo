namespace kmg7.dodo.SharedKernel.Framework;

public interface IInternalEventHandler
{
    void HandleEvent(IDomainEvent @event);
}
