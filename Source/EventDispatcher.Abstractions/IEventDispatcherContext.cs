using System.Threading;
using System.Threading.Tasks;

namespace EventDispatcher
{
    public interface IEventDispatcherContext
    {
        void Dispatch<TEvent>();

        Task DispatchAsync<TEvent>(CancellationToken cancellationToken = default(CancellationToken));
    }
}
