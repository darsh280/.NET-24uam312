using System;

class ArithmeticOperations
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double addition = num1 + num2;
        double subtraction = num1 - num2;
        double multiplication = num1 * num2;
        double division = num1 / num2;

        Console.WriteLine("\n--- Arithmetic Operations Result ---");
        Console.WriteLine("Addition: " + addition);
        Console.WriteLine("Subtraction: " + subtraction);
        Console.WriteLine("Multiplication: " + multiplication);

        if (num2 != 0)
        {
            Console.WriteLine("Division: " + division);
        }
        else
        {
            Console.WriteLine("Division: Cannot divide by zero");
        }
        Console.ReadLine();
    }
}
