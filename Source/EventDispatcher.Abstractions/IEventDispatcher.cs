using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EventDispatcher
{
    public interface IEventDispatcher
    {
        void Dispatch<TEvent>(IEnumerable<TEvent> events, IEnumerable<IEventDispatchHandler<TEvent>> handlers) where TEvent : IEvent;

        void Dispatch<TEvent>(TEvent @event, IEnumerable<IEventDispatchHandler<TEvent>> handlers) where TEvent : IEvent;

        Task DispatchAsync<TEvent>(IEnumerable<TEvent> events, IEnumerable<IEventDispatchHandler<TEvent>> handlers, CancellationToken cancellation = default(CancellationToken)) where TEvent : IEvent;

        Task DispatchAsync<TEvent>(TEvent @event, IEnumerable<IEventDispatchHandler<TEvent>> handlers, CancellationToken cancellation = default(CancellationToken)) where TEvent : IEvent;
    }
}