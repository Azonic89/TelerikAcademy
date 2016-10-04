namespace TaskTwo.Statistics.Models
{
    using System;

    using Contracts;

    public class ConsolePrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
