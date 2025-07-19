namespace Rossoforge.Core.Events
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