namespace Common_Type_System.Tests
{
    using Models;
    using System;

    public class BitArrayRunTest
    {
        public static void Run()
        {
            var number = new BitArray(190);

            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Number as Array of Bits!!!");
            Console.WriteLine(string.Join("", number.ArrayOfBits));

            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Indexer!!!");
            Console.WriteLine(number[21]);
            Console.WriteLine(number[30]);
            Console.WriteLine(number[6]);
            Console.WriteLine(number[29]);
            Console.WriteLine(new string('*', 40));

            Console.WriteLine("Checking Enumerator!!!");
            Console.WriteLine();

            foreach (var bit in number)
            {
                Console.Write(bit + " ");
            }

            Console.WriteLine();
            Console.WriteLine(new string('*', 40));

            var secondNumber = new BitArray(12);
            var thirdNumber = new BitArray(245);

            Console.WriteLine("First Number with Equals Method to Second Number: " + number.Equals(secondNumber));
            Console.WriteLine("First Number with Equals to - 10111011: " + number.Equals("10111011"));
            Console.WriteLine("First Number with Eqauls Method to Third Number: " + number.Equals(thirdNumber));
            Console.Write("First Number \"==\" Second Number: ");
            Console.Write(number == secondNumber);
            Console.WriteLine();
            Console.Write("First Number \"!=\" Third Number: ");
            Console.Write(number != thirdNumber);
            Console.WriteLine();


        }
    }
}
