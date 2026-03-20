using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignPattern.Builder
{
    public class NotificationRequest
    {
        public string Message { get; }
        public string Recipient { get; }
        public string Channel { get; }
        public string Priority { get; }

        public NotificationRequest(
            string message,
            string recipient,
            string channel,
            string priority)
        {
            Message = message;
            Recipient = recipient;
            Channel = channel;
            Priority = priority;
        }
    }
}
