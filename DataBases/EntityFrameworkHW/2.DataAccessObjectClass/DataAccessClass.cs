namespace _2.DataAccessObjectClass
{
    using System;
    using System.Linq;

    using NorthwindDB.Entities;

    public static class DataAccessClass
    {
        public static int InsertCustomer(Customer customer)
        {
            var affectedRows = 0;

            using (var context = new NorthwindEntities())
            {
                // To Log all EF activity on the Console.
                context.Database.Log = Console.WriteLine;
                context.Customers.Add(customer);
                affectedRows = context.SaveChanges();
            }

            return affectedRows;
        }

        public static int ModifyCustomerCompany(string customerId, string newCompanyName)
        {
            var affectedRows = 0;

            using (var context = new NorthwindEntities())
            {
                // To Log all EF activity on the Console.
                context.Database.Log = Console.WriteLine;
                var targetCustomer = context.Customers.Find(customerId);
                targetCustomer.CompanyName = newCompanyName;
                affectedRows = context.SaveChanges();
            }

            return affectedRows;
        }

        public static int DeleteCustomer(string customerId)
        {
            var affectedRows = 0;

            using (var context = new NorthwindEntities())
            {
                // To Log all EF activity on the Console.
                context.Database.Log = Console.WriteLine;
                var customerToDelete = context.Customers.Where(x => x.CustomerID == customerId);

                // .Count() > 0
                if (customerToDelete.Any()) 
                {
                    foreach (var customer in customerToDelete)
                    {
                        context.Customers.Remove(customer);
                    }
                }

                affectedRows = context.SaveChanges();
            }

            return affectedRows;
        }
    }
}
