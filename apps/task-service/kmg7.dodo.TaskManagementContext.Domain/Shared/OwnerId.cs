namespace kmg7.dodo.TaskManagementContext.Domain.Shared;

public class OwnerId : ValueObject
{
    public Guid Value { get; private set; }
    public OwnerId(Guid value)
    {
        if (value == default)
            throw new ArgumentNullException(nameof(value), "OwnerId cannot be empty.");

        Value = value;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
