using System;
using SystemTray.Proto.Three.MyService.Base;
using SystemTray.Proto.Three.MyService.Events;
using SystemTray.Proto.Three.MyService.TypeCode;

namespace SystemTray.Proto.Three.MyService
{
    internal sealed class RandomService : IService, ITriggerableService
    {
        public RandomServiceStatus Status
        {
            get;
            set;
        }
        public EventHandler<ServiceEventArguments> OnStatusChanged { get; set; }

        public void DoSomething()
        {
            // TODO: Do something

            // TODO: Trigger events
        }
    }
}
