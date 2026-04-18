
using OOP.Coupling;

namespace SOLID.S;
public class BadUser
{
    public string Name { get; set; }
    public string Email { get; set; }

    public void Register()
    {
        //Logic for fetching from DB, validation, etc;
        // Logic for sending email notifications
        var emailSender = new EmailSender();
        emailSender.SendNotification("Welcome");
    }
}