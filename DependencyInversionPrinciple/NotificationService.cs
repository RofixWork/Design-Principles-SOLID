using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    internal class NotificationService
    {
        public readonly List<IMessage> _services;

        public NotificationService(List<IMessage> services )
        {
            _services = services;
        }

        public void Send()
        {
            foreach (var message in _services)
            {
                message.Send();
            }
        }
    }

    internal class NotificationService1
    {
        //prop injection
        public List<IMessage> _services { get; private set; } = new();

        public void Send()
        {
            foreach (var message in _services)
            {
                message.Send();
            }
        }

        public void SetServices(List<IMessage> services)
        {
            if(services is not null)
                _services = services;
        }
    }

    internal class NotificationService2
    {
        //method injection
        public void Send(List<IMessage> services)
        {
            foreach (var message in services)
            {
                message.Send();
            }
        }
    }
}
