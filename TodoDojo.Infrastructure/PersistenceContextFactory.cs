using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TodoDojo.Infrastructure
{
    public class PersistenceContextFactory : IDesignTimeDbContextFactory<PersistenceContext>
    {
        public PersistenceContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PersistenceContext>();
            optionsBuilder.UseSqlite("Data Source=TodoDojoDev.db"); // Replace with your connection string or configuration logic

            return new PersistenceContext(optionsBuilder.Options);
        }
    }
}
