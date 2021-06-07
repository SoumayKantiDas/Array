using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 4, 5, 6, 1, 1, 2, 3, -2, -1, 0 };
            foreach (int i in number)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
