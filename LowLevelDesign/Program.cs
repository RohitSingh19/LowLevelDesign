using LowLevelDesign.DesignPattern.Strategy;

public class Program
{
    public static void Main(string [] args)
    {
        Client strategyClient = new Client();
        strategyClient.Pay(1001, "CARD");
        strategyClient.Pay(1002, "UPI");
        strategyClient.Pay(1003, "NEFT");
        strategyClient.Pay(1004, "CASH");
    }
}