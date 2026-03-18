using LowLevelDesign.DesignProblems.NotificationSystem.NotificationTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignProblems.NotificationSystem
{
    public static class NotificationFactory
    {

        /*This process is called Strategy Registry, which removes switch case statements*/
        private static readonly Dictionary<NotificationChannel, INotificationStrategy> _registry = new();

        static NotificationFactory()
        {
            Register(NotificationChannel.Email, new Email());
            Register(NotificationChannel.Push, new Push());
            Register(NotificationChannel.SMS, new SMS());
            
        }

        public static void Register(NotificationChannel type, INotificationStrategy strategy) 
        {
            _registry[type] = strategy;
        }

        public static INotificationStrategy GetStrategy(NotificationChannel type)
        {
            if(!_registry.ContainsKey(type))
            {
                throw new StrategyException("Strategy not found");
            }

            return _registry[type];
        }

        /*This is the factory method to create instance of different strategy*/
        public static INotificationStrategy CreateNotificationStrategy(string type)
        {
            return type switch
            {
                "Email" => new Email(),
                "SMS" => new SMS(),
                "Push" => new Push(),
                _ => throw new NotSupportedException("Notification type not supported"),
            };
        }
    }


    public class StrategyException : Exception
    {
        public StrategyException(string message): base(message) { }  
    }
}

