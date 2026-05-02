using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Experiments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array_activity arr = new Array_activity();
            int[] array = { 58, 20, 37, 46 };
            arr.displayArray(array);
            arr.arraySort(array);
            arr.multiDementionalArray();
        }
    }
}
