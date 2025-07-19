using System;

namespace Rossoforge.Core.Events
{
    public interface IBusEditorInfo
    {
        IEventBus EventBus { get; set; }
        int Calls { get; set; }
        Type EventType { get; set; }
        Type[] ListenersType { get; set; }
        object EventInstance { get; set; }
        int ListenerCount { get; }
    }
}