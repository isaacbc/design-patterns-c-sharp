# Inheritance

Inheritance involves creating new classess (subclassess or derived classes) based on existing classes (superclasses or base classes).
Subclasess inherit properties and behaviors from theis superclassess and can also add new features or override existing ones. Inheritance is often described in terms of an "is-a" relationship, where a subclass is a specialized version of a superclass.

### Fragile Base Class Problem and why you should use composition over inheritance

The fragile base class problem ia software design issue that arises in object-oriented programming when changes made to a base class can inadvertenly break the funcionality of derived classess. this problem occurs due to the tight coupling between base and derived classess in inheritance hierarchies.

1. Inheritance Coupling: Inheritance creates a strong coupling between the base class (superclass) and derived classes (subclasses). Any changes made to the base class can potentially affect the behavior os all derived classes.

2. Limited Extensibility: The fragile base class problem limits the extensibility of software systems, as modifications to the base class can become increasingly risky and costly over time. Developers may avoid making necessary changes due to the fear of breaking existing funcionality (Brittle software)

### Mitigantion Strategies
To mitigate the fragile base class problem, software developer can use design principles such as the SOLID Open/Closed Principle (OCP) and Dependency Inversion Principle (DIP), as well as design patterns like Composition over Inheritance. These aproaches promote loose coupling, encapsulation, and modular design, reducing the impact of changes in base classes;