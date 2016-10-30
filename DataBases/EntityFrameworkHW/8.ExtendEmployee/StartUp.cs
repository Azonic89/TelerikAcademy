namespace _8.ExtendEmployee
{
    using System;
    using System.Linq;

    using NorthwindDB.Entities;

    public class StartUp
    {
        private static void Main()
        {
            // See file -> Northwind.Models -> `Employee.cs

            using (var dbContext = new NorthwindEntities())
            {
                foreach (var employee in dbContext.Employees.Include("Territories"))
                {
                    var correspondingTerritories = employee.Territories.Select(c => c.TerritoryID);
                    var correspondingTerritoriesAsString = string.Join(", ", correspondingTerritories);
                    Console.WriteLine($"{employee.FirstName} -> Territory IDs: {correspondingTerritoriesAsString}");
                }
            }
        }
    }
}
