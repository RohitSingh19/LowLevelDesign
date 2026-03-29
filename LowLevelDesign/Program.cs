using LowLevelDesign.DesignPattern;
using LowLevelDesign.DesignPattern.DocumentBuilder;
using LowLevelDesign.DesignPattern.Observer;
using LowLevelDesign.DesignProblems.NotificationSystem;
using LowLevelDesign.DesignProblems.NotificationSystem.NotificationPolicy;
using LowLevelDesign.DesignProblems.NotificationSystem.NotificationTypes;
using LowLevelDesign.DesignProblems.VendingMachine;
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
        //var notificationService = serviceProvider.GetRequiredService<NotificationService>();
        //var criticalAlert = new CriticalAlertPolicy();
        //notificationService.NotifyAsync("This is a notification", "I am recipient", criticalAlert).ConfigureAwait(true);


        /*Runner for observer pattern*/
        //var observersList = new List<IObserver>
        //{
        //    new EmailService(),
        //    new AnalyticsService()
        //};

        //var userService = new UserService(observersList);



        //userService.Subscribe(new ReferralService());
        //userService.RegisterUser(new User());



        /*Runner for builder pattern*/
        //var document = new DocumentBuilder().AddHeader("This is the header text").AddParagraph("Para 1").AddParagraph("Para 2").AddFooter("This is the footer text").CreateDocument();

        //Console.WriteLine($"{document.Header} \n {string.Join(" ", document.Paragraph)} \n {document.Footer}");



        /*Runner for Vending Machine: State Design Pattern*/

        Client client = new Client();
        client.RunVendingMachine();
    }

    public static ServiceProvider ConfigureServices()
    {
        var services = new ServiceCollection();

        services.AddScoped<INotificationStrategy, Email>();
        services.AddScoped<INotificationStrategy, SMS>();
        services.AddScoped<INotificationStrategy, Push>();

        services.AddScoped<NotificationService>();

        services.AddScoped<UserService>();
        return services.BuildServiceProvider();
    }
}