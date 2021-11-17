using ClickCounter.Domain;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ClickCounter.Infrastructure
{
    public class CountRepository : ICountRepository
    {
        public const string EVENT_NAME = "Click";
        private readonly CounterContext context;
        public CountRepository(CounterContext context)
        {
            this.context = context;
        }


        public async Task<Count> GetCountAsync(CancellationToken cancellationToken)
        {
            if(!context.Counts.Any())
            {
                return new Count();
            }
            var total = await Task.Factory
                .StartNew(
                    () => context.Counts.ToList().Count,
                    cancellationToken);
            return new Count { Total = total };
        }

        public async Task IncrementClickCountAsync(CancellationToken cancellationToken)
        {
            
            context.Counts.Add( new CountEntity { Name = EVENT_NAME });
            await context.SaveChangesAsync(cancellationToken);
        }
        
    }
}
