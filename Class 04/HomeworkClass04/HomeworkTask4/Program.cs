using System;

namespace HomeworkTask4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose an operator +, -, *, /");
            string operation = Console.ReadLine();

            if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
            {
                Console.WriteLine("Invalid operation");
                return;
            }

            Console.WriteLine("Enter the first number");
            bool firstInputNumber = int.TryParse(Console.ReadLine(), out int firstNumber);

            Console.WriteLine("Enter the second number");
            bool secondInputNumber = int.TryParse(Console.ReadLine(), out int secondNumber);

            if (!firstInputNumber || !secondInputNumber)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            if (operation == "+")
            {
                int result = Sum(firstNumber, secondNumber);
                Console.WriteLine($"Sum of number: {result}");
            }

            else if (operation == "-")
            {
                int result = Subtraction(firstNumber, secondNumber);
                Console.WriteLine($"Subtraction of the numbers: {result}");
            }


            else if (operation == "*")
            {
                int result = Multiplication(firstNumber, secondNumber);
                Console.WriteLine($"Multiplication of the numbers: {result}");
            }

            else if (operation == "/")
            {
                int result = Division(firstNumber, secondNumber);
                Console.WriteLine($"Division of the numbers: {result}");
            }

            static int Sum(int num1, int num2)
            {
                return num1 + num2;
            }

            static int Subtraction(int num1, int num2)
            {
                return num1 - num2;
            }

            static int Multiplication(int num1, int num2)
            {
                return num1 * num2;
            }

            static int Division(int num1, int num2)
            {
                return num1 / num2;
            }






        }
    }
}
