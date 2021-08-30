using System;
using LoggerPackage;

namespace BetterLogging
{
    public class LogMessage
    {
        public LogMessage(object message, string subject = "Message", DateTime? timestamp = null)
        {
            Subject = subject;
            Message = message;
            Timestamp = timestamp;
        }

        public DateTime? Timestamp { get; set; }
        public string Subject { get; set; }
        public object Message { get; set; }
    }
}
