using System;
using System.Text;
using Microsoft.Azure.ServiceBus;
using Newtonsoft.Json;

namespace VegMart.Api.ServiceBus
{
    public class ServiceBusQueueProxy : IServiceBusQueueProxy 
    {
        private string _connectionString;
        private string _queuePath = "queue1";
        private IQueueClient _queueClient;

        public ServiceBusQueueProxy()
        {
            _connectionString = "Endpoint=sb://gcexchange.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=73Tg/PfMEiqIKGKHSa/9QnqOEQtubmRww8+/ibpAGi8=";
        }

        public ServiceBusQueueProxy(string connectionString)
        {
            _connectionString = connectionString;
        }

        public ServiceBusQueueProxy(string connectionString, string queuePath)
        {
            _connectionString = connectionString;
            _queuePath = queuePath;
        }

        public bool SendData<T>(T message)
        {
            var queueClient = new QueueClient(_connectionString, _queuePath);
            var json = JsonConvert.SerializeObject(message);
            var encodedMessage = new Message(Encoding.UTF8.GetBytes(json));
            queueClient.SendAsync(encodedMessage);
            return true;
        }
    }
}
