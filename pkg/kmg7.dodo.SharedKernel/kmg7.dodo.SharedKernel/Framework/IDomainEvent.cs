namespace kmg7.dodo.SharedKernel.Framework;

public interface IDomainEvent
{
    DateTime OccurredOn { get; }
}
