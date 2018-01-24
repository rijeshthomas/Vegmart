using Microsoft.Azure.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VegMart.Api.ServiceBus
{
    public interface IServiceBusQueueProxy
    {
        bool SendData<T>(T message);
    }
}
