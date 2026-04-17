# Coupling
Coupling is the degree of interdependence between classes or modules. It is a measure of how closely related two classes are and how much they rely on each other.

- High Coupling: Classes are tightly interconnected, making it difficult to modify or maintain them independently. A change in one class often necessitates changes in another.

- Low Coupling: Classes have loose connections, allowing for greater flexibility and easier modification. This is generally preferred in software design.

Example: E-commerce Order Processing
Let's illustrate high vs. low coupling using an order processing system:

High Coupling Example
In this case, the Order class is directly dependent on the EmailSender class because it creates an instance of it internally using the new keyword.
If we need to change how notifications are sent (e.g., via SMS), we'd have to modify the Order class, which increases the risk of introducing bugs.

Low Coupling with Abstraction (Interfaces)
To reduce coupling, we can introduce an interface (INotificationService) that acts as a contract between the Order class and various notification methods. Now, the Order class doesn't care whether it's an email or an SMS being sent; it only knows that it's using an INotificationService. We can easily switch between different notification methods without changing a single line of code in the Order class.