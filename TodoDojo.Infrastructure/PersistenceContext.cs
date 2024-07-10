using Microsoft.EntityFrameworkCore;
using TodoDojo.Domain;

namespace TodoDojo.Infrastructure
{
    public class PersistenceContext : DbContext
    {
        internal DbSet<TaskItem> TaskItems { get; set; }
    }
}
