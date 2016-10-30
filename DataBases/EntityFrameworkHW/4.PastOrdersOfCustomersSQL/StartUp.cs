using System;
using System.Collections.Generic;
using System.Linq;
using NorthwindDB.Entities;

namespace _4.PastOrdersOfCustomersSQL
{
    public class StartUp
    {
        private static void Main()
        {
            CustomerPastOrdersSql(1997, "Canada");
        }

        private static void CustomerPastOrdersSql(int year, string country)
        {
            var queryTemplate = @"SELECT *
                    FROM Customers c
                    JOIN Orders o
                        ON o.CustomerID = c.CustomerID
                    WHERE o.ShipCountry = '{1}' AND YEAR(o.OrderDate) = {0}";

            var query = string.Format(queryTemplate, year, country);

            var context = new NorthwindEntities();
            var customers = context.Customers.SqlQuery(query).Distinct().ToList();

            Console.WriteLine($"Customers with NativeSQL, OrderYear: {year}, Country: {country}");
            foreach (var customer in customers)
            {
                Console.WriteLine($"Name: {customer.ContactName}, Country: {customer.Country}");
            }

            Console.WriteLine();
        }
    }
}
