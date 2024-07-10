using TodoDojo.Domain;

namespace TodoDojo.Infrastructure
{
    public interface ITaskRepository
    {
        Task<TaskItem?> GetByIdAsync(Guid id);
        // Other repository methods...
    }
}
