using System;
using Domain.Models;
using Domain.Enums;

namespace Domain
{
    public static class Exercise
    {
        private static void Main(string[] args)
        {
            Contractor contractor01 = new Contractor
            {
                FirstName = "Bob",
                LastName = "Bobby",
            };

            Contractor contractor02 = new Contractor
            {
                FirstName = "Rick",
                LastName = "Ricky", 
            };

            Manager manager01 = new Manager
            {
                FirstName = "Rob",
                LastName = "Robby"
            };

            Manager manager02 = new Manager
            {
                FirstName = "John",
                LastName = "Johny"
            };

            SalesPerson salesMan = new SalesPerson
            {
                FirstName = "Jack",
                LastName = "Jacky"
            };

            object[] company = new object[5] { contractor01, contractor02, manager01, manager02, salesMan };

            CEO ceo = new CEO("Ron", "Ronny", 1200, 20, new string[] { "Bob Bobby", "Rick Ricky", "Rob Robby", "John Johny", "Jack Jacky" });

            Console.WriteLine("CEO:");

            ceo.AddSharesPrice(200);
            ceo.PrintInfo();
            ceo.GetSalary();
            ceo.PrintEmployees();

        }
    }
}
