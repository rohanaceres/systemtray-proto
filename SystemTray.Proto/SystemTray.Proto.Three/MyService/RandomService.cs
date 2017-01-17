using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using SystemTray.Proto.Three.MyService.Base;
using SystemTray.Proto.Three.MyService.Events;
using SystemTray.Proto.Three.MyService.TypeCode;

namespace SystemTray.Proto.Three.MyService
{
    internal sealed class RandomService : IService, ITriggerableService
    {
        public RandomServiceStatus status;
        public RandomServiceStatus Status
        {
            get { return this.status; }
            set
            {
                this.status = value;

                if (this.OnStatusChanged != null)
                {
                    this.OnStatusChanged(this,
                        new ServiceEventArguments() { ServiceStatus = value });
                }
            }
        }
        public EventHandler<ServiceEventArguments> OnStatusChanged { get; set; }

        public void DoSomething()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 1000);

            if (randomNumber % 2 == 0)
            {
                // Status OK:
                this.Status = RandomServiceStatus.Ok;
            }
            else
            {
                if (randomNumber.IsPrime() == false)
                {
                    // Status Warning
                    this.Status = RandomServiceStatus.Warning;
                }
                else
                {
                    // Status Error
                    this.Status = RandomServiceStatus.Error;
                }
            }
        }

        public void Start()
        {
            Task.Run(() =>
            {
                do
                {
                    this.DoSomething();
                    Thread.Sleep(2000);
                }
                while (true);
            });
        }
    }

    static class IntExtension
    {
        public static bool IsPrime(this int n)
        {
            if (n > 1)
            {
                return Enumerable.Range(1, n).Where(x => (n % x == 0))
                                 .SequenceEqual(new[] { 1, n });
            }

            return false;
        }
    }
}
