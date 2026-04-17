using OOP.Encapsulation;
using OOP.Abstraction;
using OOP.Inheritance;
using OOP.Polymorphism;
using OOP.Coupling;
using OOP.Composition;

////ENCAPSULATION///////
//Bad example
BadBankAccount badBankAccount = new BadBankAccount();
badBankAccount.balance = 1000;
Console.WriteLine(badBankAccount.balance);

//Good example
BankAccount bankAccount = new BankAccount(100);
Console.WriteLine(bankAccount.GetBalance());
//bankAccount.Deposit(-50);
bankAccount.Deposit(100);
//bankAccount.Withdraw(-50);
bankAccount.Withdraw(150);
bankAccount.Withdraw(50);
Console.WriteLine(bankAccount.GetBalance());
/////////////////////////////////////////////

////ABSTRACTION///////
/// 
//Instead of making the user know all the details and middle steps to send and email, like
EmailService emailService = new EmailService();
// emailService.serConnect();
// emailService.Authenticate();
// emailService.SendEmail();
// Console.WriteLine("Sending email...");
// emailService. Disconnect();
//Abstract this proccess to a public and only accessible SendEmail method
emailService.SendEmail();
/////////////////////////////////////////////

////INHERITANCE///////
Car car = new("Toyota", "Corolla", 2020, 4, 4);
car.Start();
car.Stop();
Console.WriteLine($"Car: {car.Brand} {car.Model} {car.Year} {car.NumberOfDoors} {car.NumberOfWheels}");
Bike bike = new("Honda", "CBR", 2020, 2);
bike.Start();
bike.Stop();
Console.WriteLine($"Bike: {bike.Brand} {bike.Model} {bike.Year} {bike.NumberOfWheels}");
/////////////////////////////////////////////


////POLYMORPHISM///////

//Bad example - NOT USING POLYMORPHISM
List<object> vehicles = new List<object>();
vehicles.Add(new CarPM { Brand = "Toyota", Model = "Corolla", Year = 2020, NumberOfDoors = 4 });
vehicles.Add(new BikePM { Brand = "Honda", Model = "CBR", Year = 2020, NumberOfWheels = 2 });
vehicles.Add(new PlanePM { Brand = "Boeing", Model = "747", Year = 2020, NumberOfEngines = 4 });

foreach (var vehicle in vehicles)
{
    if (vehicle is CarPM)
    {
        var carPM = (CarPM)vehicle;
        Console.WriteLine($"Car: {carPM.Brand} {carPM.Model} {carPM.Year} {carPM.NumberOfDoors}");
        carPM.Start();
    }
    else if (vehicle is BikePM)
    {
        var bikePM = (BikePM)vehicle;
        Console.WriteLine($"Bike: {bikePM.Brand} {bikePM.Model} {bikePM.Year} {bikePM.NumberOfWheels}");
        bikePM.Start();
    }
    else if (vehicle is PlanePM)
    {
        var planePM = (PlanePM)vehicle;
        Console.WriteLine($"Plane: {planePM.Brand} {planePM.Model} {planePM.Year} {planePM.NumberOfEngines}");
        planePM.Start();
    }
}


//Good example - Using polymorphism
List<VehiclePM> vehiclesPM = new List<VehiclePM>
{
    new CarPM { Brand = "Toyota", Model = "Corolla", Year = 2020, NumberOfDoors = 4 },
    new BikePM { Brand = "Honda", Model = "CBR", Year = 2020, NumberOfWheels = 2 },
    new PlanePM { Brand = "Boeing", Model = "747", Year = 2020, NumberOfEngines = 4 },
};

foreach (var vehiclePM in vehiclesPM)
{
    Console.WriteLine($"{vehiclePM.Brand} {vehiclePM.Model} {vehiclePM.Year}");
    vehiclePM.Start();
    vehiclePM.Stop();
    Console.WriteLine("--------------------------------");
}
///////////////////////////////////////////

///// Coupling - using Interfaces///////////

BadOrder badOrder = new();
badOrder.PlaceOrder();

GoodOrder goodOrderWithEmail = new(new EmailSender());
goodOrderWithEmail.PlaceOrder();

GoodOrder goodOrderWithSms = new(new SmsSender());
goodOrderWithSms.PlaceOrder();

////////////////////////////////////////////

/////Composition///////
CarComposition carComposition = new();
carComposition.StartCar();
///////////////////////////