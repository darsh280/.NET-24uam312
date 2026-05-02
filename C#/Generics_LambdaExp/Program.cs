using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        public delegate void myDel();
        public void fun1()
        {
            Console.WriteLine("Function1 call()");

        }
        public void fun2()
        {
            Console.WriteLine("function2 call()");

        }
        public void fun3() {
            Console.WriteLine("Function 3 call()");
        }


        static void Main(string[] args)
        {
            //Program obj = new Program();
            //myDel del = new myDel(obj.fun1);
            //del -= obj.fun2;
            //del += obj.fun3;
            //del();

            //24-02-2026 Lecture work
            Console.WriteLine("Generics :");
            Console.WriteLine("List: ");
            Generics g1 = new Generics();

            Console.WriteLine();    
            Console.WriteLine("Generics in class");

            myClass<int> obj1 = new myClass<int>();
            obj1.Data = 10;
            obj1.show();

            myClass<string> obj2 = new myClass<string>();
            obj2.Data = "Ankita";
            obj2.show();

            Console.WriteLine();
            Console.Write("Lambda Expression : ");
            Lambda l1 = new Lambda();
            l1.displayAddition();

            Console.WriteLine();
            Console.Write("generics - Activity 1: ");
            int x = 10, y = 15;
            Activity1 a1 = new Activity1();
            a1.Swap<int>(ref x, ref y);
            Console.WriteLine("After swapping (int): " + x + "," + y);

            string s1 = "Hello", s2 = "World";
            a1.Swap<String>(ref s1, ref s2);
            Console.WriteLine("After swapping (String): " + s1 + "," + s2);

            Console.WriteLine();
            Console.Write("lambda expression - Activity 1: ");
            Example1 e1 = new Example1();
            e1.displayEven();

            Console.WriteLine();
            Console.Write("lambda expression - Activity 1: ");
            Example2 e2 = new Example2();
            e2.displayNamesWithA();

            Console.WriteLine();
            Console.Write("lambda expression - Activity 3: ");
            NewClass<int> myObj = new NewClass<int>();
            myObj.storeValues(10, 20);
            myObj.displayValue();
        }
    }
    
}
