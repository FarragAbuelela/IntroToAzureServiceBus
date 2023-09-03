using Microsoft.Azure.ServiceBus;
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
        private readonly Dictionary<Type, dynamic> _messageHandlers = new Dictionary<Type, dynamic>();
        private readonly IMessage<AddPersonMessageDTO> _addPerson;
        private readonly IMessage<DeletePersonMessageDTO> _deletePerson;
        private readonly IMessage<UpdateAgeMessageDTO> _updatePersonAge;
        private readonly IMessage<UpdateNameMessageDTO> _updatePersonName;
        private readonly IMessage<PrintPersonsListMessageDTO> _printPersonsList;
        public Service(IMessage<AddPersonMessageDTO> addPerson, IMessage<DeletePersonMessageDTO> deletePerson, IMessage<UpdateAgeMessageDTO> updatePersonAge, IMessage<UpdateNameMessageDTO> updatePersonName, IMessage<PrintPersonsListMessageDTO> printPersonsList)
        {
            _messageHandlers[typeof(AddPersonMessageDTO)] = addPerson;
            _messageHandlers[typeof(DeletePersonMessageDTO)] = deletePerson;
            _messageHandlers[typeof(UpdateAgeMessageDTO)] = updatePersonAge;
            _messageHandlers[typeof(UpdateNameMessageDTO)] = updatePersonName;
            _messageHandlers[typeof(PrintPersonsListMessageDTO)] = printPersonsList;
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
                if (_messageHandlers.ContainsKey(messageType))
                {
                    dynamic handler = _messageHandlers[messageType];
                    handler.Invoke((dynamic)receivedMessage);
                }
                else
                {
                    Console.WriteLine("No handler found for message type: " + messageType.Name);
                }
            }
        }

    }
}
