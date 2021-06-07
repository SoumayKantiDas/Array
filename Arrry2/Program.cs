using System;

namespace Arrry2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers2D = new int[3, 2] { { 9, 9 }, { 3, 33 }, { 5, 55 } };
            foreach( int i in numbers2D)
            {
                Console.WriteLine( "{0}" ,i);
            }
        }
    }
}
