namespace Extensions
{
    using System;
    using System.Text;

    public class StringBuilderRunTest
    {
        public static void Run()
        {
            Console.WriteLine(new string('*', 40));
            var sb = new StringBuilder();
            sb.Append("Hello there young padawan!!!");
            Console.WriteLine("Initial StringBuilder value: {0}", sb);
            Console.WriteLine("StringBuilder value with MySubstring method: {0}",sb.MySubString(4, 8));
            Console.WriteLine(new string('*', 40));
        }
    }
}
