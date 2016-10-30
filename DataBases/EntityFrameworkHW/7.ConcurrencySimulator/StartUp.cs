namespace _7.ConcurrencySimulator
{
    using System;
    using System.Linq;

    using NorthwindDB.Entities;

    public class StartUp
    {
        private static void Main()
        {
            StartFirstConnection();
            PrintActualResult();
        }

        private static void StartFirstConnection()
        {
            using (var firstConnection = new NorthwindEntities())
            {
                PrintWhatFirstUserSees(firstConnection);
                StartSecondConnection(firstConnection);
                PrintWhatFirstUserSeesAfterChanges(firstConnection);
            }
        }

        private static void StartSecondConnection(NorthwindEntities firstConnection)
        {
            using (var secondConnection = new NorthwindEntities())
            {
                PrintWhatSecondUserSees(secondConnection);
                firstConnection.SaveChanges();
                secondConnection.SaveChanges();
                PrintWhatSecondUserSeesAfterChanges(secondConnection);
            }
        }

        private static void PrintWhatFirstUserSees(NorthwindEntities firstConnection)
        {
            Console.WriteLine($"\rUser1 see: {firstConnection.Employees.First().FirstName}\n");
            var firstEmployee1 = firstConnection.Employees.First();
            firstEmployee1.FirstName = "1";
            Console.WriteLine($"User1 changes the name with new value: {firstConnection.Employees.First().FirstName}\n");
        }

        private static void PrintWhatFirstUserSeesAfterChanges(NorthwindEntities firstConnection)
        {
            Console.WriteLine("After all changes:");
            Console.WriteLine($"User1 see: {firstConnection.Employees.First().FirstName}\n");
        }

        private static void PrintWhatSecondUserSees(NorthwindEntities secondConnection)
        {
            Console.WriteLine($"User2 see: {secondConnection.Employees.First().FirstName}\n");
            var firstEmployee2 = secondConnection.Employees.First();
            firstEmployee2.FirstName = "2";
            Console.WriteLine($"User2 changes the name with new value: {secondConnection.Employees.First().FirstName}\n");
        }

        private static void PrintWhatSecondUserSeesAfterChanges(NorthwindEntities secondConnection)
        {
            Console.WriteLine("After all changes:");
            Console.WriteLine($"User2 see: {secondConnection.Employees.First().FirstName}\n");
        }

        private static void PrintActualResult()
        {
            using (var northwindEntities = new NorthwindEntities())
            {
                Console.WriteLine($"Actual result: {northwindEntities.Employees.First().FirstName}\n");
            }
        }
    }
}
