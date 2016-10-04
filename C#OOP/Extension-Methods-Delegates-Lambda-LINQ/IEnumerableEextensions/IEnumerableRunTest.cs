namespace IEnumerableEextensions
{
    using IEnumerableExtensions;
    using System;
    using System.Collections.Generic;

    public class IEnumerableRunTest
    {
        public static void Run()
        {
            IEnumerable<int> array = new int[] { 2, 4, 4, 5, 6, 2, 235, 6, 9, 10 };

            Console.WriteLine("Intial array values: {0}", string.Join(", " ,array));
            Console.WriteLine("The total sum is: {0}", array.MySum<int>());
            Console.WriteLine("The total product: {0}", array.MyProduct<int>());
            Console.WriteLine("The min value is: {0}", array.MyMin<int>());
            Console.WriteLine("The max value is: {0}", array.MyMax<int>());
            Console.WriteLine("The average sum is: {0}", array.MyAverage<int>());
            Console.WriteLine(new string('*', 40));
        }
    }
}
