namespace OOP.Coupling;


/// <summary>
/// This class has a bad coupling with EmailSender
/// </summary>
public class BadOrder
{
    public void PlaceOrder()
    {
        EmailSender emailSender = new();
        emailSender.SendEmail("Bad order: Order placed successfully");
    }
}