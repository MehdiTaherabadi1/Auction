using System;

namespace NotificationManagement.Application.Contracts
{
    public class SendSchedulesNotification
    {
        public string Receiver { get; private set; }
        public string Text { get; private set; }
        public TimeSpan MaxRetryValidTime { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime ScheduleDateTime { get; set; }
    }
}
