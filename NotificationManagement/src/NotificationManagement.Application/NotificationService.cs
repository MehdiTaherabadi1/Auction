using NotificationManagement.Application.Contracts;
using NotificationManagement.Domain.Model.Notifications;

namespace NotificationManagement.Application
{
    public class NotificationService : INotificationService
    {
        public void Save(SendPeriodicNotification notification)
        {
            throw new System.NotImplementedException();
        }

        public void Save(SendSchedulesNotification notification)
        {
            throw new System.NotImplementedException();
        }
    }
}