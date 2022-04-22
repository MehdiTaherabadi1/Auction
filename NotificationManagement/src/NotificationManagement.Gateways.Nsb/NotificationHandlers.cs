using Mapster;
using NotificationManagement.Application.Contracts;
using NotificationManagement.Messages;
using NServiceBus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NotificationManagement.Gateways.Nsb
{
    public class NotificationHandlers : IHandleMessages<PeriodicNotificationMessage>,
                                        IHandleMessages<SchedulesNotificationMessage>
    {
        private readonly INotificationService _notificationService;
        public NotificationHandlers(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public Task Handle(PeriodicNotificationMessage message, IMessageHandlerContext context)
        {
            _notificationService.Save(message.Adapt<SendPeriodicNotification>());
            return Task.CompletedTask;
        }

        public Task Handle(SchedulesNotificationMessage message, IMessageHandlerContext context)
        {
            _notificationService.Save(message.Adapt<SendSchedulesNotification>());
            return Task.CompletedTask;
        }
    }
}
