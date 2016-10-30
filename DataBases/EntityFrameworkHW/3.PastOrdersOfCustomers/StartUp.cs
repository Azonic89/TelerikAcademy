namespace _3.PastOrdersOfCustomers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using NorthwindDB.Entities;

    public class StartUp
    {
        private static void Main()
        {
            foreach (var customer in CustomerPastOrders())
            {
                Console.WriteLine(customer.CustomerID);
            }           
        }

        private static IEnumerable<Customer> CustomerPastOrders()
        {
            var entities = new List<Customer>();

            var orderDateYear = 1997;
            var shipCountry = "Canada";

            using (var context = new NorthwindEntities())
            {
                entities = (from customer in context.Customers
                            join order in context.Orders on customer.CustomerID equals order.CustomerID
                            where order.OrderDate.Value.Year == orderDateYear && order.ShipCountry == shipCountry
                            select customer).ToList();
            }

            return entities;
        }
    }
}
