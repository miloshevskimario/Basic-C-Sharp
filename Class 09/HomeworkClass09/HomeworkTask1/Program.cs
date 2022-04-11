using System;
using System.Collections.Generic;

namespace HomeworkTask1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Queue<int> userInput = new Queue<int>();

            Console.WriteLine("Please enter your 5 numbers");
            int number;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Please enter number {i + 1}: ");

                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Invalid input, please try again!");
                    Console.WriteLine($"Please enter number {i + 1}");
                }

                userInput.Enqueue(number);
            }

            Console.WriteLine("Your queue of numbers: ");
            foreach (var numbers in userInput)
            {
                Console.WriteLine(numbers);
            }


        }
    }
}
