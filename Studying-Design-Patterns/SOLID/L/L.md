# The Liskov Substitution Principle (LSP) Tutorial
The Liskov Substitution Principle (LSP) states that objects of a superclass should be replaceable with objects of its subclasses without affecting the correctness of the program. This ensures that inheritance hierarchies are well-designed and that subclasses adhere to the contracts defined by their superclasses.

#### Violating LSP: The Rectangle and Square Problem
A classic example of violating LSP is the Rectangle and Square problem. While a square is mathematically a special type of rectangle, modeling it as a subclass of Rectangle in code often leads to unexpected behavior.

#### Initial Design (LSP Violation)
In this design, we have an abstract Shape class and a Rectangle class that inherits from it. The Square class inherits from Rectangle, but it must override the Width and Height properties to ensure they remain equal.

#### Refactoring to Satisfy LSP
To fix this, we change the hierarchy so that Square no longer inherits from Rectangle. Instead, both Square and Rectangle inherit directly from Shape. This respects the unique properties of each shape: a rectangle has width and height, while a square has a single side length. Now, both classes behave as expected when used as their base type, Shape. Substitution no longer introduces unexpected side effects or bugs. By ensuring that subclasses are truly substitutable for their base classes, our code becomes more maintainable, predictable, and less prone to bugs.