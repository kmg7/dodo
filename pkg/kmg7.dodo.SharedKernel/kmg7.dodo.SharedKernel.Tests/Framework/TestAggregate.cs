using kmg7.dodo.SharedKernel.Framework;

namespace kmg7.dodo.SharedKernel.Tests.Framework;
public class TestAggregate : AggregateRoot<TestAggregateId>
{
    public TestValueObject ValueA { get; set; }
    public List<TestEntity> Entities { get; set; } = [];

    protected override void EnsureValidState()
    {
        throw new NotImplementedException();
    }

    protected override void Mutate(IDomainEvent @event)
    {
        throw new NotImplementedException();
    }
}



public class TestAggregateId : ValueObject
{
    public int Id { get; }
    public TestAggregateId(int id)
    {
        Id = id;
    }
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Id;
    }
}
