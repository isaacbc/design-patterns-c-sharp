namespace OOP.Coupling;

public class SmsSender : INotificationService
{

    // good coupling implementing the interface
    public void SendNotification(string message)
    {
        //sms sending logic
        System.Console.WriteLine("Sending sms: " + message);
    }

}