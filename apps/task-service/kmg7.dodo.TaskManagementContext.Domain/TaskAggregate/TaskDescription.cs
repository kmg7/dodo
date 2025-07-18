namespace kmg7.dodo.TaskManagementContext.Domain.TaskAggregate;

public class TaskDescription : ValueObject
{
    public string? Value { get; set; }
    public TaskDescription(string? value)
    {
        CheckValidity(value);
        Value = value;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    private static void CheckValidity(string? value)
    {
        if (value == null)
            return;
        if (value.Length > 1000)
            throw new ArgumentException("Task description cannot exceed 1000 characters.");
    }
}
