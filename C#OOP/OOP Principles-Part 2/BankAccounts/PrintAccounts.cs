namespace BankAccounts
{
    using System;

    public class PrintAccounts
    {
        public static void Print(Account[] accounts)
        {
            foreach (var item in accounts)
            {
                Console.WriteLine(new string('*', 40));
                Console.WriteLine("Type: " + item.Customer.CustomerType);
                Console.WriteLine("Name: " + item.Customer.FullName);
                Console.WriteLine("Address: " + item.Customer.Address);
                Console.WriteLine("Telephone number: " + item.Customer.PhoneNumber);
                Console.WriteLine("Interest amount: " + item.InterestAmount(9));
                Console.WriteLine(new string('*', 40));
            }
        }
    }
}
