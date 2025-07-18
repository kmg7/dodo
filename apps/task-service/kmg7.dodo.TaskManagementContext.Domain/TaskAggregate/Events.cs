namespace kmg7.dodo.TaskManagementContext.Domain.TaskAggregate;

public static class Events
{
    public class TaskCreated(Guid ownerId, string title, string? description, DateTime occurredOn) : IDomainEvent
    {
        public Guid OwnerId { get; } = ownerId;
        public string Title { get; } = title;
        public string? Description { get; } = description;
        public DateTime OccurredOn { get; } = occurredOn;
    }

    public class TaskCompleted(Guid ownerId, TaskId taskId, DateTime occurredOn) : IDomainEvent
    {
        public Guid OwnerId { get; } = ownerId;
        public TaskId TaskId { get; } = taskId;
        public DateTime OccurredOn { get; } = occurredOn;
    }

    public class TaskReopened(Guid ownerId, TaskId taskId, DateTime occurredOn) : IDomainEvent
    {
        public Guid OwnerId { get; } = ownerId;
        public TaskId TaskId { get; } = taskId;
        public DateTime OccurredOn { get; } = occurredOn;
    }

    public class TaskUpdated(Guid ownerId, TaskId taskId, string title, string? description, DateTime occurredOn) : IDomainEvent
    {
        public Guid OwnerId { get; } = ownerId;
        public TaskId TaskId { get; } = taskId;
        public string Title { get; } = title;
        public string? Description { get; } = description;
        public DateTime OccurredOn { get; } = occurredOn;
    }
}
