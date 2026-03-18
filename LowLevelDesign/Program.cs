using LowLevelDesign.DesignPattern;
using LowLevelDesign.DesignProblems.NotificationSystem;
using LowLevelDesign.DesignProblems.NotificationSystem.NotificationPolicy;
using LowLevelDesign.DesignProblems.NotificationSystem.NotificationTypes;
using Microsoft.Extensions.DependencyInjection;


public class Program
{
    public static void Main(string [] args)
    {
        /*Runner for Strategy Example*/
        //Client strategyClient = new Client();
        //strategyClient.Pay(1001, "CARD");
        //strategyClient.Pay(1002, "UPI");
        //strategyClient.Pay(1003, "NEFT");
        //strategyClient.Pay(1004, "CASH");

        /*Runner for Factory Example*/
        //Client client = new Client();
        //client.Pay("CARD", 1010);
        //client.Pay("NEFT", 1015);
        //client.Pay("CASH", 1017);


        /*Runner for Notification System Design*/
        //NotificationService client = new NotificationService();
        //client.Runner();

        var serviceProvider = ConfigureServices();
        var notificationService = serviceProvider.GetRequiredService<NotificationService>();
        var criticalAlert = new CriticalAlertPolicy();
        notificationService.NotifyAsync("This is a notification", "I am recipient", criticalAlert).ConfigureAwait(true);
    }

    public static ServiceProvider ConfigureServices()
    {
        var services = new ServiceCollection();

        services.AddScoped<INotificationStrategy, Email>();
        services.AddScoped<INotificationStrategy, SMS>();
        services.AddScoped<INotificationStrategy, Push>();

        services.AddScoped<NotificationService>();

        return services.BuildServiceProvider();
    }
}