using HomeworkTask2.Methods;
using System;

namespace HomeworkTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human(ReadInput("First name"), ReadInput("Last name"), ReadInput("Age"));

            Console.WriteLine(human.GetPersonStats());

            string ReadInput(string input)
            {
                Console.WriteLine("Enter " + input);
                return Console.ReadLine();

            }
        }
    }
}
