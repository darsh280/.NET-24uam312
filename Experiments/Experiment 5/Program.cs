using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ////Synchronous
            //task1();
            //task2();
            //task3();
            //task4();
            //task5();

            ////Asynchronous
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Console.ReadLine();
            //hold execution 
            //to hold the console text or the console values so all text remain on console one after another as the method executes
            //if we do not write Console.ReadLine() then it shows improper behaviour  the output will not be displayed properly 

            //Activty 4 
            Console.WriteLine();
            Console.WriteLine("Activity 4 : ");
            Console.WriteLine("Main started...");

            await DoWorkAsync();
            //if our main is synchronous so we cannot use await so then we can use .Wait() or .GetAwaiter().GetResult()



            //calling async method with return type 
            int result = await AddNumbersAsync();
            //if the main is not async we have to write AddNumbersAsync().Result --> that extracts the integer value after task completes.
            Console.WriteLine("result : " + result);

            Console.WriteLine("Main finished");
        }

        //asyc method returning task
        static async Task DoWorkAsync()
        {
            Console.WriteLine("Work started..");
            await Task.Delay(3000);
            Console.WriteLine("Work finished.");
        }

        //method returning int value 
        static async Task<int> AddNumbersAsync()
        {
            await Task.Delay(1000);
            return 10 + 20;
        }

        //Synchronous Programming
        public static void task1()
        {
            Console.WriteLine("TAsk 1 starts");
            //Thread.Sleep(3000);
            Console.WriteLine("task1 Executed");
        }
        public static void task2()
        {
            Console.WriteLine("Task 2 starts");
            //Thread.Sleep(2000);
            Console.WriteLine("Task 2 Executed");
        }
        public static void task3()
        {
            Console.WriteLine("Task 3 Starts");
            //Thread.Sleep(1000);
            Console.WriteLine("Task3 Executed");
        }
        public static void task4()
        {
            Console.WriteLine("Task 4 Started");
            //Thread.Sleep(6000);
            Console.WriteLine("Task 4 Executed");
        }
        public static void task5()
        {
            Console.WriteLine("Task 5 Started");
            //Thread.Sleep(4000);
            Console.WriteLine("Task 5 Exected");
        }

        //Asychronous Programming
        public async static void Task1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("TAsk 1 starts");
                //Thread.Sleep(3000);
                Task.Delay(3000);
                Console.WriteLine("task1 Executed");
            });
        }
        public async static void Task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 2 starts");
                //Thread.Sleep(2000);
                Task.Delay(2000);
                Console.WriteLine("Task 2 Executed");
            });

        }
        public async static void Task3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 3 Starts");
                //Thread.Sleep(1000);
                Task.Delay(1000);
                Console.WriteLine("Task3 Executed");
            });

        }
        public async static void Task4()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 4 Started");
                //Thread.Sleep(6000);
                Task.Delay(6000);
                Console.WriteLine("Task 4 Executed");
            });
        }
        public async static void Task5()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 5 Started");
                //Thread.Sleep(4000);
                Task.Delay(4000);
                Console.WriteLine("Task 5 Exected");
            });

        }

    }
}
//Activity 1- Run program Synchronously
//2. Convert to asynchronous
//3. replace Thread.spleep with Task.Delay ... observe behaviour
//4. create method and returning task