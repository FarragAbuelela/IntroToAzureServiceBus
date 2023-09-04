using System;
using System.Collections.Generic;
using System.Text;

namespace SBReceiver.Interfaces
{
    public interface IMessageHandler
    {
        bool CanBeHandledType(Type type);
        void Invoke(object messsage);
    }
    public interface IMessageHandler<T>
    {
        void Invoke(T messsage);
    }
}
