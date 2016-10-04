namespace PrintNumbers
{
    using System;
    using System.Linq;

    public class PrintNumbers
    {
        public static void PrintNumbersUsingLambda(int[] array)
        {
            var numbers = array.Where(x => (x % 21) == 0);

            Console.WriteLine("Numbers that are divisible by 7 and 3 at same time Using Lambda: ");

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void PrintNumbersUsingLINQ(int[] array)
        {
            var numbers =
                from number in array
                where number % 21 == 0
                select number;

            Console.WriteLine("Numbers that are divisible by 7 and 3 at same time Using LINQ: ");

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
