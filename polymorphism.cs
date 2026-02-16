/*
 Polymorphism : means one method behaves differently for different objects.
                Polymorphism means one method, many forms.
                Different behavior for different objects
*/
using System;

// Parent class
class Vehicle
{
    // Virtual method
    public virtual void Run()
    {
        Console.WriteLine("Vehicle is running...");
    }
}

// Child class overrides method
class Bike : Vehicle
{
    public override void Run()
    {
        Console.WriteLine("Bike is running fast...");
    }
}

// Another child class
class Car : Vehicle
{
    public override void Run()
    {
        Console.WriteLine("Car is running smoothly...");
    }
}

class Program
{
    static void Main()
    {
        Vehicle v1 = new Bike();  // Parent reference, Bike object
        Vehicle v2 = new Car();   // Parent reference, Car object

        v1.Run();  // Calls Bike's version
        v2.Run();  // Calls Car's version

        Console.ReadLine();
    }
}
