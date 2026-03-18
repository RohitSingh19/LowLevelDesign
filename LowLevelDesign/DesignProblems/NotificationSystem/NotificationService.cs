using LowLevelDesign.DesignProblems.NotificationSystem.NotificationPolicy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignProblems.NotificationSystem
{
    public class NotificationService
    {
        private readonly Dictionary<NotificationChannel, INotificationStrategy> _strategies;

        public NotificationService(IEnumerable<INotificationStrategy> strategies)
        {
            _strategies = strategies.ToDictionary(s => s.Channel);
        }
        public void Runner()
        {
            //INotificationStrategy notificationStrategy = NotificationFactory.CreateNotificationStrategy("Push");
            //notificationStrategy.Send("This is a notification message", "I am recipient");

            //INotificationStrategy notificationStrategy = NotificationFactory.GetStrategy("SMS");
            //notificationStrategy.Send("This is SMS notification", "I am recipient");
            
        }

        public void Notify(string message, string recipient, INotificationPolicy notificationPolicy)
        {


            //foreach (var channel in channels) {
            //    var strategy = NotificationFactory.GetStrategy(channel);
            //    strategy.Send(message, recipient);
            //}
            
            NotificationOrchestrator notificationOrchestrator = new NotificationOrchestrator();
            var channels = notificationPolicy.GetChannels();
            notificationOrchestrator.SendWithFallBack(channels, message, recipient);
        }

        public async Task NotifyAsync(string message, string recipient, INotificationPolicy notificationPolicy)
        {
            var channels = notificationPolicy.GetChannels();

            foreach (var channel in channels)
            {
                if (_strategies.TryGetValue(channel, out var strategy))
                {
                    await strategy.SendAsync(message, recipient);
                }
            }
        }
    }
}
