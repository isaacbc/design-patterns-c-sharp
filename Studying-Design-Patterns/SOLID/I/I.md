# Interface Segregation Principle

The Interface Segregation Principle (ISP) states that clients should not be forced to depend on interfaces that they do not use. This principle encourages the creation of fine-grained interfaces that contain only the methods required by the clients that use them. It helps to prevent the creation of "fat" interfaces that force clients to implement unnecessary methods, leading to cleaner and more maintainable code.

#### The Problem: A "Fat" Interface
We created an interface called IShape. This is going to contain methods for calculating certain properties on a shape, such as Area or Volume.
Then We created a concrete Circle class that implements this IShape interface. But there's a problem: Circles don't actually have volumes because they are a 2D shape. All 2D shapes don't have volumes; they only have areas.
Here, we've been forced to implement this Volume method from IShape because the interface states that we must, otherwise we will get an error. What we're going to have to do here, really, is return an InvalidOperationException and say that volume is not applicable for 2D shapes.

#### The Solution: Refactoring with ISP
We are going to segregate this IShape interface into two separate interfaces: IShape2D and IShape3D.

IShape2D: Only contains an Area method.

IShape3D: Contains both Area and Volume.

We have segregated the interface into two separate, smaller, fine-grained interfaces that are more specific rather than large and general. Now, in our Circle class, we can implement IShape2D and remove the Volume method. In our Sphere class, we implement IShape3D.

Now, if we go back to our program and try to call Volume on a 2D shape, VS Code straight away says this method does not exist. The Interface Segregation Principle ensures that clients are not forced to depend on methods they do not use. Clients can now depend only on the interfaces they need, promoting better code and reusability.
