namespace Extension_Methods_Delegates_Lambda_LINQ
{
    using System;
    using Extensions;
    using Students;
    using IEnumerableEextensions;
    using PrintNumbers;
    using TimerDelegate;
    using StudentsInfo;
    using MaximumString;
    using ExtractStudents;

    public class Startup
    {
        public static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            StringBuilderRunTest.Run();
            IEnumerableRunTest.Run();
            StudentsRunTest.Run();
            PrintNumbersRunTest.Run();
            TimerRunTest.Run();
            StudentInfoRunTest.Run();
            LongestString.Run();
            ExtractStudnetsRunTest.Run();
        }
    }
}
