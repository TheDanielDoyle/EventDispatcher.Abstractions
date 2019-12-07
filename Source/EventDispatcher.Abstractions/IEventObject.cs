namespace EventDispatcher
{
    public interface IEventObject
    {
        IEventStore EventStore { get; }
    }
}
