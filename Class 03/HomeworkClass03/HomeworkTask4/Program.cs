using System;

namespace HomeworkTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a new console application.
            //Create an array of 10 whole numbers(integers).
            //Find the minimum and maximum and print them in the console.

            int[] integerArray = {2, 23, 34, 77, 8, 102, 225, 95060, 24, -2 };
            
            int i, max, min, n;

            n = 10;
            max = integerArray[0];
            min = integerArray[0];

            for (i = 1; i < n; i++)
            {
                if (integerArray[i] > max)
                {
                    max = integerArray[i];
                }

                if (integerArray[i] < min)
                {
                    min = integerArray[i];
                }
            }

            Console.Write("Maximum element = {0}\n", max);
            Console.Write("Minimum element = {0}\n\n", min);
        }
    }
}
