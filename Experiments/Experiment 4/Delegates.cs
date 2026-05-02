using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Experiments
{
    internal class Delegates
    {
        //single cast delegate
        public delegate void MyDelegate(string msg);
        public delegate void Notify();
        public delegate int Operation(int a, int b);
        public delegate int Square(int value);

        public static void DisplayMessage(string message)
        {
            Console.WriteLine("Message : " + message);
        }

        public static void perform()
        {
            MyDelegate myd1 = DisplayMessage;
            myd1("Hello from c#");
        }

        //activity 2 - multicast delegate exmaple
        //multicast delagte
        public static void MethodA() => Console.WriteLine("Method A executed");
        public static void MethodB() => Console.WriteLine("Method B executed");

        public static void multiCastDelegate()
        {
            Notify notify = MethodA;
            notify += MethodB;

            notify();
        }

        //activity 1 - calculator with the delegates(+, -, *, /)
        //delegate with return type
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static int Divide(int x, int y)
        {
            return x / y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static void DelegateWithReturn()
        {
            Operation op = Add;
            Console.WriteLine("Addition : " + op(5, 3));

            op = Multiply;
            Console.WriteLine("Multiplication : " + op(5, 3));

            op += Divide;
            Console.WriteLine("Divide: " + op(15, 5)); //here the division function is called directly because it is added last

            op += Subtract;

            //to call all function one by one
            Console.WriteLine("Calling all method one by one : ");
            Delegate[] myDelegates = op.GetInvocationList();

            foreach (Operation del in myDelegates)
            {
                int result = del.Invoke(15, 5);
                Console.WriteLine($"Method : {del.Method.Name}, Result : {result}");
            }

        }

        //activity 3 - replace method with the lambda expression
        public static int getSquare(int val) => val * val;

        public static void lambdaExpression()
        {
            Square sq = getSquare;
            Console.WriteLine($"Square of number : {sq(5)}");
        }

        //Activity 4 - sort list using the lambda expression
        public static void SortList()
        {
            List<int> num = new List<int> { 5, 7, 1, 3, 2, 4, 8 };

            num.Sort((a, b) => a.CompareTo(b));
            Console.Write("Sorted in Ascending order -->  ");
            foreach (int val in num)
            {
                Console.Write(val + " ");
            }

            num.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine();
            Console.Write("Sorted in Descending order -->  ");
            foreach (int val in num)
            {
                Console.Write(val + " ");
            }
        }

        //Activity 5 - Industry use cases of delegates and lambda expression (where is it used )
        //Delegate --> Reference to the method (what work to do)
        //Lambda Expression --> A short way to write function (quick way to write the work)
        //Delegates are used in industry to perform various tasks like handling button click event , filtering large data , sorting data , background tasks etc
        //lambda expression provide a short and readable way to perform this delegate methods.


        //Activity 6 -- What is linq queries 
        //LINQ - Language Integrated Query
        //Writing database queries directly inside the C# code to work with data.
        //Instead of writing long loops (for, if) LINQ let us you search, filter, sort, and transform data easily.
        //Definition --> LINQ is a feature in C# used to query and manipulate collections like lists, arrays, or databases using simple query syntax.
        public static void linqExample()
        {
            List<int> myList = new List<int> { 7, 8, 9, 5, 2, 3, 1, 4 };

            var result = myList.Where(n => n > 5);

            foreach (var item in result)
                Console.Write(item + " ");
        }
    }
}
