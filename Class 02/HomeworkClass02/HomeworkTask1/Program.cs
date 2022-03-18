using System;

namespace HomeworkTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done
            //( +, - , * , / ). Then it returns the result.
            //Test Data:
            //Enter the First number: 10
            //Enter the Second number: 15
            //Enter the Operation: +
            //Expected Output: The result is: 25

            Console.WriteLine("Task 1: Real Calculator");

            int num1;
            int num2;
            int result;

            Console.WriteLine("Enter the first number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter an operator");
            Console.WriteLine(" + (PLUS)");
            Console.WriteLine(" - (MINUS)");
            Console.WriteLine(" * (MULTIPLY)");
            Console.WriteLine(" / (DIVIDE)");

            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                    break;

                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                    break;

                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                    break;

                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"Your result: {num1} / {num2} =" + result);
                    break;

                default:
                    Console.WriteLine("That was not a valid option");
                    break;
            }
        }
    }
}
