namespace _6.NorthwindTwinClone
{
    using System;
    using System.Linq;

    using NorthwindDB.Entities;

    public class StartUp
    {
        private static void Main()
        {
            // App.Config Connection string is changed to NorthwindTwin and DB was created/clone after this console app finished
            // I have provided ScreenShots if u dont have time fixing connection strings.
            using (var context = new NorthwindEntities())
            {
                context.Database.CreateIfNotExists();
                Console.WriteLine("\rNumbers of customers: " + context.Customers.Count());
            }
        }
    }
}
