using System;

namespace HomeworkTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap
            //the values of the variables so that the first variable has the second value and the second variable the first value.
            //Please find example below:

            //Test Data:
            //Input the First Number: 5
            //Input the Second Number: 8
            //Expected Output:
            //After Swapping:
            //First Number: 8
            //Second Number: 5

            Console.WriteLine("Task 3: Swap Numbers");
            
            int num1;
            int num2;
            int swap;
            
            Console.WriteLine("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());

            swap = num1;
            num1 = num2;
            num2 = swap;

            Console.WriteLine($"After swaping, the first number is {num1}, and the second number is {num2}");
            Console.Read();







        }
    }
}
