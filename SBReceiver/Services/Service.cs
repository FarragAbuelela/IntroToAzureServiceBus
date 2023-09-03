using Microsoft.Azure.ServiceBus;
using Microsoft.Extensions.DependencyInjection;
using SBShared.Const;
using SBShared.DTOs;
using SBShared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SBReceiver.Services
{
    public class Service
    {
        private readonly IServiceProvider _serviceProvider;
        public Service(IServiceProvider serviceProvider)
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
                Type messageType = receivedMessage.GetType();
                
                Type openType = typeof(IMessage<>);
                Type closedType = openType.MakeGenericType(messageType);
                var service = (dynamic)_serviceProvider.GetService(closedType);
                if (service is null)
                {
                    Console.WriteLine("No handler found for message type: " + messageType.Name);
                }
                else service.Invoke((dynamic)receivedMessage);
                
            }
        }

    }
}
