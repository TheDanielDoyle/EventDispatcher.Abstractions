using System.Threading;
using System.Threading.Tasks;

namespace EventDispatcher
{
    public interface IEventDispatcherContext
    {
        void Dispatch<TEvent>() where TEvent : IEvent;

        Task DispatchAsync<TEvent>(CancellationToken cancellationToken = default(CancellationToken)) where TEvent : IEvent;
    }
}
