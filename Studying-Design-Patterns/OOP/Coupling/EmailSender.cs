namespace OOP.Coupling;

public class EmailSender : INotificationService
{


    // For the Bad coupling example in BadOrder
    public void SendEmail(string message)
    {
        //Email sending logic
        System.Console.WriteLine("Sending email: " + message);
    }


    // good coupling implementing the interface
    public void SendNotification(string message)
    {
        //Email sending logic
        System.Console.WriteLine("Sending email: " + message);
    }

}