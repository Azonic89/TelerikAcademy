namespace PrintNumbers
{
    using System;

    public class PrintNumbersRunTest
    {
        public static void Run()
        {
            int[] array = { 7, 3, 21, 123, 3134, 34, 5, 7, 9, 12, 1203, 11, 42};

            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Intial array values: {0}", string.Join(", ", array));
            PrintNumbers.PrintNumbersUsingLambda(array);
            PrintNumbers.PrintNumbersUsingLINQ(array);
            Console.WriteLine(new string('*', 40));
        }
    }
}
