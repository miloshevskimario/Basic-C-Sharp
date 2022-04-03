using System;

namespace HomeworkTask2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write a sentence");

            string userInput = Console.ReadLine();
            string[] word = userInput.Split(' ');           

            foreach (string item in word)
            {
                Console.WriteLine(item);
            }
        }
    }
}
