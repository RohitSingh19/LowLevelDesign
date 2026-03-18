using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignProblems.NotificationSystem.NotificationTypes
{
    internal class Email : INotificationStrategy
    {
        public NotificationChannel Channel => NotificationChannel.Email;

        public Task SendAsync(string message, string recipient)
        {
            Console.WriteLine("Sending notification via Email");
            return Task.CompletedTask;
        }
    }
}
