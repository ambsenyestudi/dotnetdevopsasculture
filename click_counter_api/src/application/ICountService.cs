using ClickCounter.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace ClickCounter.Application
{
    public interface ICountService
    {
        Task<Count> GetCountAsync(CancellationToken cancellationToken);
        Task IncrementClickCountAsync(CancellationToken cancellationToken);
    }
}
