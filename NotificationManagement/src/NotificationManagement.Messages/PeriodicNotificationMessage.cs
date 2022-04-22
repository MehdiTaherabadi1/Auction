using Sparta.Core.MessageHandling;
using System;

namespace NotificationManagement.Messages
{
    public class PeriodicNotificationMessage : IMessage
    {
        public string Receiver { get; private set; }
        public string Text { get; private set; }
        public TimeSpan MaxRetryValidTime { get; private set; }
        public DateTime StartDate { get; private set; }
        public TimeSpan EndDate { get; private set; }
        public TimeSpan Interval { get; set; }
    }
}
