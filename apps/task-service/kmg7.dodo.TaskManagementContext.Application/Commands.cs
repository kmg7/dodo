namespace kmg7.dodo.TaskManagementContext.Application;
public static class Commands
{
    public record CreateTaskCommand(Guid UserId, string Title, string? Description);
    public record UpdateTaskCommand(Guid UserId, Guid TaskId, string Title, string? Description);
    public record CompleteTaskCommand(Guid UserId, Guid TaskId);
}
