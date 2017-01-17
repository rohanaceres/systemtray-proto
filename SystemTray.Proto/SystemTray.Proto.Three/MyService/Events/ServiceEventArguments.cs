using System;
using SystemTray.Proto.Three.MyService.TypeCode;

namespace SystemTray.Proto.Three.MyService.Events
{
    internal sealed class ServiceEventArguments : EventArgs
    {
        public RandomServiceStatus ServiceStatus { get; set; }
    }
}
