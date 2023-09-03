using Microsoft.Azure.ServiceBus;
using SBShared.Const;
using System;
using System.Text;

namespace SBReceiver.Services
{
    public class Service
    {
        private readonly MessageServiceProvider _serviceProvider;
        public Service(MessageServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void Invoke(Message message)
        {
            var jsonString = Encoding.UTF8.GetString(message.Body);
            Status action = (Status)message.UserProperties["Action"];

            var receivedMessage = Deserializer.GetObject(jsonString, action);
            if (receivedMessage == null)
            {
                Console.WriteLine("Null Message!!!!");
            }
            else
            {
                var service = _serviceProvider.GetService(receivedMessage);
                if (service is null)
                {
                    Console.WriteLine("No service found for this message type: " + receivedMessage.GetType());
                }
                else service.Invoke((dynamic)receivedMessage);
                
            }
        }

    }
}
