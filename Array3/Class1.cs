using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClass
{
    class ArrayClass
    {
        static void PrintArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "{0}", i < arr.Length - 1 ? " " : "");
            }
            Console.WriteLine();
        }
    }
}
