using System;
using SystemTray.Proto.Three.MyService.Events;

namespace SystemTray.Proto.Three.MyService.Base
{
    internal interface ITriggerableService
    {
        EventHandler<ServiceEventArguments> OnStatusChanged { get; }
    }
}
