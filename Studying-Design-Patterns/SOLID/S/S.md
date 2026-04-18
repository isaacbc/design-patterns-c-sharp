# Single Responsibility Principle (SRP)
The core definition of SRP is that a class should have only one reason to change, meaning it should have only one responsibility or purpose.

#### Why it Matters:
Focus: Classes perform one well-defined task rather than multiple unrelated ones.

#### Testability: 
Smaller, focused units are significantly easier to test.

#### Maintainability: 
Changes in one area of logic don't accidentally break unrelated functionality.

Example: 
1. The Violation (Doing too much)
In this example, the User class is handling both data representation and business logic (registration and email signaling).
2. The Refactor (Separation of Concerns)
To fix this, we split the class. The User class will only hold data, while a new UserService class will handle the registration logic.
Note that We advance the D concept already using the INotificationSender interface, introducted in the OOP.Coupling explanation.

- Tip: Think of SRP as "breaking up" classes into smaller, more focused units. This makes your code more "adaptable to change".

- Warning: A class violates SRP if you have to modify it for different types of updates. For example, if you change how a user is stored in the database AND how a welcome email is formatted, and both changes happen in the same class, you have a violation.

- Reference: The UserService can eventually be expanded to include other related business logic, such as Login or UpdateProfile, while keeping the User model strictly for data.
