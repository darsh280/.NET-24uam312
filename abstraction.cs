/*
Abstraction : means hiding implementation and showing only important features.
              Abstract class cannot be instantiated
              Abstract method has no body
              Child class implements it
*/
using System;

// Abstract class
abstract class Shape
{
    // Abstract method (no body)
    public abstract void Draw();

    // Normal method
    public void Display()
    {
        Console.WriteLine("This is a shape.");
    }
}

// Child class implementing abstract method
class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Circle...");
    }
}

class Program
{
    static void Main()
    {
        Shape s = new Circle();  // Parent reference, child object
        s.Draw();                // Calls Circle's method
        s.Display();             // Calls common method

        Console.ReadLine();
    }
}
