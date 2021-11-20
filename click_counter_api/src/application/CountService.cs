using ClickCounter.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace ClickCounter.Application
{
    public class CountService : ICountService
    {
        private readonly ICountRepository repository;

        public CountService(ICountRepository repository)
        {
            this.repository = repository;
        }
        public Task<Count> GetCountAsync(CancellationToken cancellationToken) =>
            repository.GetCountAsync(cancellationToken);

        public Task IncrementClickCountAsync(CancellationToken cancellationToken) =>
            repository.IncrementClickCountAsync(cancellationToken);
    }
}
