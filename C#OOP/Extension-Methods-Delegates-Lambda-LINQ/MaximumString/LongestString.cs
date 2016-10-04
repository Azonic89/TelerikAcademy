namespace MaximumString
{
    using System;
    using System.Linq;

    public class LongestString
    {
        public static void Run()
        {
            var array = new string[] { "Star Wars", "Game Of Thrones", "Breaking Bad", "Malcolm", "Dexter" };

            Console.Write("Intial array of strings values: ");
            Console.WriteLine(string.Join(", " , array));

            var maxLenght = array.OrderByDescending(x => x.Length).First();

            Console.WriteLine("The String with maximum Lenght is: {0}", maxLenght);
            Console.WriteLine(new string('*', 40));
        }
    }
}
