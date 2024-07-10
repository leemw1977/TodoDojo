namespace TodoDojo.Infrastructure
{
    public interface ITaskRepository
    {
        Task<TaskEntity?> GetByIdAsync(Guid id);
        // Other repository methods...
    }
}
