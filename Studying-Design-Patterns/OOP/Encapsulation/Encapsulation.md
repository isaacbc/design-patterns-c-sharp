# ENCAPSULATION
 Encapsulation is the process of hiding the implementation details of a class and exposing only the necessary interfaces.

Example: Bank Account Class

Initial Design (No Encapsulation)
In this design, the Balance field is public, allowing any client to directly modify it. This can lead to issues, such as setting a negative balance, which might violate the program's logic.

Refactored Design (With Encapsulation)
By making the Balance field private, we encapsulate it within the class and prevent direct access from outside. We then provide public methods like Deposit, Withdraw, and GetBalance to interact with the balance in a controlled manner.

In this encapsulated version, the Deposit and Withdraw methods include checks to ensure that the balance remains valid. Users of the BankAccount class do not need to know the internal details of how these operations are performed; they only need to know how to use the public methods.