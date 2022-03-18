using System;

namespace HomeworkTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.
            //Test Data:
            //Enter the First number: 10
            //Enter the Second number: 15
            //Enter the third number: 20
            //Enter the four number: 30
            //Expected Output:
            //The average of 10, 15, 20 and 30 is: 18

            Console.WriteLine("Task 2: Average Number");
      
            int num1;
            int num2;
            int num3;
            int num4;
            
            Console.WriteLine("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fourth number: ");
            num4 = int.Parse(Console.ReadLine());

            int average = (num1 + num2 + num3 + num4) / 4;


            Console.WriteLine("The average of your numbers is : " + average);
            Console.ReadLine();
        }
    }
}
