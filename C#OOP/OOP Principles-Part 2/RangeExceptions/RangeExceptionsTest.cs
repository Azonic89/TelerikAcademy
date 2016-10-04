namespace RangeExceptions
{
    using System;

    public class RangeExceptionsTest
    {
        static void IntegerTest(int start, int end, int inputNumber)
        {
            try
            {
                if (inputNumber < start || inputNumber > end)
                {
                    throw new InvalidRangeException<int>("Number is out of range!", start, end);
                }
                else
                {
                    Console.WriteLine("The number is in the range!");
                }
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("The range is [{0} - {1}]", ex.Start, ex.End);
            }
        }

        static void DateTimeTest(DateTime start, DateTime end, DateTime inputDate)
        {
            try
            {
                if (inputDate < start || inputDate > end)
                {
                    throw new InvalidRangeException<DateTime>("Date is out of range!", start, end);
                }
                else
                {
                    Console.WriteLine("The date is in the range!");
                }
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("The range is [{0} - {1}]", ex.Start, ex.End);
            }
        }

        public static void Run()
        {
            IntegerTest(1, 4, 5);
            DateTimeTest(new DateTime(1991, 8, 7), new DateTime(1991, 8, 18), new DateTime(1991, 8, 20));
        }
    }
}
