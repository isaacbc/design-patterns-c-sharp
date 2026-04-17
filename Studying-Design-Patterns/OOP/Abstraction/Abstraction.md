# Abstraction
Reduce complexity by hiding unnecessary details and showing only the essential features of an object.

Example: Email Service Class
In this example, we show how abstraction can simplify an email service by hiding the steps involved in sending an email:

Initial Design (No Abstraction)
In this version, all methods are public, and the user must call them in a specific order to send an email.

Refactored Design (With Abstraction)
By making the internal steps private and exposing only a single SendEmail method, we abstract away the complexity of the email-sending process. With abstraction, the user only needs to call SendEmail(), and the class handles all the necessary internal steps. This makes the class easier to use and reduces the chances of errors.