
namespace OOP.Coupling;

public class GoodOrder
{
    private readonly INotificationService notificationService;
    public GoodOrder(INotificationService notificationService)
    {
        this.notificationService = notificationService;
    }

    public void PlaceOrder()
    {
        // Place order logic
        notificationService.SendNotification("Order placed successfully");
    }
    
}