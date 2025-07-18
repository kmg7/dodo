using kmg7.dodo.SharedKernel.Framework;

namespace kmg7.dodo.SharedKernel.Tests.Framework;
public class TestEntity : Entity<TestEntityId>
{
    public string Name { get; private set; }
    public int MyProperty { get; set; }
    public TestEntity(TestEntityId id, string name, Action<IDomainEvent> eventApplier) : base(eventApplier)
    {
        Id = id;
        Name = name;
    }

    public void ChangeName(string newName)
    {
        var @event = new TestEntityNameChangedEvent(DateTime.UtcNow, newName);
        ApplyEvent(@event);
    }

    protected override void Mutate(IDomainEvent @event)
    {
        switch (@event)
        {
            case TestEntityNameChangedEvent nameChangedEvent:
                When(nameChangedEvent);
                break;
            default:
                throw new ArgumentException($"Unknown event type: {@event.GetType()}");
        }
    }

    private void When(TestEntityNameChangedEvent @event)
    {
        Name = @event.NewName;
    }
}

public class TestEntityNameChangedEvent : IDomainEvent
{
    public DateTime OccurredOn { get; }
    public int Version { get; } = 1;
    public string NewName { get; }
    public TestEntityNameChangedEvent(DateTime occurredOn, string newName)
    {
        OccurredOn = occurredOn;
        NewName = newName;
    }
}


public class TestEntityId : ValueObject
{
    public int Id { get; }
    public TestEntityId(int id)
    {
        Id = id;
    }
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Id;
    }
}
