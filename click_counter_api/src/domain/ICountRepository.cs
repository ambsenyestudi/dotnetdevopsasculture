using System.Threading;
using System.Threading.Tasks;

namespace ClickCounter.Domain
{
    public interface ICountRepository
    {
        Task<Count> GetCountAsync(CancellationToken cancellationToken);
        Task IncrementClickCountAsync(CancellationToken cancellationToken);
    }
}
