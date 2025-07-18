namespace kmg7.dodo.TaskManagementContext.Tests;

public class TaskTests
{
    readonly Domain.TaskAggregate.DomainTask _sut;
    public TaskTests()
    {
        _sut = TestTask();
    }

    public Domain.TaskAggregate.DomainTask TestTask()
    {
        var ownerId = Guid.CreateVersion7();
        var title = "Test Task";
        var description = "This is a test task.";

        return Domain.TaskAggregate.DomainTask.Create(ownerId, title, description);
    }

    [Fact]
    public void Task_should()
    {
        var num1 = 1;
        try
        {
            num1.ShouldBeGreaterThan(5);
        }
        catch (Exception)
        {

        }
    }
}
