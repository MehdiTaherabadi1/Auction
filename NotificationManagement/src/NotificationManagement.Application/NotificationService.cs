using NotificationManagement.Application.Contracts;
using NotificationManagement.Domain.Model.Notifications;

namespace NotificationManagement.Application
{
    public class NotificationService : INotificationService
    {
        public void Save(SendPeriodicNotification notification)
        {
            
        }

        public void Save(SendSchedulesNotification notification)
        {
        }
    }
}