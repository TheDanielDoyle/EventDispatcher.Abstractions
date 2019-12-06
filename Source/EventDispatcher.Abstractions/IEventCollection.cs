using System;
using System.Collections.Generic;

namespace EventDispatcher
{
    public interface IEventCollection : IReadOnlyCollection<IEvent>
    {
        IEventCollection AssignableTo<TEvent>() where TEvent : IEvent;

        IEventCollection AssignableTo(Type eventType);

        IEventCollection OfType<TEvent>() where TEvent : IEvent;

        IEventCollection OfType(Type eventType);
    }
}