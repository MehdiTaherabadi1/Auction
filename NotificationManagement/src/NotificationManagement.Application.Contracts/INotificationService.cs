using NotificationManagement.Domain.Model.Notifications;

namespace NotificationManagement.Application.Contracts
{
    public interface INotificationService
    {
        void Save(SendPeriodicNotification notification);
        void Save(SendSchedulesNotification notification);
    }
}