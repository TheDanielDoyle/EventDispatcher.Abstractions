using System.Threading.Tasks;

namespace EventDispatcher
{
    public interface IEventDispatcherContext
    {
        void Dispatch();

        Task DispatchAsync();
    }
}
