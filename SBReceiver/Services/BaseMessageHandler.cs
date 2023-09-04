using SBReceiver.Interfaces;
using SBShared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SBReceiver.Services
{
    public abstract class BaseMessageHandler <T> : IMessageHandler, IMessageHandler<T> where T : class
    {
        public bool CanBeHandledType(Type type)
        {
            return type == typeof(IMessage<>);
        }

        public void Invoke(T messsage) { }


        public void Invoke(object messsage) { }
    }
}
