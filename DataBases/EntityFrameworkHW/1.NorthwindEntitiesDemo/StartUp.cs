namespace NorthwindEntitiesDemo
{
    using System;
    using System.Linq;

    using NorthwindDB.Entities;

    public class StartUp
    {
        private static void Main()
        {
            using (var context = new NorthwindEntities())
            {
                var contacts = context.Customers.Select(c => c.ContactName);
                Console.WriteLine(string.Join(Environment.NewLine, contacts));
            }
        }
    }
}
