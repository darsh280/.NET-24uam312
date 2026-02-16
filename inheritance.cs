/*
Inheritance : allows a class to access properties and methods of another class.
              Child class inherits parent class.
              implemented with : (child class : parent class) ex. class Dog:Animal
              Dog can use Animal’s methods. 
*/
using System;

// Parent class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating...");
    }
}

// Child class inherits Animal
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking...");
    }
}

class Program
{
    static void Main()
    {
        Dog d1 = new Dog();

        d1.Eat();   // Inherited method
        d1.Bark();  // Own method

        Console.ReadLine();
    }
}
