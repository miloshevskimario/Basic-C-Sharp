using System;
using System.Collections.Generic;
using Task03.Model;
using Task03.Enum;
using System.Linq;

namespace Task03
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            List<Animal> dogs = new List<Animal>()
            {
                new Animal() { Name = "Tom", Age = 2, Color = "White", Gender = GenderEnum.Male },
                new Animal() { Name = "Jerry", Age = 5, Color = "Brown", Gender = GenderEnum.Female },
                new Animal() { Name = "Tommy", Age = 7, Color = "Brown", Gender = GenderEnum.Female },
                new Animal() { Name = "William", Age = 5, Color = "Yellow", Gender = GenderEnum.Male },
                new Animal() { Name = "Rex", Age = 1, Color = "Orange", Gender = GenderEnum.Male },
                new Animal() { Name = "Duchess", Age = 8, Color = "White", Gender = GenderEnum.Female },
                new Animal() { Name = "Sparky", Age = 10, Color = "Brown", Gender = GenderEnum.Female },
                new Animal() { Name = "Attila", Age = 3, Color = "Brown", Gender = GenderEnum.Male },
            };

            // Find the names of all the animals aged 5 or more

            List<Animal> dogsWithAgeFiveorMore = dogs.Where(d => d.Age >= 5).ToList();

            Console.WriteLine("Dogs age 5 or older than 5: ");

            foreach (Animal dog in dogsWithAgeFiveorMore)
            {
                Console.WriteLine(dog.Name);
            }

            // Find all the names of the animals that start with 'A'

            List<Animal> dogsThatStartWithA = dogs.Where(d => d.Name.StartsWith("A")).ToList();

            Console.WriteLine("Dog names that start with A: ");

            foreach (Animal dog in dogsThatStartWithA)
            {
                Console.WriteLine(dog.Name);
            }

            // Find all female, white Animals

            List<Animal> femaleWhiteDogs = dogs.Where(d => d.Gender == GenderEnum.Female && d.Color == "White").ToList();

            Console.WriteLine("Female white dogs");

            foreach (Animal dog in femaleWhiteDogs)
            {
                Console.WriteLine(dog.Name);
            }

            // Find the first animal whose name is longer than 10 characters

            Animal longerThanTenName = dogs.FirstOrDefault(d => d.Name.Length > 5); // more realistic to check with 5 for name.length instead of 10

            Console.WriteLine("First dog whose name is longer than 10 characters");

            Console.WriteLine(longerThanTenName.Name);

 
        }
    }
}
