namespace Rossoforge.Core.Events
{
    public interface IEventListener<T> where T : IEvent
    {
        void OnEventInvoked(T eventArg);
    }
}