using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignProblems.NotificationSystem
{
    public interface INotificationStrategy
    {
        NotificationChannel Channel { get; }
        Task SendAsync(string message, string recipient);
    }
}
