using System;

namespace HomeworkTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a text");
            string myString = Console.ReadLine();


            string subString = myString.Substring(myString.Length - 5);
            Console.WriteLine(subString);
        }
    }
}
