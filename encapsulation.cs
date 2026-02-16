/*
Encapsulation : means hiding data and allowing access only through methods.
                Data is private.
                Access is through public methods.
*/
using System;

class Student
{
    // Private data members (hidden from outside)
    private string name;
    private int age;

    // Public method to set values
    public void SetDetails(string n, int a)
    {
        name = n;
        age = a;
    }

    // Public method to get values
    public void ShowDetails()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student();

        // Setting values using public method
        s1.SetDetails("Shravani", 20);

        // Accessing values using public method
        s1.ShowDetails();

        Console.ReadLine();
    }
}
