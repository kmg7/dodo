using kmg7.dodo.TaskManagementContext.Domain.TaskAggregate;

namespace kmg7.dodo.TaskManagementContext.Application;

public class TaskService
{
    // ITaskAggregateRepository _taskAggregateRepository;
    public void CreateTask(Commands.CreateTaskCommand c)
    {
        // Create a new task
        // start unit of work
        DomainTask task = DomainTask.Create(c.UserId, c.Title, c.Description);
        // Try to save the task to persistence
        // commit
        // if successful client can use the query model to get the task
    }
}
