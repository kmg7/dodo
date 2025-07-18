namespace kmg7.dodo.TaskManagementContext.Domain.TaskAggregate;

public class TaskTitle : ValueObject
{
    public string Value { get; set; }
    public TaskTitle(string value)
    {
        CheckValidity(value);
        Value = value;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    private static void CheckValidity(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Task title cannot be empty.");
        if (value.Length > 100)
            throw new ArgumentException("Task title cannot exceed 100 characters.");
    }
}
