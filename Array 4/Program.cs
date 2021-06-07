using System;




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
    static void Main(string[] args)
    {
        // Declare and initialize an array:
        String[] weekDays = new string[] { "sunday", "monday", "tuesday", "wednessday", "thusday", "Friday", "saterday" };
        // Pass the array as a parameter:
        PrintArray(weekDays[]);

    }
}

