using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Lambda
    {
        //Delegate for lambda expression
        public delegate int newDelegate(int a, int b);

        newDelegate del = (a, b) =>
        {
            return a + b;
        };
        public void displayAddition()
        {
            Console.WriteLine("Additon is :" + del(10, 5));
        }
    }

    //Activity 1
    class Example1
    {
        //Filter even number
        private List<int> nums = new List<int> { 10, 25, 30, 45, 50, 65 };
        public void displayEven()
        {
            List<int> evenNumbers = nums.FindAll(n => n % 2 == 0);
            Console.WriteLine("Even Numbers");
            foreach(int item in evenNumbers)
            {
                Console.WriteLine(item+" "); 
            }
        }
    }
    class Example2
    {
        private List<String> names = new List<String>
        {
            "Ankita", "Neha", "Rahul", "Akash", "Anuradha",
        };
        public void displayNamesWithA()
        {
            List<String> result = names.FindAll(name => name.StartsWith("A"));

            Console.Write("Names staring with A : ");
            foreach (String str in result)
            {
                Console.Write(str + " ");
            }
        }
    }
    //Activity 2 - Where we use in company 
    //Data filtering - Companies filter data from large datasets
    //Searching and Sorting Data - Applications frequently sort or search records.
    //Database Queries -Backend developers use lambda expressions to query databases.
    //API Development - Companies return filtered API responses using lambdas.
    //Event Handling & Asynchronous Programming - Lambda expressions simplify callbacks and async operations.

    //Activity 3 - Create a generic class and store two values by using lambda expression
    class NewClass<T>
    {
        public T num1;
        public T num2;

        public delegate void storeDelegate(T a, T b);

        public void storeValues(T a, T b)
        {
            storeDelegate store = (x, y) =>
            {
                num1 = x;
                num2 = y;
            };
            store(a, b);
        }
        public void displayValue()
        {
            Console.WriteLine("Value 1"+num1);
            Console.WriteLine("Value 2" + num2);
        }
    }
    internal class LambdaExp
    {
    }
}
