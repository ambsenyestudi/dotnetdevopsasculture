using ClickCounter.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace ClickCounter.Infrastructure
{
    public class CountRepository : ICountRepository
    {
        private int currentCount;
        public Task<Count> GetCountAsync(CancellationToken cancellationToken) =>
            Task.Factory.StartNew(() =>
            {
                return new Count { Total = currentCount };
            }, cancellationToken);

        public Task IncrementCountAsync(CancellationToken cancellationToken) =>
            Task.Factory.StartNew(() =>
            {
                currentCount++;
            }, cancellationToken);
    }
}
