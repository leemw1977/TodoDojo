using TodoDojo.Dtos;

namespace TodoDojo.Application
{
    public interface ITaskService
    {
        Task<TaskDto?> GetTaskAsync(Guid id);
        // Other service methods...
    }
}
