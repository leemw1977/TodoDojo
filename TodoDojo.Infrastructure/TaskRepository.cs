using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public async Task<TaskItem?> GetByIdAsync(Guid id)
        {
            return await _context.TaskItems.FindAsync(id);
        }

        // Other methods...
    }
}
