using OOP.Coupling;

namespace SOLID.S;

public class UserService
{
    private readonly INotificationService _notificationService;

    public UserService(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }
    public void Register(User user)
    {
        // Handle registration business logic here
        _notificationService.SendNotification("Welcome to our platform!");
    }
}