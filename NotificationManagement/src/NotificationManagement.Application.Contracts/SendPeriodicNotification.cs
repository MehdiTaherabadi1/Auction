using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationManagement.Application.Contracts
{
    public class SendPeriodicNotification
    {
        public string Receiver { get; private set; }
        public string Text { get; private set; }
        public TimeSpan MaxRetryValidTime { get; private set; }
        public DateTime StartDate { get; private set; }
        public TimeSpan EndDate { get; private set; }
        public TimeSpan Interval { get; set; }
    }
}
