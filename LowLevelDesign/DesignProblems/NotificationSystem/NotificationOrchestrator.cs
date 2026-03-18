using LowLevelDesign.DesignProblems.NotificationSystem.NotificationPolicy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignProblems.NotificationSystem
{
    public class NotificationOrchestrator
    {
        public void SendWithFallBack(List<NotificationChannel> channels, string message, string recipient)
        {
            foreach (var channel in channels)
            {
                var strategy = NotificationFactory.GetStrategy(channel);
                try
                {
                    strategy.SendAsync(message, recipient);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("failed to send notification "+ex);
                    Console.WriteLine("trying another channel");
                }
            }
        }

        public async void SendParallelAsync(List<NotificationChannel> channels, string message, string recipient)
        {
            var task = channels.Select(channel =>
            {
                var strategy = NotificationFactory.GetStrategy(channel);
                return strategy.SendAsync(message, recipient);
            });

            await Task.WhenAll(task);
        }
    }
}
