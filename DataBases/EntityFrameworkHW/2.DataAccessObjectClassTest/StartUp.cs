namespace _2.DataAccessObjectClassTest
{
    using System;

    using DataAccessObjectClass;
    using NorthwindDB.Entities;

    public class StartUp
    {
        private static void Main()
        {
            InsertCustomerTest();
            ModifyCustomerTest();
            DeleteCustomerTest();
        }

        private static void InsertCustomerTest()
        {
            var customer = new Customer()
            {
                CustomerID = "TESTA",
                CompanyName = "Best",
                ContactName = "Stamat Peshov",
                ContactTitle = "CEO"
            };

            var affectedRows = DataAccessClass.InsertCustomer(customer);

            Console.WriteLine($"\rInserted -> ({affectedRows} affected row(s))");
        }

        private static void ModifyCustomerTest()
        {
            var affectedRows = DataAccessClass.ModifyCustomerCompany("TESTA", "Awesome");

            Console.WriteLine($"Modified -> ({affectedRows} affected row(s))");
        }

        private static void DeleteCustomerTest()
        {
            var affectedRows = DataAccessClass.DeleteCustomer("TESTA");

            Console.WriteLine($"Deleted -> ({affectedRows} affected row(s))");
        }
    }
}
