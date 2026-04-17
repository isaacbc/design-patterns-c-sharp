# Composition
Composition involves creating complex objects by combingin simpler objects or components. In composition, objects are assembled together to form larger structures, with each component object maintaingn its own state and behavior. Composition is often described in terms os a "has-a" relantionship

Example: Building a Car
A car is a complex object composed of various simpler parts like an engine, wheels, and a chassis. Each of these can be represented as its own class.
In this example, the Car class is composed of Engine, Wheels, and Chassis objects. It delegates specific tasks to these component classes, keeping the Car class itself simpler and more organized.

### When to use Composition
- When you need more flexibility in constructing objects by assembling smaller, reusable components.
- When there is no clear "is-a" relationship between classes, and a "has-a" relationship is more appropriate.
- When you want to avoid the limitations of inheritance, such as tight coupling and the fragile base class problem

### When to use Inheritance:
- When there is a clear "is-a" relationship between classes, and subclass objects can be treated as instances of their superclass
- When you want to promote code reuse by inheriting properties and behaviors from existing classes
- When you want to leverage polymorphism to allow objects of different subclasses to be treated uniformly trhough their common superclass interface.

### Difference between Association relationship and Composition:

- Association: A person has a Car, but is not composed of Car. A person holds a reference to Car so it can interact with it, but a Person can exist without a Car. In UML is represented by a non-painted arrow from Person to Car ------->

- Composition: when a child object woudn't be able to exist without its parent object. E.g., a hotel is composed of its rooms, and HotelBathroom cannot exist without Hotel (destroy the hotel, you destroy the hotel bathroom - it can't exist by itself). Also, if a Customer is destroyed, their ShoppingCart and Orders are lost too - therefore Customer is composed of ShoppingCart and Orders. And if Orders are lost, OrderDetails and ShippingInfo are lost - so Orders are composed of ShippingInfo and OrderDetails. In UML is represented by a Diamond shape arrow in Customer and an arrow painted in ShoppingCart

### Dependendy relationship
When a Class like Dog uses another one like Document, but is not a field in this class, is used somewhere, like as a parameter in a method, or a local variable in a method. So somewhere in the Dog class we have a reference, or dependecy, to the Document class. in UML is represented by a dashed arrow ----Use----> 