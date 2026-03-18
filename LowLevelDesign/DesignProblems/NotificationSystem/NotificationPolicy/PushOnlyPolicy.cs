using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignProblems.NotificationSystem.NotificationPolicy
{
    public class PushOnlyPolicy : INotificationPolicy
    {
        public List<NotificationChannel> GetChannels()
        {
            return new List<NotificationChannel> { NotificationChannel.Push };
        }
    }
}
