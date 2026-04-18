# Dependency Inversion Principle (DIP)
The core idea is that high-level modules (the "what") should not depend on low-level modules (the "how"). Instead, both should depend on abstractions (interfaces or abstract classes). This promotes decoupling, making code more flexible, maintainable, and testable.

1. Violating Dependency Inversion
In this example, the Car (high-level) is tightly coupled to a specific Engine (low-level). If we want to change the engine type, we have to modify the Car class itself.

2. Introducing the Abstraction
To fix the violation, we introduce an interface. Now, the Car doesn't care which engine it has, only that the engine can Start().

3. Applying Dependency Injection
We use Dependency Injection to pass the engine into the car's constructor. This allows us to swap engine types at runtime without changing the Car class.

#### Key Benefits of this Approach
- Loose Coupling: Components are independent; changing one doesn't break the other.

- Testability: You can easily inject "Mock" or "Stub" engines during unit testing.

- Flexibility: New engine types (like a V6Engine) can be added without ever touching the Car source code.