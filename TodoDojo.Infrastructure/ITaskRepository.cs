namespace TodoDojo.Infrastructure
{
    public interface ITaskRepository
    {
        Task<TaskEntity?> GetByIdAsync(Guid id);
        Task<IList<TaskEntity>> GetAllTasks();
        // Other repository methods...
    }
}
