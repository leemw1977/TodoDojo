using TodoDojo.Dtos;

namespace TodoDojo.Application
{
    public interface ITaskService
    {
        Task<TaskDto?> GetTaskAsync(Guid id);
        Task<IList<TaskDto>> GetAllOpenTasks();
    }
}
