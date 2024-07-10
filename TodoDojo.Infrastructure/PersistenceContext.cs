using Microsoft.EntityFrameworkCore;

namespace TodoDojo.Infrastructure
{
    public class PersistenceContext : DbContext
    {
        public PersistenceContext(DbContextOptions<PersistenceContext> options)
            : base(options)
        {
        }
        public DbSet<TaskEntity> TaskItems { get; set; }
    }
}
