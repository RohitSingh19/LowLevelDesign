using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignProblems.NotificationSystem.NotificationTypes
{
    public class Push : INotificationStrategy
    {
        public NotificationChannel Channel => NotificationChannel.Push;

        public Task SendAsync(string message, string recipient)
        {
            Console.WriteLine("Sending notification via Push");
            return Task.CompletedTask;
        }
    }
}
