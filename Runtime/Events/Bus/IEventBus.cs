namespace Rossoforge.Events.Bus
{
    public interface IEventBus
    {
#if UNITY_EDITOR
        void CheckListeners();
        IBusEditorInfo GetBusEditorInfo();
        void Raise(object instance);
#endif
    }
}