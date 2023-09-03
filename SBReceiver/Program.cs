using Microsoft.Azure.ServiceBus;
using SBShared.Models;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using SBShared.DTOs;
using SBReceiver.Services;

namespace SBReceiver
{
    class Program
    {

        const string connectionString = "Endpoint=sb://azuremicroservices.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=rSFJQHOrd6XRtK8ZYvybBwZvHMk3kHMsN+ASbKnUf+Q=";
        const string queueName = "personqueue";

        static async Task Main(string[] args)
        {
            var services = new ServiceCollection();
            //services.AddSingleton<IQueueClient, QueueClient>();
            services.AddSingleton<QueueClient>(provider => new QueueClient(connectionString, queueName));
            services.AddTransient<MessageService>();
            services.AddTransient<IMessage<AddPersonMessageDTO>, AddPersonMessage>();
            services.AddTransient<IMessage<UpdateAgeMessageDTO>, UpdateAgeMessage>();
            services.AddTransient<IMessage<UpdateNameMessageDTO>, UpdateNameMessage>();
            services.AddTransient<IMessage<DeletePersonMessageDTO>, DeletePersonMessage>();
            services.AddTransient<IMessage<PrintPersonsListMessageDTO>, PrintPersonsListMessage>();
            services.AddSingleton<Service>();
            var serviceProvider = services.BuildServiceProvider();
            var messageServices = serviceProvider.GetRequiredService<MessageService>();

            messageServices.Run();

        }

        

        
    }

}
