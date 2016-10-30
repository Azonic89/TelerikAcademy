namespace _5.SpecificSalesByRegionPeriod
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using NorthwindDB.Entities;

    public class StartUp
    {
        private static void Main()
        {
            foreach (var customer in SalesBySpecifiedRegionAndDatePeriod("Essex", new DateTime(1996, 6, 1), new DateTime(2000, 6, 1)))
            {
                Console.WriteLine(string.Join("-", customer.OrderDate, customer.OrderID));
            }          
        }

        private static IEnumerable<Order> SalesBySpecifiedRegionAndDatePeriod(string region, DateTime? startDate, DateTime? endDate)
        {
            var entities = new List<Order>();

            using (var context = new NorthwindEntities())
            {
                entities = (from order in context.Orders
                            where order.ShipRegion == region &&
                                  order.OrderDate >= startDate &&
                                  order.OrderDate <= endDate
                            select order).ToList();
            }

            return entities;
        }
    }
}
