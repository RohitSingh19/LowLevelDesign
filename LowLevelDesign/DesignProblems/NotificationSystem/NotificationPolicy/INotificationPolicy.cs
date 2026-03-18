using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignProblems.NotificationSystem.NotificationPolicy
{
    public interface INotificationPolicy
    {
        List<NotificationChannel> GetChannels();
    }
}
