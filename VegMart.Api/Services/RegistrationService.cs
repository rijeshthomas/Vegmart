using VegMart.Api.ServiceBus;
using VegMart.Data;

namespace VegMart.Api.Services
{
    public class RegistrationService : IRegistrationService
    {
        private IServiceBusQueueProxy _serviceBusQueueProxy;

        public RegistrationService(IServiceBusQueueProxy serviceBusQueueProxy)
        {
            _serviceBusQueueProxy = serviceBusQueueProxy;
        }

        public bool Register(UnitRegistrations registration )
        {
            return _serviceBusQueueProxy.SendData(registration);
        }
    }
}
