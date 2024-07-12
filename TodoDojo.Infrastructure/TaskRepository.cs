using Microsoft.EntityFrameworkCore;
using TodoDojo.Domain;

namespace TodoDojo.Infrastructure
{
    public class TaskRepository : ITaskRepository
    {
        private readonly PersistenceContext _context;

        public TaskRepository(PersistenceContext context)
        {
            _context = context;
        }

        public async Task<IList<TaskEntity>> GetAllTasks()
        {
            return await _context.TaskItems
                                         .Where(t => t.Status != Status.Completed)
                                         .ToListAsync();
        }

        public async Task<TaskEntity?> GetByIdAsync(Guid id)
        {
            return await _context.TaskItems.FindAsync(id);
        }

        // Other methods...
    }
}
