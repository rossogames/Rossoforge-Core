using Rossoforge.Core.Services;

namespace Rossoforge.Core.Events
{
    public interface IEventService : IService
    {
        void RegisterListener<T>(IEventListener<T> listener) where T : IEvent;
        void UnregisterListener<T>(IEventListener<T> listener) where T : IEvent;
        void Raise<T>() where T : IEvent;
        void Raise<T>(T eventArg) where T : IEvent;

#if UNITY_EDITOR
        IEventBus[] GetAllBuses();
#endif
    }
}
