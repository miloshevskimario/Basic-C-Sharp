﻿using System;

namespace HomeworkTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a console application called SumOfEven. Inside it create an array of 6 integers.Find and print the sum of the even numbers from the array:

            //Test Data:
            //Enter integer no.1: 4
            //Enter integer no.1: 3
            //Enter integer no.1: 7
            //Enter integer no.1: 3
            //Enter integer no.1: 2
            //Enter integer no.1: 8
            //Expected Output:
            //The result is: 14

            int[] integerArray = new int[6];
            integerArray[0] = 4;
            integerArray[1] = 3;
            integerArray[2] = 7;
            integerArray[3] = 3;
            integerArray[4] = 2;
            integerArray[5] = 8;

            int sum = 0;

            Console.WriteLine("Printing Array");
            for (int i = 0; i <= 8; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(integerArray[i]);
                }
            }
        }
    }
}
