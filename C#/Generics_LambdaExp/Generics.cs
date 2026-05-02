using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //Generics in Class
    class myClass<T>
    {
        public T Data;
        public void show()
        {
            Console.WriteLine(Data);
        }
    }
    class Activity1
    {
        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }

    //Activity 2 - real life example of generics
    //Generics are widely used in collection classes to store data safely.
    //generics are used to create reusable database operations.
    //Instead of writing separate code for : Student table , Employee table, Product table We create one generic repository:
    //Repository<T>
    //Generics help return different types of responses from APIs.
    //Generic methods allow algorithms to work with any datatype. e.g - sorting number, sorting names, sorting objects
    //generic delegates are used in asynchronous programming and callbacks.

    //Activity 3 - why companies use generics
    //Companies use Generics because they help developers write reusable, safe, and efficient code
    //that works with different data types without rewriting logic again and again.
    //Code Reusability
    //Type Safety (Fewer Runtime Errors)
    //Better Performance
    //Easy Maintenance
    //Scalable Software Development

    internal class Generics
    {
        //generic allows us to define classes, methods or collections with a placeholder for datatype
        //so they work with any type , while maintaining type safety
        //lambda exp in c#
        //A lambda expression is a shorter way to write a anonymous method using arrow => operator

        List<int> num = new List<int>();
        public Generics() {
            num.Add(10);
            num.Add(20);
            foreach (int i in num) { 
                Console.WriteLine(i+" ");
            }
            //num.Add("#"); this will give error 
        }

    }

}
//Write 2 examples with generics
//where we use generics in company level
//why company use generics

//write 2 example of lambda expression
//where we use 
//create a generic class and use 

//what is generics 
//why is generic are better than arraylist
//what is lambda expression
//what is defference bet lambda and delegate
