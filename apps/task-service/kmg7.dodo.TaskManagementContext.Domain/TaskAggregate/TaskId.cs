namespace kmg7.dodo.TaskManagementContext.Domain.TaskAggregate;

public class TaskId : ValueObject
{
    public Guid Value { get; set; }
    public TaskId(Guid value)
    {
        CheckValidity(value);
        Value = value;
    }

    public static TaskId New()
    {
        return new TaskId(Guid.CreateVersion7());
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    private static void CheckValidity(Guid value)
    {
        if (value == Guid.Empty)
            throw new ArgumentException("TaskId cannot be empty.");
    }
}
