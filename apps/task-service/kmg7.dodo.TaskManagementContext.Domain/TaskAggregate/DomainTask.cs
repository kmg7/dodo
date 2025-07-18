namespace kmg7.dodo.TaskManagementContext.Domain.TaskAggregate;

public class DomainTask : AggregateRoot<TaskId>
{
    public TaskTitle Title { get; set; }
    public TaskDescription Description { get; set; }
    public bool Completed { get; set; }
    public OwnerId OwnerId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? CompletedAt { get; set; }

    protected override void EnsureValidState()
    {
        var valid =
            Title != null &&
            Id != null &&
            OwnerId != null &&

                Completed switch
                {
                    true => CompletedAt != null,
                    false => CompletedAt == null
                };

        if (!valid)
            throw new InvalidOperationException("Task is in an invalid state.");
    }

    protected override void Mutate(IDomainEvent @event)
    {
        switch (@event)
        {
            case Events.TaskCreated e:
                When(e);
                break;
            case Events.TaskCompleted e:
                When(e);
                break;
            case Events.TaskReopened e:
                When(e);
                break;
            case Events.TaskUpdated e:
                When(e);
                break;
            default:
                throw new NotImplementedException($"Event type {@event.GetType()} not handled.");
        }
    }

    private void When(Events.TaskCreated e)
    {
        Id = TaskId.New();
        OwnerId = new OwnerId(e.OwnerId);
        Title = new TaskTitle(e.Title);
        Description = new TaskDescription(e.Description);
        CreatedAt = e.OccurredOn;
        UpdatedAt = e.OccurredOn;
    }

    private void When(Events.TaskCompleted e)
    {
        Completed = true;
        CompletedAt = e.OccurredOn;
        UpdatedAt = e.OccurredOn;
    }

    private void When(Events.TaskReopened e)
    {
        Completed = false;
        CompletedAt = null;
        UpdatedAt = e.OccurredOn;
    }

    private void When(Events.TaskUpdated e)
    {
        Title = new TaskTitle(e.Title);
        Description = new TaskDescription(e.Description);
        UpdatedAt = e.OccurredOn;
    }

    public static DomainTask Create(Guid ownerId, string title, string? description)
    {
        var @event = new Events.TaskCreated(ownerId, title, description, DateTime.UtcNow);
        var task = new DomainTask();
        task.Apply(@event);
        return task;
    }

    public void Complete()
    {
        if (Completed)
            throw new InvalidOperationException("Task is already completed.");
        var @event = new Events.TaskCompleted(OwnerId.Value, Id, DateTime.UtcNow);
        Apply(@event);
    }

    public void Reopen()
    {
        if (!Completed)
            throw new InvalidOperationException("Task is not completed.");
        var @event = new Events.TaskReopened(OwnerId.Value, Id, DateTime.UtcNow);
        Apply(@event);
    }

    public void Update(string title, string? description)
    {
        var @event = new Events.TaskUpdated(OwnerId.Value, Id, title, description, DateTime.UtcNow);
        Apply(@event);
    }
}
