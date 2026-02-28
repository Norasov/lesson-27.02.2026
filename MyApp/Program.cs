// using Domain.Models;

// Person persons = new();
// persons.Greeet();
// persons.Greeet();
// Student person = new Student();
// person.SetAge(21);
// person.ShowAge();
// person.Study();
// persons.Greeet();
// Teacher teacher = new();
// teacher.Explain();

// task-2;
// using Domain.Models;

// Rectangle rectangle = new("Red", 5, 3);
// Circle circle = new("Blue", 4);

// Console.WriteLine(rectangle.GetInfo());
// Console.WriteLine(circle.GetInfo());

// Shape s1 = rectangle;
// Shape s2 = circle;

// Console.WriteLine("\nPolymorphism:");
// Console.WriteLine(s1.GetInfo());
// Console.WriteLine(s2.GetInfo());



// Task-3;

// Lamp lamp = new("Living Room", "Warm White");
// Thermostat thermostat = new("Hall", 22.5);
// Lock smartLock = new("Front Door", "1234");

// lamp.TurnOn();
// lamp.SetBrightness(80);
// lamp.ChangeColor("Blue");
// lamp.ShowStatus();

// Console.WriteLine();

// // Thermostat
// thermostat.TurnOn();
// thermostat.SetTargetTemperature(24);
// thermostat.UpdateCurrentTemperature(23.2);
// thermostat.ShowStatus();

// Console.WriteLine();

// smartLock.TurnOn();
// smartLock.ShowStatus();
// smartLock.UnlockDoor("1111"); 
// smartLock.UnlockDoor("1234");
// smartLock.ShowStatus();
// smartLock.LockDoor();
// smartLock.ShowStatus();

// Console.WriteLine();

// List<IDevice> devices = new() { lamp, thermostat, smartLock };

// Console.WriteLine("Turning all devices off through IDevice interface:");
// foreach (var device in devices)
// {
//     device.TurnOff();
// }