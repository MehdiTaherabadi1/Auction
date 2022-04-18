using System;

namespace NotificationManagement.Messages
{
    public class SchedulesNotificationMessage
    {
        public string Receiver { get; set; }
        public string Text { get; set; }
        public TimeSpan MaxRetryValidTime { get; set; }
        public DateTime StartDate { get; private set; }
        public DateTime ScheduleDateTime { get; set; }
    }
}
