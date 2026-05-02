using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Experiments
{
    internal class Array_activity
    {
        public void displayArray(int[] array) {
            Console.WriteLine("Array Element loop through");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public void arraySort(int[] array) {
            Console.WriteLine("Sorting Number Array");
            Array.Sort(array);
            foreach(int i in array)
            {
                Console.WriteLine(i);   
            }

            Console.WriteLine("Sorting string Array");
            string[] fruits = { "mango", "apple", "banana", "orange" };
            Array.Sort(fruits);
            foreach(string s in fruits)
            {
                Console.WriteLine(s); 
            }
        }
        public void multiDementionalArray()
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine("Multi Dimentional Array");
            foreach(int i in arr)
            {
                Console.WriteLine(i); 
            }
        }
    }
}
