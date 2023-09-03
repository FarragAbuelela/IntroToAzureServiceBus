using SBShared.DTOs;
using SBShared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SBReceiver.Services
{
    public class MessageServiceProvider
    {
        private readonly IServiceProvider _serviceProvider;
        public MessageServiceProvider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public dynamic GetService(IMessageDTO receivedMessage)
        {
            Type messageType = receivedMessage.GetType();

            Type openType = typeof(IMessage<>);
            Type closedType = openType.MakeGenericType(messageType);
            return _serviceProvider.GetService(closedType);
        }

    }
}
