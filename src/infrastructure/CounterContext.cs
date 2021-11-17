using Microsoft.EntityFrameworkCore;

namespace ClickCounter.Infrastructure
{
    public class CounterContext: DbContext
    {
        public CounterContext(DbContextOptions<CounterContext> options):base(options)
        {

        }
        public DbSet<CountEntity> Counts { get; set; }
    }
}
