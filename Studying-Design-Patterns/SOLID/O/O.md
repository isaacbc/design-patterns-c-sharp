# The Open/Closed Principle (OCP)

The principle states that software entities (classes, modules, functions) should be open for extension but closed for modification.

- Open for extension: You should be able to add new functionality.
- Closed for modification: You should not have to change the existing source code to add that functionality.
- How it's achieved: This goal is typically met using abstraction and polymorphism through inheritance or composition.

1. The Problem: Violating OCP
In the initial example, a single class handles multiple shapes using a switch statement.
How it works: An Enum defines shape types, and a Shape class stores all possible properties (radius, length, width).
The Issue: Every time you want to add a new shape (like a Triangle), you must modify the Shape class and the calculateArea method.

2. The Solution: Refactoring for OCP
To follow the principle, we move the responsibility of calculating the area to the individual shape classes using an abstract class.
Define an abstract base class with an abstract method.
Create concrete classes for each shape that provide their own implementation of the method.
Now, adding a new shape only involves creating a new class; the existing code remains untouched.

Single Responsibility: This refactor also satisfies the Single Responsibility Principle because the base class is no longer managing multiple shape types.
Loose Coupling: Following OCP helps build loosely coupled, maintainable software.
#### Tip: 
If you find your switch statements or if/else blocks growing every time you add a feature, it's a sign you should refactor using polymorphism to satisfy the Open/Closed Principle.