namespace PersonGenerator
{
    using System;

    using Entities;

    public class StartUp
    {
        public static void Main()
        {
            var malePerson = new Person(20);
            Console.WriteLine(malePerson);

            var femalePerson = new Person(19);
            Console.WriteLine(femalePerson);
        }
    }
}
