namespace Common_Type_System.Tests
{
    using Models;
    using System;

    public class PersonRunTest
    {
        public static void Run()
        {
            Person firstPerson = new Person("Galio Shefov Gumurov", 26);
            Person secondPerson = new Person("Pesho Petrov Penevich", null);
            Console.WriteLine(new string('*', 40));
            Console.WriteLine(firstPerson);
            Console.WriteLine(secondPerson);
        }
    }
}
