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

        static void Main(string[] args)
        {
            Program obj = new Program();
            myDel del = new myDel(obj.fun1);
            del += obj.fun2;
            del();
        }
    }
    
}
